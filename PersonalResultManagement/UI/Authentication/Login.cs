using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PersonalResultManagement.Repository.Student;
using PersonalResultManagement.UI.Helper;
using PersonalResultManagement.UI.Layout;
using Telerik.WinControls;

namespace PersonalResultManagement.UI.Authentication
{
    public partial class Login : Telerik.WinControls.UI.RadForm
    {
        private EloquentStudentRepository _eloquentStudentRepository;
        public Login()
        {
            _eloquentStudentRepository = new EloquentStudentRepository();
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            General.IsFieldFilled(new List<object> {txtMatric, txtPassword}, lblError);

            int userId = _eloquentStudentRepository.GetStudentId(txtMatric.Text);

            if (_eloquentStudentRepository.IsStudentMember(txtMatric.Text, txtPassword.Text))
            {
                Master master = new Master {UserId = userId};               
                master.Show();
                Hide();
            }
            else
            {
                lblError.Text = @"Login credential is not found";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMatric.Text))
            {
                lblError.Text = @"Matric  Number is required";
                return;
            }

            if (_eloquentStudentRepository.GetStudentId(txtMatric.Text.Trim()) == 0)
            {
                lblError.Text = @"Matric  Number is invalid";
                return;        
            }

            ResetPassword password = new ResetPassword{UserId = _eloquentStudentRepository.GetStudentId(txtMatric.Text.Trim())};
            password.Show();
            Hide();
        }
    }
}
