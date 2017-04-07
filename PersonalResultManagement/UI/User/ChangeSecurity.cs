using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PersonalResultManagement.Data.Model;
using PersonalResultManagement.Repository.Security;
using PersonalResultManagement.Repository.Student;
using PersonalResultManagement.UI.Helper;
using Telerik.WinControls;

namespace PersonalResultManagement.UI.User
{
    public partial class ChangeSecurity : Telerik.WinControls.UI.RadForm
    {
        public int UserId;
        private Student _student;
        private Security _security;
        private EloquentStudentRepository _eloquentStudentRepository;
        private EloquentSecurityRepository _eloquentSecurityRepository;

        public ChangeSecurity(int userId)
        {
            InitializeComponent();
            _eloquentStudentRepository = new EloquentStudentRepository();
            _eloquentSecurityRepository = new EloquentSecurityRepository();

            UserId = userId;

            _student = _eloquentStudentRepository.GetStudentDetails(UserId);
            _security = _eloquentSecurityRepository.GetStudentSecurity(UserId);

            txtQuestion.Text = _security.Question;
            txtAnsw.Text = _security.Answer;
        }

        private void btnChangeSecurity_Click(object sender, EventArgs e)
        {
            General.IsFieldFilled(new List<object>{txtPassword, txtQuestion, txtAnsw}, lblError);
            if (txtPassword.Text.ToLower().Trim() == _student.Password.ToLower().Trim())
            {
                var isUpdated = _eloquentSecurityRepository.Update(new Security()
                {
                    Matric = UserId,
                    Question = txtQuestion.Text,
                    Answer = txtAnsw.Text
                });

                if (!isUpdated)
                {
                    lblError.Text = @"Error in saving security";
                }
                else
                {
                    Close();
                }
            }
            else
            {
                lblError.Text = @"Password is not correct";
            } 
        }
    }
}
