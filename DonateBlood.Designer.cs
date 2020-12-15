namespace Assignment2
{
    partial class DonateBlood
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
            this.lbltitle = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lblbg = new System.Windows.Forms.Label();
            this.lblbu = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.numericUpDownAge = new System.Windows.Forms.NumericUpDown();
            this.comboBoxBloodGroup = new System.Windows.Forms.ComboBox();
            this.textBoxBloodUnit = new System.Windows.Forms.TextBox();
            this.dateTimePickerDonateDate = new System.Windows.Forms.DateTimePicker();
            this.buttonRequestSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(275, 45);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(190, 31);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Donate Blood";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(171, 128);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(45, 16);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Name";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.Location = new System.Drawing.Point(171, 167);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(33, 16);
            this.lblage.TabIndex = 2;
            this.lblage.Text = "Age";
            // 
            // lblbg
            // 
            this.lblbg.AutoSize = true;
            this.lblbg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbg.Location = new System.Drawing.Point(171, 203);
            this.lblbg.Name = "lblbg";
            this.lblbg.Size = new System.Drawing.Size(84, 16);
            this.lblbg.TabIndex = 3;
            this.lblbg.Text = "Blood Group";
            // 
            // lblbu
            // 
            this.lblbu.AutoSize = true;
            this.lblbu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbu.Location = new System.Drawing.Point(171, 238);
            this.lblbu.Name = "lblbu";
            this.lblbu.Size = new System.Drawing.Size(77, 16);
            this.lblbu.TabIndex = 4;
            this.lblbu.Text = "Blood Units";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(171, 274);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(37, 16);
            this.lbldate.TabIndex = 5;
            this.lbldate.Text = "Date";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(281, 123);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(213, 20);
            this.textBoxName.TabIndex = 6;
            // 
            // numericUpDownAge
            // 
            this.numericUpDownAge.Location = new System.Drawing.Point(281, 162);
            this.numericUpDownAge.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownAge.Minimum = new decimal(new int[] {
            19,
            0,
            0,
            0});
            this.numericUpDownAge.Name = "numericUpDownAge";
            this.numericUpDownAge.Size = new System.Drawing.Size(39, 20);
            this.numericUpDownAge.TabIndex = 7;
            this.numericUpDownAge.Value = new decimal(new int[] {
            19,
            0,
            0,
            0});
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
            this.comboBoxBloodGroup.Location = new System.Drawing.Point(281, 197);
            this.comboBoxBloodGroup.Name = "comboBoxBloodGroup";
            this.comboBoxBloodGroup.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBloodGroup.TabIndex = 8;
            // 
            // textBoxBloodUnit
            // 
            this.textBoxBloodUnit.Location = new System.Drawing.Point(281, 234);
            this.textBoxBloodUnit.Name = "textBoxBloodUnit";
            this.textBoxBloodUnit.Size = new System.Drawing.Size(54, 20);
            this.textBoxBloodUnit.TabIndex = 9;
            // 
            // dateTimePickerDonateDate
            // 
            this.dateTimePickerDonateDate.Location = new System.Drawing.Point(281, 269);
            this.dateTimePickerDonateDate.Name = "dateTimePickerDonateDate";
            this.dateTimePickerDonateDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDonateDate.TabIndex = 10;
            // 
            // buttonRequestSubmit
            // 
            this.buttonRequestSubmit.Location = new System.Drawing.Point(281, 328);
            this.buttonRequestSubmit.Name = "buttonRequestSubmit";
            this.buttonRequestSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonRequestSubmit.TabIndex = 11;
            this.buttonRequestSubmit.Text = "Submit";
            this.buttonRequestSubmit.UseVisualStyleBackColor = true;
            this.buttonRequestSubmit.Click += new System.EventHandler(this.buttonRequestSubmit_Click);
            // 
            // DonateBlood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 386);
            this.Controls.Add(this.buttonRequestSubmit);
            this.Controls.Add(this.dateTimePickerDonateDate);
            this.Controls.Add(this.textBoxBloodUnit);
            this.Controls.Add(this.comboBoxBloodGroup);
            this.Controls.Add(this.numericUpDownAge);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lblbu);
            this.Controls.Add(this.lblbg);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lbltitle);
            this.Name = "DonateBlood";
            this.Text = "DonateBlood";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblbg;
        private System.Windows.Forms.Label lblbu;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.NumericUpDown numericUpDownAge;
        private System.Windows.Forms.ComboBox comboBoxBloodGroup;
        private System.Windows.Forms.TextBox textBoxBloodUnit;
        private System.Windows.Forms.DateTimePicker dateTimePickerDonateDate;
        private System.Windows.Forms.Button buttonRequestSubmit;
    }
}