namespace PersonalResultManagement.UI.User
{
    partial class ChangeSecurity
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
            this.lblError = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtPassword = new Telerik.WinControls.UI.RadTextBox();
            this.btnChangeSecurity = new Telerik.WinControls.UI.RadButton();
            this.v = new Telerik.WinControls.UI.RadLabel();
            this.txtAnswer = new Telerik.WinControls.UI.RadLabel();
            this.txtAnsw = new Telerik.WinControls.UI.RadTextBoxControl();
            this.txtQuestion = new Telerik.WinControls.UI.RadTextBoxControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lblError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChangeSecurity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnswer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnsw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(135, 13);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(2, 2);
            this.lblError.TabIndex = 0;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(139, 42);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(53, 18);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPassword.Location = new System.Drawing.Point(141, 61);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(286, 25);
            this.txtPassword.TabIndex = 2;
            // 
            // btnChangeSecurity
            // 
            this.btnChangeSecurity.Location = new System.Drawing.Point(139, 253);
            this.btnChangeSecurity.Name = "btnChangeSecurity";
            this.btnChangeSecurity.Size = new System.Drawing.Size(110, 36);
            this.btnChangeSecurity.TabIndex = 7;
            this.btnChangeSecurity.Text = "Change Security";
            this.btnChangeSecurity.ThemeName = "TelerikMetroBlue";
            this.btnChangeSecurity.Click += new System.EventHandler(this.btnChangeSecurity_Click);
            // 
            // v
            // 
            this.v.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.v.Location = new System.Drawing.Point(141, 92);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(47, 18);
            this.v.TabIndex = 5;
            this.v.Text = "Qestion";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtAnswer.Location = new System.Drawing.Point(139, 172);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(46, 18);
            this.txtAnswer.TabIndex = 3;
            this.txtAnswer.Text = "Answer";
            // 
            // txtAnsw
            // 
            this.txtAnsw.Location = new System.Drawing.Point(139, 193);
            this.txtAnsw.Name = "txtAnsw";
            this.txtAnsw.Size = new System.Drawing.Size(286, 55);
            this.txtAnsw.TabIndex = 6;
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(141, 112);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(286, 55);
            this.txtQuestion.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PersonalResultManagement.Properties.Resources.forgot_password;
            this.pictureBox1.Location = new System.Drawing.Point(6, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // ChangeSecurity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 300);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnChangeSecurity);
            this.Controls.Add(this.v);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtAnsw);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.lblError);
            this.Name = "ChangeSecurity";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change Security";
            this.ThemeName = "Windows8";
            ((System.ComponentModel.ISupportInitialize)(this.lblError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChangeSecurity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnswer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnsw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
        private Telerik.WinControls.UI.RadLabel lblError;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txtPassword;
        private Telerik.WinControls.UI.RadButton btnChangeSecurity;
        private Telerik.WinControls.UI.RadLabel v;
        private Telerik.WinControls.UI.RadLabel txtAnswer;
        private Telerik.WinControls.UI.RadTextBoxControl txtAnsw;
        private Telerik.WinControls.UI.RadTextBoxControl txtQuestion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
