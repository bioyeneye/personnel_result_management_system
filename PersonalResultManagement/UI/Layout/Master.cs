using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PersonalResultManagement.UI.User;
using Telerik.Windows.Diagrams.Core;

namespace PersonalResultManagement.UI.Layout
{
    public partial class Master : Telerik.WinControls.UI.RadRibbonForm
    {
        public int UserId;
        public Master()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {            
            ChangePassword password = new ChangePassword(UserId);            
            password.ShowDialog();
        }

        private void btnChangeSecurity_Click(object sender, EventArgs e)
        {
            ChangeSecurity security = new ChangeSecurity(UserId);
            security.ShowDialog();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowDashboard();
        }

        private void Master_Load(object sender, EventArgs e)
        {           
            ShowDashboard();
        }

        private void ShowDashboard()
        {
            MdiChildren.ForEach((a) =>
            {
                a.Close();
            });

            Dashboard dashboard = new Dashboard(UserId)
            {
                MdiParent = this
            };            
            dashboard.Show();
            if (ActiveMdiChild != null) ActiveMdiChild.WindowState = FormWindowState.Maximized;
        }

        private void btnAddResult_Click(object sender, EventArgs e)
        {
            MdiChildren.ForEach((a) =>
            {
                a.Close();
            });

            AddResult addResult = new AddResult(UserId)
            {
                MdiParent = this,
            };
            addResult.Show();
            if (ActiveMdiChild != null) ActiveMdiChild.WindowState = FormWindowState.Maximized;
        }

        private void btnViewResult_Click(object sender, EventArgs e)
        {
            MdiChildren.ForEach((a) =>
            {
                a.Close();
            });

            ViewResult addResult = new ViewResult(UserId)
            {
                MdiParent = this,
            };
            addResult.Show();
            if (ActiveMdiChild != null) ActiveMdiChild.WindowState = FormWindowState.Maximized;
        }

        private void radButtonElement1_Click(object sender, EventArgs e)
        {
            AboutProject aboutProject = new AboutProject();
            aboutProject.ShowDialog();

        }
    }
}
