
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
            this.btnBackup = new System.Windows.Forms.Button();
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
            this.grpLogin.Location = new System.Drawing.Point(36, 36);
            this.grpLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpLogin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpLogin.Size = new System.Drawing.Size(667, 287);
            this.grpLogin.TabIndex = 11;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "ورود";
            // 
            // lblLoginStatus
            // 
            this.lblLoginStatus.AutoSize = true;
            this.lblLoginStatus.Location = new System.Drawing.Point(363, 221);
            this.lblLoginStatus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLoginStatus.Name = "lblLoginStatus";
            this.lblLoginStatus.Size = new System.Drawing.Size(237, 27);
            this.lblLoginStatus.TabIndex = 10;
            this.lblLoginStatus.Text = "لطفاً وارد سیستم شوید.";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(423, 49);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(174, 27);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "پست الکترونیکی:";
            // 
            // btnLogin
            // 
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLogin.Location = new System.Drawing.Point(263, 159);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(149, 45);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "ورود";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(31, 49);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmail.Size = new System.Drawing.Size(380, 33);
            this.txtEmail.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(31, 100);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassword.Size = new System.Drawing.Size(380, 33);
            this.txtPassword.TabIndex = 8;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(511, 104);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(83, 27);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "گذرواژه:";
            // 
            // btnSelectCategory
            // 
            this.btnSelectCategory.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSelectCategory.Location = new System.Drawing.Point(41, 43);
            this.btnSelectCategory.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSelectCategory.Name = "btnSelectCategory";
            this.btnSelectCategory.Size = new System.Drawing.Size(667, 48);
            this.btnSelectCategory.TabIndex = 12;
            this.btnSelectCategory.Text = "انتخاب بخش";
            this.btnSelectCategory.UseVisualStyleBackColor = true;
            this.btnSelectCategory.Click += new System.EventHandler(this.btnSelectCategory_Click);
            // 
            // lblSelectedCat
            // 
            this.lblSelectedCat.AutoSize = true;
            this.lblSelectedCat.Location = new System.Drawing.Point(524, 107);
            this.lblSelectedCat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedCat.Name = "lblSelectedCat";
            this.lblSelectedCat.Size = new System.Drawing.Size(178, 27);
            this.lblSelectedCat.TabIndex = 13;
            this.lblSelectedCat.Text = "بخش انتخاب شده";
            // 
            // grpCat
            // 
            this.grpCat.Controls.Add(this.btnSelectCategory);
            this.grpCat.Controls.Add(this.lblSelectedCat);
            this.grpCat.Location = new System.Drawing.Point(728, 49);
            this.grpCat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpCat.Name = "grpCat";
            this.grpCat.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpCat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpCat.Size = new System.Drawing.Size(739, 151);
            this.grpCat.TabIndex = 14;
            this.grpCat.TabStop = false;
            this.grpCat.Text = "بخش مد نظر از گنجور";
            // 
            // grpLanguage
            // 
            this.grpLanguage.Controls.Add(this.btnLanguages);
            this.grpLanguage.Controls.Add(this.cmbLanguage);
            this.grpLanguage.Location = new System.Drawing.Point(728, 208);
            this.grpLanguage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpLanguage.Name = "grpLanguage";
            this.grpLanguage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpLanguage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpLanguage.Size = new System.Drawing.Size(739, 115);
            this.grpLanguage.TabIndex = 15;
            this.grpLanguage.TabStop = false;
            this.grpLanguage.Text = "زبان یا نویسش";
            // 
            // btnLanguages
            // 
            this.btnLanguages.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLanguages.Location = new System.Drawing.Point(25, 48);
            this.btnLanguages.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnLanguages.Name = "btnLanguages";
            this.btnLanguages.Size = new System.Drawing.Size(149, 47);
            this.btnLanguages.TabIndex = 17;
            this.btnLanguages.Text = "تعریف";
            this.btnLanguages.UseVisualStyleBackColor = true;
            this.btnLanguages.Click += new System.EventHandler(this.btnLanguages_Click);
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(184, 49);
            this.cmbLanguage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(523, 33);
            this.cmbLanguage.TabIndex = 16;
            // 
            // btnStartTranslating
            // 
            this.btnStartTranslating.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnStartTranslating.Location = new System.Drawing.Point(43, 351);
            this.btnStartTranslating.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnStartTranslating.Name = "btnStartTranslating";
            this.btnStartTranslating.Size = new System.Drawing.Size(336, 47);
            this.btnStartTranslating.TabIndex = 18;
            this.btnStartTranslating.Text = "شروع";
            this.btnStartTranslating.UseVisualStyleBackColor = true;
            this.btnStartTranslating.Click += new System.EventHandler(this.btnStartTranslating_Click);
            // 
            // prgrss
            // 
            this.prgrss.Location = new System.Drawing.Point(403, 351);
            this.prgrss.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prgrss.Name = "prgrss";
            this.prgrss.Size = new System.Drawing.Size(1064, 47);
            this.prgrss.TabIndex = 19;
            // 
            // btnBackup
            // 
            this.btnBackup.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBackup.Location = new System.Drawing.Point(43, 422);
            this.btnBackup.Margin = new System.Windows.Forms.Padding(5);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(336, 47);
            this.btnBackup.TabIndex = 20;
            this.btnBackup.Text = "پشتیبان‌گیری";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1483, 505);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.prgrss);
            this.Controls.Add(this.btnStartTranslating);
            this.Controls.Add(this.grpLanguage);
            this.Controls.Add(this.grpCat);
            this.Controls.Add(this.grpLogin);
            this.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button btnBackup;
    }
}

