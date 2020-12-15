namespace Assignment2
{
    partial class RequestBlood
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
            this.lblname = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRequestSubmit
            // 
            this.buttonRequestSubmit.Location = new System.Drawing.Point(248, 294);
            this.buttonRequestSubmit.Name = "buttonRequestSubmit";
            this.buttonRequestSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonRequestSubmit.TabIndex = 23;
            this.buttonRequestSubmit.Text = "Submit";
            this.buttonRequestSubmit.UseVisualStyleBackColor = true;
            this.buttonRequestSubmit.Click += new System.EventHandler(this.buttonRequestSubmit_Click);
            // 
            // dateTimePickerDonateDate
            // 
            this.dateTimePickerDonateDate.Location = new System.Drawing.Point(248, 235);
            this.dateTimePickerDonateDate.Name = "dateTimePickerDonateDate";
            this.dateTimePickerDonateDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDonateDate.TabIndex = 22;
            // 
            // textBoxBloodUnit
            // 
            this.textBoxBloodUnit.Location = new System.Drawing.Point(248, 200);
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
            this.comboBoxBloodGroup.Location = new System.Drawing.Point(248, 163);
            this.comboBoxBloodGroup.Name = "comboBoxBloodGroup";
            this.comboBoxBloodGroup.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBloodGroup.TabIndex = 20;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(248, 125);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(213, 20);
            this.textBoxName.TabIndex = 18;
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(138, 240);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(37, 16);
            this.lbldate.TabIndex = 17;
            this.lbldate.Text = "Date";
            // 
            // lblbu
            // 
            this.lblbu.AutoSize = true;
            this.lblbu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbu.Location = new System.Drawing.Point(138, 204);
            this.lblbu.Name = "lblbu";
            this.lblbu.Size = new System.Drawing.Size(77, 16);
            this.lblbu.TabIndex = 16;
            this.lblbu.Text = "Blood Units";
            // 
            // lblbg
            // 
            this.lblbg.AutoSize = true;
            this.lblbg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbg.Location = new System.Drawing.Point(138, 169);
            this.lblbg.Name = "lblbg";
            this.lblbg.Size = new System.Drawing.Size(84, 16);
            this.lblbg.TabIndex = 15;
            this.lblbg.Text = "Blood Group";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(138, 129);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(45, 16);
            this.lblname.TabIndex = 13;
            this.lblname.Text = "Name";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(242, 46);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(205, 31);
            this.lbltitle.TabIndex = 12;
            this.lbltitle.Text = "Request Blood";
            // 
            // RequestBlood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 396);
            this.Controls.Add(this.buttonRequestSubmit);
            this.Controls.Add(this.dateTimePickerDonateDate);
            this.Controls.Add(this.textBoxBloodUnit);
            this.Controls.Add(this.comboBoxBloodGroup);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lblbu);
            this.Controls.Add(this.lblbg);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lbltitle);
            this.Name = "RequestBlood";
            this.Text = "RequestBlood";
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
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbltitle;
    }
}