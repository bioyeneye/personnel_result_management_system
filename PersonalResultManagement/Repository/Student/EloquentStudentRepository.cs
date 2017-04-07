using System;
using System.Linq;
using System.Windows.Forms;

namespace PersonalResultManagement.Repository.Student
{
    using Data.Model;
    using database = Data ;

    class EloquentStudentRepository : IStudentRepositoryContract
    {
        /// <summary>
        /// Register new student for the application
        /// </summary>
        /// <param name="student">Student object</param>
        /// <returns>bool | true [succesful] false[unsuccessful]</returns>
        public bool Register(Student student)
        {
            bool isRegistered = false;

            try
            {
                database.Student dataStudent = new database.Student()
                {
                    matric_number = student.MatricNumber,
                    password = student.Password,
                    level = student.Level,
                    semeter = student.Semester
                }; 
            
                database.DataSingleton.CreateDataContext().Students.InsertOnSubmit(dataStudent);
                database.DataSingleton.CreateDataContext().SubmitChanges();

                isRegistered = true;
            }
            catch (Exception e)
            {
                isRegistered = false;
            }

            return isRegistered;
        }

        public bool Login(Student student)
        {
            throw new System.NotImplementedException();
        }

        public bool ResetPassword(Student student)
        {
            throw new System.NotImplementedException();
        }

        public int GetStudentId(string matric)
        {
            var firstOrDefault = database.DataSingleton.CreateDataContext().Students.FirstOrDefault(s => s.matric_number == matric);
            return (firstOrDefault != null) ? firstOrDefault.id : 0;
        }

        public bool IsStudentMember(string matric, string password)
        {
            return database.DataSingleton.CreateDataContext()
                .Students.Any(s => s.matric_number.ToLower().Trim() == matric.ToLower().Trim() && s.password.ToLower().Trim() == password.ToLower().Trim());
        }

        public bool UpdateStudent(int student, Student studentDetail)
        {
            bool isUpdated = false;
            try
            {
                var stud = database.DataSingleton.CreateDataContext().Students.First(s => s.id == student);                
                stud.password = studentDetail.Password;                

                database.DataSingleton.CreateDataContext().SubmitChanges();

                isUpdated = true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Test");
                isUpdated = false;
            }

            return isUpdated;
        }

        public Student GetStudentDetails(int id)
        {
            var student = database.DataSingleton.CreateDataContext().Students.First(s => s.id == id);
            return new Student()
            {
                MatricNumber = student.matric_number,
                Password = student.password,
                Level = int.Parse(student.level.ToString()),
                Semester = int.Parse(student.semeter.ToString())
            };
        }
    }
}
