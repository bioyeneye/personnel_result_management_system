namespace PersonalResultManagement.UI.Authentication
{
    partial class ResetPassword
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
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            this.txtQuestion = new Telerik.WinControls.UI.RadTextBoxControl();
            this.txtAnsw = new Telerik.WinControls.UI.RadTextBoxControl();
            this.txtAnswer = new Telerik.WinControls.UI.RadLabel();
            this.v = new Telerik.WinControls.UI.RadLabel();
            this.btnResetPassword = new Telerik.WinControls.UI.RadButton();
            this.lblError = new Telerik.WinControls.UI.RadLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnsw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnswer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnResetPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQuestion
            // 
            this.txtQuestion.IsReadOnly = true;
            this.txtQuestion.Location = new System.Drawing.Point(120, 47);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(286, 55);
            this.txtQuestion.TabIndex = 0;
            // 
            // txtAnsw
            // 
            this.txtAnsw.Location = new System.Drawing.Point(120, 136);
            this.txtAnsw.Name = "txtAnsw";
            this.txtAnsw.Size = new System.Drawing.Size(286, 55);
            this.txtAnsw.TabIndex = 1;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtAnswer.Location = new System.Drawing.Point(120, 115);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(46, 18);
            this.txtAnswer.TabIndex = 0;
            this.txtAnswer.Text = "Answer";
            // 
            // v
            // 
            this.v.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.v.Location = new System.Drawing.Point(120, 27);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(47, 18);
            this.v.TabIndex = 1;
            this.v.Text = "Qestion";
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Location = new System.Drawing.Point(120, 196);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(110, 36);
            this.btnResetPassword.TabIndex = 2;
            this.btnResetPassword.Text = "Reset Password";
            this.btnResetPassword.ThemeName = "TelerikMetroBlue";
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(120, 8);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(2, 2);
            this.lblError.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PersonalResultManagement.Properties.Resources.lock_2;
            this.pictureBox1.Location = new System.Drawing.Point(4, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(240, 200);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(111, 31);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back to login";
            this.btnBack.ThemeName = "TelerikMetro";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 247);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.v);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtAnsw);
            this.Controls.Add(this.txtQuestion);
            this.Name = "ResetPassword";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetPassword";
            this.ThemeName = "Windows8";
            this.Load += new System.EventHandler(this.ResetPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtQuestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnsw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnswer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnResetPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
        private Telerik.WinControls.UI.RadTextBoxControl txtQuestion;
        private Telerik.WinControls.UI.RadTextBoxControl txtAnsw;
        private Telerik.WinControls.UI.RadLabel txtAnswer;
        private Telerik.WinControls.UI.RadLabel v;
        private Telerik.WinControls.UI.RadButton btnResetPassword;
        private Telerik.WinControls.UI.RadLabel lblError;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadButton btnBack;
    }
}
