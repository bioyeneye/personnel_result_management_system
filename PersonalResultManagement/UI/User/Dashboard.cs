using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PersonalResultManagement.Data;
using PersonalResultManagement.Data.Model;
using PersonalResultManagement.Repository.Student;
using PersonalResultManagement.UI.Authentication;
using Telerik.WinControls;
using Student = PersonalResultManagement.Data.Model.Student;

namespace PersonalResultManagement.UI.User
{
    public partial class Dashboard : Telerik.WinControls.UI.RadForm
    {
        public int UserId;

        private EloquentStudentRepository _eloquentStudentRepository;
        private Student _student;

        public Dashboard(int userId)
        {
            InitializeComponent();
            UserId = userId;
            _eloquentStudentRepository = new EloquentStudentRepository();
            _student = _eloquentStudentRepository.GetStudentDetails(UserId);

            lblSignin.Text = @"Signin in with matric number : " + _student.MatricNumber;
            lblMatric.Text = String.Format("Matric Number: {0}", _student.MatricNumber);
            lblLevel.Text = String.Format("Level : {0}L",
                Data.DataSingleton.CreateDataContext().LevelTables.First(l => l.id == _student.Level).level);
            lblSemester.Text = String.Format("Semester : {0}",
                Data.DataSingleton.CreateDataContext()
                    .SemesterTables.First(l => l.id == _student.Semester)
                    .name.ToUpper());

            LoadResult();
            LoadFormerResult();
            LoadForwardResult();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();            
            MdiParent.Hide();
            login.Show();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            ChangePassword password = new ChangePassword(UserId);
            password.ShowDialog();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            ChangeSecurity security = new ChangeSecurity(UserId);
            security.ShowDialog();
        }

        private void LoadResult()
        {
            int level = _student.Level;
            int semester = _student.Semester;

            int section = 0;
            int sectionAll = 0;

            sectionAll = SectionAll(level, semester);

            if (sectionAll > 0)
            {
                int computeLevel = 1;
                int computeSemester = 1;
                float points = 0;
                float units = 0;
                while (sectionAll > 0)
                {
                    var result = ComputeCgp(computeLevel, computeLevel);
                    points += result[1];
                    units += result[0];

                    sectionAll -= 1;
                    if (computeSemester == 2)
                    {
                        computeLevel += 1;
                        computeSemester = 1;
                    }
                    else
                    {
                        computeSemester = 2;
                    }
                }

                float cgpa = points/(float) units;

                lblPoint.Text = String.Format("Point : {0}", points);
                lblUnit.Text = String.Format("Unit : {0}", units);
                lblCGP.Text = String.Format("CGPA : {0:F}", cgpa);
            }
            else
            {
                lblPoint.Text = String.Format("Point : {0}", "");
                lblUnit.Text = String.Format("Unit : {0}", "");
                lblCGP.Text = String.Format("CGPA : {0}", "");
            }
        }

        private int SectionAll(int level, int semester)
        {
            int sectionAll = 0;
            int section = 0;
            switch (level)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                {
                    section = level - 1;
                    sectionAll = (section*2) + ((semester == 2) ? 1 : 0);
                }
                    break;
            }
            return sectionAll;
        }

        public int GetGrade(int score)
        {
            var value = 0;
            if (score >= 70) value = 5;
            else if (score >= 60 && score < 70) value = 4;
            else if (score >= 50 && score < 60) value = 3;
            else if (score >= 45 && score < 50) value = 2;
            else if (score >= 40 && score < 45) value = 1;
            else value = 0;

            return value;
        }

        public List<float> ComputeCgp(int level, int semester)
        {
            float gp = 0;
            int unit = 0;
            int point = 0;

            var queryable = Data.DataSingleton.CreateDataContext()
                .Results
                .Where(
                    r =>
                        r.student_id == UserId && r.CourseTable.level_id == level &&
                        r.CourseTable.semester_id == semester)
                .AsEnumerable()
                .ToList();

            queryable.ForEach((result) =>
            {
                unit += result.CourseTable.unit;
                point += GetGrade(result.score)*result.CourseTable.unit;
            });

            gp = (float) point/unit;

            return new List<float> {unit, point, gp};
        }

        public void LoadFormerResult()
        {
            int level = _student.Level;
            int semester = _student.Semester;
            int computeSectionSemster = SectionAll(level, semester);

            if (computeSectionSemster > 0)
            {
//                int formerLevel = (computeSectionSemster - ((semester == 2) ? 1 : 0))/2;
                int formerLevel = computeSectionSemster%2 != 0
                    ? (computeSectionSemster/2) + 1
                    : (computeSectionSemster/2);
                int formersemster = ((computeSectionSemster%2) == 0) ? 2 : 1;

                if (formerLevel == 0) formerLevel = 1;

                var queryable = Data.DataSingleton.CreateDataContext()
                    .Results
                    .Where(
                        r =>
                            r.student_id == UserId && r.CourseTable.level_id == formerLevel &&
                            r.CourseTable.semester_id == formersemster)
                    .Select(r=> new
                    {
                        Title = r.CourseTable.title,
                        Code = r.CourseTable.code,
                        Score = r.score
                    
                    })
                    .AsEnumerable()
                    .ToList();

                gridPResult.DataSource = queryable;
            }


        }

        public void LoadForwardResult()
        {
            int level = _student.Level;
            int semester = _student.Semester;

            var queryable = Data.DataSingleton.CreateDataContext()
                .Results
                .Where(
                    r =>
                        r.student_id == UserId && r.CourseTable.level_id == level &&
                        r.CourseTable.semester_id == semester).AsEnumerable().ToList();


            if (queryable.Count == 0)
            {
                if (_student.Level != 5 && _student.Semester < 3)
                {

                    var courses = DataSingleton.CreateDataContext()
                        .CourseTables.Where(c => c.level_id == _student.Level && c.semester_id == _student.Semester)
                        .Select(c => new Course()
                        {
                            Id = c.id,
                            Title = c.title,
                            CodeCode = c.code,
                            Unit = c.unit,
                        }).AsEnumerable().ToList();

                    gridFCourse.DataSource = courses;
                }

            }

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}

