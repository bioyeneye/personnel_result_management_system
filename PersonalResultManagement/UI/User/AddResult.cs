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
using Telerik.WinControls;
using Result = PersonalResultManagement.Data.Result;
using Student = PersonalResultManagement.Data.Model.Student;

namespace PersonalResultManagement.UI.User
{
    public partial class AddResult : Telerik.WinControls.UI.RadForm
    {
        public int UserId;
        private EloquentStudentRepository _eloquentStudentRepository;
        private Student _student;
        private List<Course> _courses; 
        public AddResult(int userId)
        {
            InitializeComponent();
            _eloquentStudentRepository = new EloquentStudentRepository();
            UserId = userId;
            _student = _eloquentStudentRepository.GetStudentDetails(UserId);

            lblLevel.Text = String.Format("Level : {0}L",
                Data.DataSingleton.CreateDataContext().LevelTables.First(l => l.id == _student.Level).level);
            lblSemester.Text = String.Format("Semester : {0}",
                Data.DataSingleton.CreateDataContext().SemesterTables.First(l => l.id == _student.Semester).name.ToUpper());
        }

        private void AddResult_Load(object sender, EventArgs e)
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
                #region loading course if the no result yet

                if (_student.Level != 5 && _student.Semester < 3)
                {
                    lblLevel.Text = String.Format("Level : {0}L",
                        DataSingleton.CreateDataContext().LevelTables.First(l => l.id == _student.Level).level);
                    lblSemester.Text = String.Format("Semester : {0}",
                        DataSingleton.CreateDataContext()
                            .SemesterTables.First(l => l.id == _student.Semester)
                            .name.ToUpper());

                    _courses = DataSingleton.CreateDataContext()
                        .CourseTables.Where(c => c.level_id == _student.Level && c.semester_id == _student.Semester)
                        .Select(c => new Course()
                        {
                            Id = c.id,
                            Title = c.title,
                            CodeCode = c.code,
                            Unit = c.unit,
                            Score = 0
                        }).AsEnumerable().ToList();

                    gridCourse.DataSource = _courses;
                }
                else
                {
                    lblError.Text = @"All results are saved kindly view and update.";
                    btnSave.Enabled = false;
                    btnReset.Enabled = false;
                    gridCourse.Enabled = false;
                }

                #endregion}

            }
            else
            {
                MessageBox.Show(@"There is result for this level ans semester already");
                btnSave.Enabled = false;
                btnReset.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isFilled = true;
            var gridData = ((List<Course>)gridCourse.DataSource);
            gridData.ForEach((a) =>
            {
                if (a.Score < 1 || a.Score > 100)
                {
                    isFilled = false;
                }
            });

            if (!isFilled)
            {
                lblError.Text = @"Error : Invalid score";
            }
            else
            {
                List<Result> courses = new List<Data.Result>();

                gridData.ForEach((a) =>
                {
                    courses.Add(new Data.Result()
                    {
                        course_id = a.Id,
                        score = a.Score,
                        student_id = UserId
                    });
                });

                Data.DataSingleton.CreateDataContext().Results.InsertAllOnSubmit(courses);
                Data.DataSingleton.CreateDataContext().SubmitChanges();

                lblError.Text = @"Result Saved";

                var updateStudent = Data.DataSingleton.CreateDataContext().Students.First(s => s.id == UserId);

                if (updateStudent.semeter == 2)
                {                    
                    if (updateStudent.level < 5)
                    {
                        updateStudent.level += 1;
                        updateStudent.semeter = 1;
                    }                                        
                }
                else
                {
                    if (updateStudent.semeter == 1)
                    {
                        updateStudent.semeter = 2;
                    }
                }
                
                Data.DataSingleton.CreateDataContext().SubmitChanges();

                btnSave.Enabled = false;
            }
        } 

        private void btnReset_Click(object sender, EventArgs e)
        {
            AddResult addResult = new AddResult(UserId);
            addResult.MdiParent = MdiParent;
            addResult.Show();
            Close();
        }
    }
}
