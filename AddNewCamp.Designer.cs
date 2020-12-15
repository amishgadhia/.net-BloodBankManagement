namespace Assignment2
{
    partial class AddNewCamp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCampName = new System.Windows.Forms.TextBox();
            this.dateTimePickerCampDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCampState = new System.Windows.Forms.ComboBox();
            this.textBoxCampAddress = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblheading
            // 
            this.lblheading.AutoSize = true;
            this.lblheading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheading.Location = new System.Drawing.Point(250, 55);
            this.lblheading.Name = "lblheading";
            this.lblheading.Size = new System.Drawing.Size(246, 31);
            this.lblheading.TabIndex = 0;
            this.lblheading.Text = "Blood Bank Camp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter details of new blood bank camp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Camp Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(140, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "State";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(140, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Address";
            // 
            // textBoxCampName
            // 
            this.textBoxCampName.Location = new System.Drawing.Point(245, 169);
            this.textBoxCampName.Name = "textBoxCampName";
            this.textBoxCampName.Size = new System.Drawing.Size(188, 20);
            this.textBoxCampName.TabIndex = 6;
            // 
            // dateTimePickerCampDate
            // 
            this.dateTimePickerCampDate.Location = new System.Drawing.Point(245, 204);
            this.dateTimePickerCampDate.Name = "dateTimePickerCampDate";
            this.dateTimePickerCampDate.Size = new System.Drawing.Size(188, 20);
            this.dateTimePickerCampDate.TabIndex = 7;
            // 
            // comboBoxCampState
            // 
            this.comboBoxCampState.FormattingEnabled = true;
            this.comboBoxCampState.Items.AddRange(new object[] {
            "Gujarat",
            "Maharashtra",
            "Goa",
            "Rajasthan",
            "Madhya Pradesh"});
            this.comboBoxCampState.Location = new System.Drawing.Point(245, 235);
            this.comboBoxCampState.Name = "comboBoxCampState";
            this.comboBoxCampState.Size = new System.Drawing.Size(110, 21);
            this.comboBoxCampState.TabIndex = 8;
            // 
            // textBoxCampAddress
            // 
            this.textBoxCampAddress.Location = new System.Drawing.Point(245, 269);
            this.textBoxCampAddress.Multiline = true;
            this.textBoxCampAddress.Name = "textBoxCampAddress";
            this.textBoxCampAddress.Size = new System.Drawing.Size(251, 62);
            this.textBoxCampAddress.TabIndex = 9;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(245, 360);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 10;
            this.buttonSubmit.Text = "Add Camp";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // AddNewCamp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 418);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxCampAddress);
            this.Controls.Add(this.comboBoxCampState);
            this.Controls.Add(this.dateTimePickerCampDate);
            this.Controls.Add(this.textBoxCampName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblheading);
            this.Name = "AddNewCamp";
            this.Text = "AddNewCamp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblheading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCampName;
        private System.Windows.Forms.DateTimePicker dateTimePickerCampDate;
        private System.Windows.Forms.ComboBox comboBoxCampState;
        private System.Windows.Forms.TextBox textBoxCampAddress;
        private System.Windows.Forms.Button buttonSubmit;
    }
}