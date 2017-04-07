namespace PersonalResultManagement.UI.Layout
{
    partial class Master
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Master));
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.radRibbonBar1 = new Telerik.WinControls.UI.RadRibbonBar();
            this.ribbonTab1 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup1 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.btnDashboard = new Telerik.WinControls.UI.RadButtonElement();
            this.ribbonTab4 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup2 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.btnChangePassword = new Telerik.WinControls.UI.RadButtonElement();
            this.btnChangeSecurity = new Telerik.WinControls.UI.RadButtonElement();
            this.ribbonTab2 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup3 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.btnAddResult = new Telerik.WinControls.UI.RadButtonElement();
            this.btnViewResult = new Telerik.WinControls.UI.RadButtonElement();
            this.ribbonTab3 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup4 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radButtonElement1 = new Telerik.WinControls.UI.RadButtonElement();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 473);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(832, 26);
            this.radStatusStrip1.SizingGrip = false;
            this.radStatusStrip1.TabIndex = 1;
            this.radStatusStrip1.Text = "radStatusStrip1";
            // 
            // radRibbonBar1
            // 
            this.radRibbonBar1.CommandTabs.AddRange(new Telerik.WinControls.RadItem[] {
            this.ribbonTab1,
            this.ribbonTab4,
            this.ribbonTab2,
            this.ribbonTab3});
            this.radRibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.radRibbonBar1.Name = "radRibbonBar1";
            // 
            // 
            // 
            this.radRibbonBar1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radRibbonBar1.Size = new System.Drawing.Size(832, 154);
            this.radRibbonBar1.StartButtonImage = ((System.Drawing.Image)(resources.GetObject("radRibbonBar1.StartButtonImage")));
            this.radRibbonBar1.StartMenuItems.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1});
            this.radRibbonBar1.TabIndex = 0;
            this.radRibbonBar1.Text = "Master";
            this.radRibbonBar1.ThemeName = "TelerikMetroBlue";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.AccessibleDescription = "Master";
            this.ribbonTab1.AccessibleName = "Master";
            this.ribbonTab1.IsSelected = true;
            this.ribbonTab1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup1});
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "Dashboard";
            // 
            // radRibbonBarGroup1
            // 
            this.radRibbonBarGroup1.AccessibleDescription = "Master";
            this.radRibbonBarGroup1.AccessibleName = "Master";
            this.radRibbonBarGroup1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnDashboard});
            this.radRibbonBarGroup1.Name = "radRibbonBarGroup1";
            this.radRibbonBarGroup1.Text = "Master";
            // 
            // btnDashboard
            // 
            this.btnDashboard.AccessibleDescription = "Master";
            this.btnDashboard.AccessibleName = "Master";
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // ribbonTab4
            // 
            this.ribbonTab4.AccessibleDescription = "Account";
            this.ribbonTab4.AccessibleName = "Account";
            this.ribbonTab4.IsSelected = false;
            this.ribbonTab4.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup2});
            this.ribbonTab4.Name = "ribbonTab4";
            this.ribbonTab4.Text = "Account";
            // 
            // radRibbonBarGroup2
            // 
            this.radRibbonBarGroup2.AccessibleDescription = "Account";
            this.radRibbonBarGroup2.AccessibleName = "Account";
            this.radRibbonBarGroup2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnChangePassword,
            this.btnChangeSecurity});
            this.radRibbonBarGroup2.Name = "radRibbonBarGroup2";
            this.radRibbonBarGroup2.Text = "Account";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.AccessibleDescription = "Change Password";
            this.btnChangePassword.AccessibleName = "Change Password";
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnChangeSecurity
            // 
            this.btnChangeSecurity.AccessibleDescription = "Change Security";
            this.btnChangeSecurity.AccessibleName = "Change Security";
            this.btnChangeSecurity.Name = "btnChangeSecurity";
            this.btnChangeSecurity.Text = "Change Security";
            this.btnChangeSecurity.Click += new System.EventHandler(this.btnChangeSecurity_Click);
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.AccessibleDescription = "Result";
            this.ribbonTab2.AccessibleName = "Result";
            this.ribbonTab2.IsSelected = false;
            this.ribbonTab2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup3});
            this.ribbonTab2.Name = "ribbonTab2";
            this.ribbonTab2.Text = "Result";
            // 
            // radRibbonBarGroup3
            // 
            this.radRibbonBarGroup3.AccessibleDescription = "Result";
            this.radRibbonBarGroup3.AccessibleName = "Result";
            this.radRibbonBarGroup3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnAddResult,
            this.btnViewResult});
            this.radRibbonBarGroup3.Name = "radRibbonBarGroup3";
            this.radRibbonBarGroup3.Text = "Result";
            // 
            // btnAddResult
            // 
            this.btnAddResult.AccessibleDescription = "Add Result";
            this.btnAddResult.AccessibleName = "Add Result";
            this.btnAddResult.Name = "btnAddResult";
            this.btnAddResult.Text = "Add Result";
            this.btnAddResult.Click += new System.EventHandler(this.btnAddResult_Click);
            // 
            // btnViewResult
            // 
            this.btnViewResult.AccessibleDescription = "View Result";
            this.btnViewResult.AccessibleName = "View Result";
            this.btnViewResult.Name = "btnViewResult";
            this.btnViewResult.Text = "View Result";
            this.btnViewResult.Click += new System.EventHandler(this.btnViewResult_Click);
            // 
            // ribbonTab3
            // 
            this.ribbonTab3.AccessibleDescription = "About";
            this.ribbonTab3.AccessibleName = "About";
            this.ribbonTab3.IsSelected = false;
            this.ribbonTab3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup4});
            this.ribbonTab3.Name = "ribbonTab3";
            this.ribbonTab3.Text = "About";
            // 
            // radRibbonBarGroup4
            // 
            this.radRibbonBarGroup4.AccessibleDescription = "About Project";
            this.radRibbonBarGroup4.AccessibleName = "About Project";
            this.radRibbonBarGroup4.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement1});
            this.radRibbonBarGroup4.Name = "radRibbonBarGroup4";
            this.radRibbonBarGroup4.Text = "About Project";
            // 
            // radButtonElement1
            // 
            this.radButtonElement1.AccessibleDescription = "About Project";
            this.radButtonElement1.AccessibleName = "About Project";
            this.radButtonElement1.Name = "radButtonElement1";
            this.radButtonElement1.Text = "About Project";
            this.radButtonElement1.Click += new System.EventHandler(this.radButtonElement1_Click);
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.AccessibleDescription = "radMenuItem1";
            this.radMenuItem1.AccessibleName = "radMenuItem1";
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "radMenuItem1";
            // 
            // Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 499);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.radRibbonBar1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = null;
            this.Name = "Master";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Master";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Master_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadRibbonBar radRibbonBar1;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private Telerik.WinControls.UI.RibbonTab ribbonTab1;
        private Telerik.WinControls.UI.RibbonTab ribbonTab2;
        private Telerik.WinControls.UI.RibbonTab ribbonTab3;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup1;
        private Telerik.WinControls.UI.RadButtonElement btnDashboard;
        private Telerik.WinControls.UI.RibbonTab ribbonTab4;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup2;
        private Telerik.WinControls.UI.RadButtonElement btnChangePassword;
        private Telerik.WinControls.UI.RadButtonElement btnChangeSecurity;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup3;
        private Telerik.WinControls.UI.RadButtonElement btnAddResult;
        private Telerik.WinControls.UI.RadButtonElement btnViewResult;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup4;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement1;
    }
}
