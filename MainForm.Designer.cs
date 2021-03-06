
namespace GanjoorTranslationTagger
{
    partial class MainForm
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
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.lblLoginStatus = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnSelectCategory = new System.Windows.Forms.Button();
            this.lblSelectedCat = new System.Windows.Forms.Label();
            this.grpCat = new System.Windows.Forms.GroupBox();
            this.grpLanguage = new System.Windows.Forms.GroupBox();
            this.btnLanguages = new System.Windows.Forms.Button();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.btnStartTranslating = new System.Windows.Forms.Button();
            this.prgrss = new System.Windows.Forms.ProgressBar();
            this.grpLogin.SuspendLayout();
            this.grpCat.SuspendLayout();
            this.grpLanguage.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLogin
            // 
            this.grpLogin.Controls.Add(this.lblLoginStatus);
            this.grpLogin.Controls.Add(this.lblEmail);
            this.grpLogin.Controls.Add(this.btnLogin);
            this.grpLogin.Controls.Add(this.txtEmail);
            this.grpLogin.Controls.Add(this.txtPassword);
            this.grpLogin.Controls.Add(this.lblPassword);
            this.grpLogin.Location = new System.Drawing.Point(27, 27);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpLogin.Size = new System.Drawing.Size(500, 215);
            this.grpLogin.TabIndex = 11;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "ورود";
            // 
            // lblLoginStatus
            // 
            this.lblLoginStatus.AutoSize = true;
            this.lblLoginStatus.Location = new System.Drawing.Point(272, 166);
            this.lblLoginStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginStatus.Name = "lblLoginStatus";
            this.lblLoginStatus.Size = new System.Drawing.Size(174, 19);
            this.lblLoginStatus.TabIndex = 10;
            this.lblLoginStatus.Text = "لطفاً وارد سیستم شوید.";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(317, 37);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(129, 19);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "پست الکترونیکی:";
            // 
            // btnLogin
            // 
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLogin.Location = new System.Drawing.Point(197, 119);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(112, 34);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "ورود";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(23, 37);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmail.Size = new System.Drawing.Size(286, 27);
            this.txtEmail.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(23, 75);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassword.Size = new System.Drawing.Size(286, 27);
            this.txtPassword.TabIndex = 8;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(383, 78);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(63, 19);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "گذرواژه:";
            // 
            // btnSelectCategory
            // 
            this.btnSelectCategory.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSelectCategory.Location = new System.Drawing.Point(31, 32);
            this.btnSelectCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectCategory.Name = "btnSelectCategory";
            this.btnSelectCategory.Size = new System.Drawing.Size(500, 36);
            this.btnSelectCategory.TabIndex = 12;
            this.btnSelectCategory.Text = "انتخاب بخش";
            this.btnSelectCategory.UseVisualStyleBackColor = true;
            this.btnSelectCategory.Click += new System.EventHandler(this.btnSelectCategory_Click);
            // 
            // lblSelectedCat
            // 
            this.lblSelectedCat.AutoSize = true;
            this.lblSelectedCat.Location = new System.Drawing.Point(393, 80);
            this.lblSelectedCat.Name = "lblSelectedCat";
            this.lblSelectedCat.Size = new System.Drawing.Size(131, 19);
            this.lblSelectedCat.TabIndex = 13;
            this.lblSelectedCat.Text = "بخش انتخاب شده";
            // 
            // grpCat
            // 
            this.grpCat.Controls.Add(this.btnSelectCategory);
            this.grpCat.Controls.Add(this.lblSelectedCat);
            this.grpCat.Location = new System.Drawing.Point(546, 37);
            this.grpCat.Name = "grpCat";
            this.grpCat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpCat.Size = new System.Drawing.Size(554, 113);
            this.grpCat.TabIndex = 14;
            this.grpCat.TabStop = false;
            this.grpCat.Text = "بخش مد نظر از گنجور";
            // 
            // grpLanguage
            // 
            this.grpLanguage.Controls.Add(this.btnLanguages);
            this.grpLanguage.Controls.Add(this.cmbLanguage);
            this.grpLanguage.Location = new System.Drawing.Point(546, 156);
            this.grpLanguage.Name = "grpLanguage";
            this.grpLanguage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpLanguage.Size = new System.Drawing.Size(554, 86);
            this.grpLanguage.TabIndex = 15;
            this.grpLanguage.TabStop = false;
            this.grpLanguage.Text = "زبان یا نویسش";
            // 
            // btnLanguages
            // 
            this.btnLanguages.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLanguages.Location = new System.Drawing.Point(19, 36);
            this.btnLanguages.Margin = new System.Windows.Forms.Padding(4);
            this.btnLanguages.Name = "btnLanguages";
            this.btnLanguages.Size = new System.Drawing.Size(112, 35);
            this.btnLanguages.TabIndex = 17;
            this.btnLanguages.Text = "تعریف";
            this.btnLanguages.UseVisualStyleBackColor = true;
            this.btnLanguages.Click += new System.EventHandler(this.btnLanguages_Click);
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(138, 37);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(393, 27);
            this.cmbLanguage.TabIndex = 16;
            // 
            // btnStartTranslating
            // 
            this.btnStartTranslating.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnStartTranslating.Location = new System.Drawing.Point(32, 263);
            this.btnStartTranslating.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartTranslating.Name = "btnStartTranslating";
            this.btnStartTranslating.Size = new System.Drawing.Size(252, 35);
            this.btnStartTranslating.TabIndex = 18;
            this.btnStartTranslating.Text = "شروع";
            this.btnStartTranslating.UseVisualStyleBackColor = true;
            this.btnStartTranslating.Click += new System.EventHandler(this.btnStartTranslating_Click);
            // 
            // prgrss
            // 
            this.prgrss.Location = new System.Drawing.Point(302, 263);
            this.prgrss.Name = "prgrss";
            this.prgrss.Size = new System.Drawing.Size(798, 35);
            this.prgrss.TabIndex = 19;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1112, 325);
            this.Controls.Add(this.prgrss);
            this.Controls.Add(this.btnStartTranslating);
            this.Controls.Add(this.grpLanguage);
            this.Controls.Add(this.grpCat);
            this.Controls.Add(this.grpLogin);
            this.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "نویسشگر ماشینی گنجور";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.grpCat.ResumeLayout(false);
            this.grpCat.PerformLayout();
            this.grpLanguage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnSelectCategory;
        private System.Windows.Forms.Label lblSelectedCat;
        private System.Windows.Forms.Label lblLoginStatus;
        private System.Windows.Forms.GroupBox grpCat;
        private System.Windows.Forms.GroupBox grpLanguage;
        private System.Windows.Forms.Button btnLanguages;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.Button btnStartTranslating;
        private System.Windows.Forms.ProgressBar prgrss;
    }
}

