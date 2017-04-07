using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PersonalResultManagement.Data.Model;
using PersonalResultManagement.Repository.Student;
using Telerik.WinControls;
using Telerik.Windows.Diagrams.Core;
using Result = PersonalResultManagement.Data.Result;

namespace PersonalResultManagement.UI.User
{
    public partial class ViewResult : Telerik.WinControls.UI.RadForm
    {
        public int UserId;
        private EloquentStudentRepository _eloquentStudentRepository;
        private Student _student;
        private int level;
        private int semester;
        private List<Course> courses;
        public ViewResult(int userId)
        {
            InitializeComponent(); 
            _eloquentStudentRepository = new EloquentStudentRepository();
            UserId = userId;
            _student = _eloquentStudentRepository.GetStudentDetails(UserId);

            cBoxLevel.SelectedIndex = 0;
            cBoxSemester.SelectedIndex = 0;

        }

        private void btnLoadResult_Click(object sender, EventArgs e)
        {
            level = cBoxLevel.SelectedIndex + 1;
            semester = cBoxSemester.SelectedIndex +1;

            btnEnableUpdate.Enabled = false;

            var queryable = QueryableResultBySemesterLevel(level, semester);

            if (queryable.Count > 0)
            {
                btnEnableUpdate.Enabled = true;

                double cgpa = 0.0;
                int tcf = 0;
                int unit = 0;

                courses = new List<Course>();
                queryable.ForEach((result) =>
                {

                    unit += result.CourseTable.unit;
                    tcf += GetGrade(result.score)*result.CourseTable.unit;

                    courses.Add(new Course()
                    {
                        Id = result.course_id,
                        CodeCode = result.CourseTable.code,
                        Score = result.score,
                        Title = result.CourseTable.title,
                        Unit = result.CourseTable.unit
                    });
                });

                gridCourse.DataSource = courses;


                txtCGPA.Text = ((double) tcf/unit).ToString("F2");

            }
            else
            {
                btnEnableUpdate.Enabled = false;
                MessageBox.Show(@"No result yet");
            }
        }

        private void btnEnableUpdate_Click(object sender, EventArgs e)
        {
            radGroupBox1.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            /*var queryable = QueryableResultBySemesterLevel(level, semester);
           
            queryable.ForEach((r) =>
            {
                r.score = newResult.Find(n => n.Id == r.course_id).Score;
            });*/

            var newResult = (List<Course>)gridCourse.DataSource;
            var results = Data.DataSingleton.CreateDataContext().Results
                .Where(
                    r =>
                        r.student_id == UserId && r.CourseTable.level_id == level &&
                        r.CourseTable.semester_id == semester);

            results.ForEach((r) =>
            {
                r.score = newResult.Find(n => n.Id == r.course_id).Score;
            });

            Data.DataSingleton.CreateDataContext().SubmitChanges();
            lblError.Text = @"Result Updated";
        }

        private List<Result> QueryableResultBySemesterLevel(int queryLevel, int querySemester)
        {
            var queryable = Data.DataSingleton.CreateDataContext()
                .Results
                .Where(r => r.student_id == UserId && r.CourseTable.level_id == queryLevel && r.CourseTable.semester_id == querySemester)
                .AsEnumerable()
                .ToList();
            return queryable;
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
    }
}
