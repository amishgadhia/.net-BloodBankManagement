namespace Assignment2
{
    partial class Login
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
            this.lblheading = new System.Windows.Forms.Label();
            this.lblauthority = new System.Windows.Forms.Label();
            this.comboBoxauthorityChoice = new System.Windows.Forms.ComboBox();
            this.lbluname = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.textBoxUname = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblheading
            // 
            this.lblheading.AutoSize = true;
            this.lblheading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheading.Location = new System.Drawing.Point(44, 42);
            this.lblheading.Name = "lblheading";
            this.lblheading.Size = new System.Drawing.Size(489, 24);
            this.lblheading.TabIndex = 0;
            this.lblheading.Text = "Welcome to Online Blood Bank Managment System";
            // 
            // lblauthority
            // 
            this.lblauthority.AutoSize = true;
            this.lblauthority.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblauthority.Location = new System.Drawing.Point(100, 106);
            this.lblauthority.Name = "lblauthority";
            this.lblauthority.Size = new System.Drawing.Size(59, 16);
            this.lblauthority.TabIndex = 1;
            this.lblauthority.Text = "Authority";
            // 
            // comboBoxauthorityChoice
            // 
            this.comboBoxauthorityChoice.AllowDrop = true;
            this.comboBoxauthorityChoice.FormattingEnabled = true;
            this.comboBoxauthorityChoice.Items.AddRange(new object[] {
            "Donor",
            "Admin",
            "Acceptor"});
            this.comboBoxauthorityChoice.Location = new System.Drawing.Point(186, 106);
            this.comboBoxauthorityChoice.Name = "comboBoxauthorityChoice";
            this.comboBoxauthorityChoice.Size = new System.Drawing.Size(121, 21);
            this.comboBoxauthorityChoice.TabIndex = 2;
            // 
            // lbluname
            // 
            this.lbluname.AutoSize = true;
            this.lbluname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluname.Location = new System.Drawing.Point(100, 153);
            this.lbluname.Name = "lbluname";
            this.lbluname.Size = new System.Drawing.Size(77, 16);
            this.lbluname.TabIndex = 3;
            this.lbluname.Text = "User Name";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(100, 195);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(68, 16);
            this.lblpassword.TabIndex = 4;
            this.lblpassword.Text = "Password";
            // 
            // textBoxUname
            // 
            this.textBoxUname.Location = new System.Drawing.Point(186, 152);
            this.textBoxUname.Name = "textBoxUname";
            this.textBoxUname.Size = new System.Drawing.Size(182, 20);
            this.textBoxUname.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(186, 195);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(182, 20);
            this.textBoxPassword.TabIndex = 6;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(186, 251);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 7;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(293, 251);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 8;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 312);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUname);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lbluname);
            this.Controls.Add(this.comboBoxauthorityChoice);
            this.Controls.Add(this.lblauthority);
            this.Controls.Add(this.lblheading);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblheading;
        private System.Windows.Forms.Label lblauthority;
        private System.Windows.Forms.ComboBox comboBoxauthorityChoice;
        private System.Windows.Forms.Label lbluname;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox textBoxUname;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonReset;
    }
}

