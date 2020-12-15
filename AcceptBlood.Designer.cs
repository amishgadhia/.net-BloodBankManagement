namespace Assignment2
{
    partial class AcceptBlood
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
            this.buttonRequestSubmit = new System.Windows.Forms.Button();
            this.dateTimePickerDonateDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxBloodUnit = new System.Windows.Forms.TextBox();
            this.comboBoxBloodGroup = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblbu = new System.Windows.Forms.Label();
            this.lblbg = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonfemale = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // buttonRequestSubmit
            // 
            this.buttonRequestSubmit.Location = new System.Drawing.Point(250, 340);
            this.buttonRequestSubmit.Name = "buttonRequestSubmit";
            this.buttonRequestSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonRequestSubmit.TabIndex = 23;
            this.buttonRequestSubmit.Text = "Submit";
            this.buttonRequestSubmit.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDonateDate
            // 
            this.dateTimePickerDonateDate.Location = new System.Drawing.Point(250, 281);
            this.dateTimePickerDonateDate.Name = "dateTimePickerDonateDate";
            this.dateTimePickerDonateDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDonateDate.TabIndex = 22;
            // 
            // textBoxBloodUnit
            // 
            this.textBoxBloodUnit.Location = new System.Drawing.Point(250, 246);
            this.textBoxBloodUnit.Name = "textBoxBloodUnit";
            this.textBoxBloodUnit.Size = new System.Drawing.Size(54, 20);
            this.textBoxBloodUnit.TabIndex = 21;
            // 
            // comboBoxBloodGroup
            // 
            this.comboBoxBloodGroup.FormattingEnabled = true;
            this.comboBoxBloodGroup.Items.AddRange(new object[] {
            "O+",
            "O-",
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-"});
            this.comboBoxBloodGroup.Location = new System.Drawing.Point(250, 209);
            this.comboBoxBloodGroup.Name = "comboBoxBloodGroup";
            this.comboBoxBloodGroup.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBloodGroup.TabIndex = 20;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(250, 135);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(213, 20);
            this.textBoxName.TabIndex = 18;
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(140, 286);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(37, 16);
            this.lbldate.TabIndex = 17;
            this.lbldate.Text = "Date";
            // 
            // lblbu
            // 
            this.lblbu.AutoSize = true;
            this.lblbu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbu.Location = new System.Drawing.Point(140, 250);
            this.lblbu.Name = "lblbu";
            this.lblbu.Size = new System.Drawing.Size(77, 16);
            this.lblbu.TabIndex = 16;
            this.lblbu.Text = "Blood Units";
            // 
            // lblbg
            // 
            this.lblbg.AutoSize = true;
            this.lblbg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbg.Location = new System.Drawing.Point(140, 215);
            this.lblbg.Name = "lblbg";
            this.lblbg.Size = new System.Drawing.Size(84, 16);
            this.lblbg.TabIndex = 15;
            this.lblbg.Text = "Blood Group";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(140, 179);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(33, 16);
            this.lblgender.TabIndex = 14;
            this.lblgender.Text = "Age";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(140, 140);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(45, 16);
            this.lblname.TabIndex = 13;
            this.lblname.Text = "Name";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(244, 57);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(355, 31);
            this.lbltitle.TabIndex = 12;
            this.lbltitle.Text = "Request For Accept Blood";
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Checked = true;
            this.radioButtonMale.Location = new System.Drawing.Point(250, 177);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(48, 17);
            this.radioButtonMale.TabIndex = 24;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonfemale
            // 
            this.radioButtonfemale.AutoSize = true;
            this.radioButtonfemale.Location = new System.Drawing.Point(304, 178);
            this.radioButtonfemale.Name = "radioButtonfemale";
            this.radioButtonfemale.Size = new System.Drawing.Size(59, 17);
            this.radioButtonfemale.TabIndex = 25;
            this.radioButtonfemale.Text = "Female";
            this.radioButtonfemale.UseVisualStyleBackColor = true;
            // 
            // AcceptBlood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 420);
            this.Controls.Add(this.radioButtonfemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.buttonRequestSubmit);
            this.Controls.Add(this.dateTimePickerDonateDate);
            this.Controls.Add(this.textBoxBloodUnit);
            this.Controls.Add(this.comboBoxBloodGroup);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lblbu);
            this.Controls.Add(this.lblbg);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lbltitle);
            this.Name = "AcceptBlood";
            this.Text = "AcceptBlood";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRequestSubmit;
        private System.Windows.Forms.DateTimePicker dateTimePickerDonateDate;
        private System.Windows.Forms.TextBox textBoxBloodUnit;
        private System.Windows.Forms.ComboBox comboBoxBloodGroup;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblbu;
        private System.Windows.Forms.Label lblbg;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonfemale;
    }
}