using System;
using System.Linq;
using System.Windows.Forms;

namespace PersonalResultManagement.Repository.Security
{
    public class EloquentSecurityRepository : ISecurityRepositoryContract
    {
        public bool Save(Data.Model.Security security)
        {
            bool isSaved = false;

            try
            {
                Data.Security dataStudent = new Data.Security()
                {
                    matric_number = security.Matric,
                    question = security.Question,
                    answer = security.Answer
                };

                Data.DataSingleton.CreateDataContext().Securities.InsertOnSubmit(dataStudent);
                Data.DataSingleton.CreateDataContext().SubmitChanges();

                isSaved = true;
            }
            catch (Exception e)
            {                
                isSaved = false;
            }

            return isSaved;
        }

        public bool Update(Data.Model.Security security)
        {
            bool isSaved = false;

            try
            {
                var securities = Data.DataSingleton.CreateDataContext().Securities.First(s => s.matric_number == security.Matric);
                securities.question = security.Question;
                securities.answer = security.Answer;

                Data.DataSingleton.CreateDataContext().SubmitChanges();

                isSaved = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                isSaved = false;
            }

            return isSaved;
        }

        public Data.Model.Security GetStudentSecurity(int student)
        {
            var security = Data.DataSingleton.CreateDataContext().Securities.First(s => s.matric_number == student);
            return new Data.Model.Security
            {
                Question = security.question,
                Answer = security.answer
            };            
        }
    }
}
