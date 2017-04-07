using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PersonalResultManagement.Data.Model;
using PersonalResultManagement.Repository.Student;
using PersonalResultManagement.UI.Helper;
using Telerik.WinControls;

namespace PersonalResultManagement.UI.User
{
    public partial class ChangePassword : Telerik.WinControls.UI.RadForm
    {
        public int UserId;
        private Student _Student;
        private EloquentStudentRepository _eloquentStudentRepository;
        public ChangePassword(int userId)
        {
            InitializeComponent();
            _eloquentStudentRepository = new EloquentStudentRepository();

            UserId = userId;
            _Student = _eloquentStudentRepository.GetStudentDetails(UserId);
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            General.IsFieldFilled(new List<object>{txtOldPassword,txtPassowrd, txtTryPassword}, lblError);
            if (txtOldPassword.Text.ToLower().Trim() == _Student.Password.ToLower().Trim())
            {
                if (txtPassowrd.Text.ToLower().Trim() != txtTryPassword.Text.ToLower().Trim())
                {
                    lblError.Text = @"Password not match";
                    return;                    
                }

                var isUpdated = _eloquentStudentRepository.UpdateStudent(UserId, new Student
                {
                    Password = txtPassowrd.Text
                });

                if (!isUpdated)
                {
                    lblError.Text = @"Password can not be updated";
                    return;
                }
                else
                {
                    Close();
                }
            }
            else
            {
                lblError.Text = @"Old Password is not correct";
            } 


        }


    }
}
