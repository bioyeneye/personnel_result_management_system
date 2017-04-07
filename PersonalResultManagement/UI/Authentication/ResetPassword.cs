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

namespace PersonalResultManagement.UI.Authentication
{
    public partial class ResetPassword : Telerik.WinControls.UI.RadForm
    {
        public int UserId;
        private EloquentStudentRepository _eloquentStudentRepository;
        private EloquentSecurityRepository _eloquentSecurityRepository;
        private Security _security;

        public ResetPassword()
        {
            InitializeComponent();
            _eloquentStudentRepository = new EloquentStudentRepository();
            _eloquentSecurityRepository = new EloquentSecurityRepository();
        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {
            _security = _eloquentSecurityRepository.GetStudentSecurity(UserId);
            txtQuestion.Text = _security.Question;
            //txtAnsw.Text = _security.Answer;
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            General.IsFieldFilled(new List<object> {txtQuestion, txtAnsw}, lblError);

            if (txtAnsw.Text.Trim().ToLower() == _security.Answer.ToLower().Trim())
            {
                bool isUpdated = _eloquentStudentRepository.UpdateStudent(UserId, new Student
                {
                    Password = "password"
                });

                lblError.ForeColor = Color.ForestGreen;
                lblError.Text = @"Password reset to password";
            }
            else
            {
                lblError.Text = @"Answer is not a match";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
