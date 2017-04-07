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
using PersonalResultManagement.UI.Layout;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace PersonalResultManagement.UI.Authentication
{
    public partial class Register : Telerik.WinControls.UI.RadForm
    {
        private bool isPassword = true;
        private EloquentStudentRepository _eloquentStudentRepository;
        private EloquentSecurityRepository _eloquentSecurityRepository;
        public Register()
        {
            InitializeComponent();
            _eloquentStudentRepository = new EloquentStudentRepository();
            _eloquentSecurityRepository = new EloquentSecurityRepository();

            txtPassword.UseSystemPasswordChar = isPassword;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            General.ClearField(new List<object> { txtMatricNumber, txtPassword, txtQuestion, txtAnswer  });
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            bool isFieldFilled = General.IsFieldFilled(new List<object> { txtMatricNumber, txtPassword, txtQuestion, txtAnswer }, lblError);
            if (!isFieldFilled)
            {
                Student student = new Student
                {
                    MatricNumber = txtMatricNumber.Text,
                    Password = txtPassword.Text,
                    Level = 1,
                    Semester = 1
                };


                if (!_eloquentStudentRepository.IsStudentMember(student.MatricNumber, student.Password))
                {
                    bool isRegister = _eloquentStudentRepository.Register(student);

                    int userId = _eloquentStudentRepository.GetStudentId(student.MatricNumber);

                    Security security = new Security
                    {
                        Matric = userId,
                        Question = txtQuestion.Text,
                        Answer = txtAnswer.Text
                    };
                    bool isSaved = _eloquentSecurityRepository.Save(security);

                    if (isSaved && isRegister)
                    {
                        Master master = new Master {UserId = userId};
                        master.Show();
                        Hide();
                    }
                }
                else
                {
                    lblError.Text = @"Student is a member already";
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Hide();
        }

        private void cBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {            
            txtPassword.UseSystemPasswordChar = !cBoxShowPassword.Checked;            
        }       
    }
}
