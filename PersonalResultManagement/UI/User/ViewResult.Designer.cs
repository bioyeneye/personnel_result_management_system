namespace PersonalResultManagement.UI.User
{
    partial class ViewResult
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.lblSemester = new Telerik.WinControls.UI.RadLabel();
            this.lblLevel = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.lblError = new Telerik.WinControls.UI.RadLabel();
            this.gridCourse = new Telerik.WinControls.UI.RadGridView();
            this.btnUpdate = new Telerik.WinControls.UI.RadButton();
            this.cBoxLevel = new System.Windows.Forms.ComboBox();
            this.cBoxSemester = new System.Windows.Forms.ComboBox();
            this.btnLoadResult = new Telerik.WinControls.UI.RadButton();
            this.btnEnableUpdate = new Telerik.WinControls.UI.RadButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCGPA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lblSemester)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourse.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEnableUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSemester
            // 
            this.lblSemester.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSemester.Location = new System.Drawing.Point(12, 44);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(70, 19);
            this.lblSemester.TabIndex = 6;
            this.lblSemester.Text = "Semester : ";
            // 
            // lblLevel
            // 
            this.lblLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLevel.Location = new System.Drawing.Point(12, 12);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(47, 19);
            this.lblLevel.TabIndex = 5;
            this.lblLevel.Text = "Level : ";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox1.Controls.Add(this.lblError);
            this.radGroupBox1.Controls.Add(this.gridCourse);
            this.radGroupBox1.Controls.Add(this.btnUpdate);
            this.radGroupBox1.Enabled = false;
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderText = "Result";
            this.radGroupBox1.Location = new System.Drawing.Point(17, 77);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(954, 435);
            this.radGroupBox1.TabIndex = 12;
            this.radGroupBox1.Text = "Result";
            this.radGroupBox1.ThemeName = "TelerikMetroBlue";
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblError.ForeColor = System.Drawing.Color.Black;
            this.lblError.Location = new System.Drawing.Point(141, 399);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(2, 2);
            this.lblError.TabIndex = 17;
            // 
            // gridCourse
            // 
            this.gridCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCourse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gridCourse.GroupExpandAnimationType = Telerik.WinControls.UI.GridExpandAnimationType.Slide;
            this.gridCourse.Location = new System.Drawing.Point(12, 31);
            // 
            // 
            // 
            this.gridCourse.MasterTemplate.AllowColumnReorder = false;
            this.gridCourse.MasterTemplate.AllowDeleteRow = false;
            this.gridCourse.MasterTemplate.AllowRowResize = false;
            this.gridCourse.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.gridCourse.MasterTemplate.EnableSorting = false;
            this.gridCourse.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gridCourse.Name = "gridCourse";
            this.gridCourse.Size = new System.Drawing.Size(931, 350);
            this.gridCourse.TabIndex = 10;
            this.gridCourse.Text = "radGridView1";
            this.gridCourse.ThemeName = "TelerikMetro";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.Location = new System.Drawing.Point(13, 387);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 44);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.ThemeName = "TelerikMetro";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cBoxLevel
            // 
            this.cBoxLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxLevel.FormattingEnabled = true;
            this.cBoxLevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cBoxLevel.Location = new System.Drawing.Point(87, 13);
            this.cBoxLevel.Name = "cBoxLevel";
            this.cBoxLevel.Size = new System.Drawing.Size(248, 21);
            this.cBoxLevel.TabIndex = 13;
            // 
            // cBoxSemester
            // 
            this.cBoxSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxSemester.FormattingEnabled = true;
            this.cBoxSemester.Items.AddRange(new object[] {
            "Harmattan",
            "Rain"});
            this.cBoxSemester.Location = new System.Drawing.Point(87, 43);
            this.cBoxSemester.Name = "cBoxSemester";
            this.cBoxSemester.Size = new System.Drawing.Size(248, 21);
            this.cBoxSemester.TabIndex = 14;
            // 
            // btnLoadResult
            // 
            this.btnLoadResult.Location = new System.Drawing.Point(385, 13);
            this.btnLoadResult.Name = "btnLoadResult";
            this.btnLoadResult.Size = new System.Drawing.Size(109, 44);
            this.btnLoadResult.TabIndex = 15;
            this.btnLoadResult.Text = "Load Result";
            this.btnLoadResult.ThemeName = "TelerikMetro";
            this.btnLoadResult.Click += new System.EventHandler(this.btnLoadResult_Click);
            // 
            // btnEnableUpdate
            // 
            this.btnEnableUpdate.Enabled = false;
            this.btnEnableUpdate.Location = new System.Drawing.Point(513, 13);
            this.btnEnableUpdate.Name = "btnEnableUpdate";
            this.btnEnableUpdate.Size = new System.Drawing.Size(109, 44);
            this.btnEnableUpdate.TabIndex = 16;
            this.btnEnableUpdate.Text = "Enable for update";
            this.btnEnableUpdate.ThemeName = "TelerikMetro";
            this.btnEnableUpdate.Click += new System.EventHandler(this.btnEnableUpdate_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(932, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "CGP";
            // 
            // txtCGPA
            // 
            this.txtCGPA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCGPA.AutoSize = true;
            this.txtCGPA.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtCGPA.Location = new System.Drawing.Point(924, 37);
            this.txtCGPA.Name = "txtCGPA";
            this.txtCGPA.Size = new System.Drawing.Size(0, 20);
            this.txtCGPA.TabIndex = 18;
            // 
            // ViewResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 517);
            this.Controls.Add(this.txtCGPA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnableUpdate);
            this.Controls.Add(this.btnLoadResult);
            this.Controls.Add(this.cBoxSemester);
            this.Controls.Add(this.cBoxLevel);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.lblSemester);
            this.Controls.Add(this.lblLevel);
            this.Name = "ViewResult";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "ViewResult";
            this.ThemeName = "Windows8";
            ((System.ComponentModel.ISupportInitialize)(this.lblSemester)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourse.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEnableUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.UI.RadLabel lblSemester;
        private Telerik.WinControls.UI.RadLabel lblLevel;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGridView gridCourse;
        private Telerik.WinControls.UI.RadButton btnUpdate;
        private System.Windows.Forms.ComboBox cBoxLevel;
        private System.Windows.Forms.ComboBox cBoxSemester;
        private Telerik.WinControls.UI.RadButton btnLoadResult;
        private Telerik.WinControls.UI.RadButton btnEnableUpdate;
        private Telerik.WinControls.UI.RadLabel lblError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtCGPA;
    }
}
