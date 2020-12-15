namespace Assignment2
{
    partial class AddNewDonor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewDonor));
            this.submitbutton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.Browse = new System.Windows.Forms.LinkLabel();
            this.Donorpic = new System.Windows.Forms.PictureBox();
            this.address = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.TextBox();
            this.firstname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxBloodGrup = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblPass = new System.Windows.Forms.Label();
            this.TextBoxPass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Donorpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.age)).BeginInit();
            this.SuspendLayout();
            // 
            // submitbutton
            // 
            this.submitbutton.Location = new System.Drawing.Point(215, 388);
            this.submitbutton.Name = "submitbutton";
            this.submitbutton.Size = new System.Drawing.Size(75, 23);
            this.submitbutton.TabIndex = 50;
            this.submitbutton.Text = "Submit";
            this.submitbutton.UseVisualStyleBackColor = true;
            this.submitbutton.Click += new System.EventHandler(this.submitbutton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(142, 353);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(278, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "Clicking on this you are agreeing our terms and conditions";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(121, 353);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 48;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // Browse
            // 
            this.Browse.AutoSize = true;
            this.Browse.Location = new System.Drawing.Point(541, 170);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(42, 13);
            this.Browse.TabIndex = 47;
            this.Browse.TabStop = true;
            this.Browse.Text = "Browse";
            this.Browse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Browse_LinkClicked);
            // 
            // Donorpic
            // 
            this.Donorpic.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Donorpic.ErrorImage")));
            this.Donorpic.Image = ((System.Drawing.Image)(resources.GetObject("Donorpic.Image")));
            this.Donorpic.InitialImage = ((System.Drawing.Image)(resources.GetObject("Donorpic.InitialImage")));
            this.Donorpic.Location = new System.Drawing.Point(516, 56);
            this.Donorpic.Name = "Donorpic";
            this.Donorpic.Size = new System.Drawing.Size(100, 99);
            this.Donorpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Donorpic.TabIndex = 46;
            this.Donorpic.TabStop = false;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(216, 282);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(200, 57);
            this.address.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(118, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 15);
            this.label9.TabIndex = 44;
            this.label9.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(118, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 15);
            this.label8.TabIndex = 40;
            this.label8.Text = "Blood Group";
            // 
            // country
            // 
            this.country.FormattingEnabled = true;
            this.country.Items.AddRange(new object[] {
            "India",
            "Usa",
            "Africa",
            "Canada"});
            this.country.Location = new System.Drawing.Point(215, 219);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(121, 21);
            this.country.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(118, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 36;
            this.label6.Text = "Country";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(269, 190);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 17);
            this.radioButton2.TabIndex = 35;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(215, 190);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 17);
            this.radioButton1.TabIndex = 34;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(118, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 33;
            this.label5.Text = "Gender";
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(215, 160);
            this.age.Maximum = new decimal(new int[] {
            65,
            0,
            0,
            0});
            this.age.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(34, 20);
            this.age.TabIndex = 32;
            this.age.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 31;
            this.label4.Text = "Age";
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(215, 89);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(141, 20);
            this.lastname.TabIndex = 30;
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(215, 55);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(141, 20);
            this.firstname.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "Lastname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Firstname";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Donor Details";
            // 
            // comboBoxBloodGrup
            // 
            this.comboBoxBloodGrup.FormattingEnabled = true;
            this.comboBoxBloodGrup.Items.AddRange(new object[] {
            "O+",
            "O-",
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-"});
            this.comboBoxBloodGrup.Location = new System.Drawing.Point(215, 253);
            this.comboBoxBloodGrup.Name = "comboBoxBloodGrup";
            this.comboBoxBloodGrup.Size = new System.Drawing.Size(75, 21);
            this.comboBoxBloodGrup.TabIndex = 52;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(119, 126);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(69, 15);
            this.lblPass.TabIndex = 53;
            this.lblPass.Text = "Password";
            // 
            // TextBoxPass
            // 
            this.TextBoxPass.Location = new System.Drawing.Point(216, 125);
            this.TextBoxPass.Name = "TextBoxPass";
            this.TextBoxPass.PasswordChar = '*';
            this.TextBoxPass.Size = new System.Drawing.Size(141, 20);
            this.TextBoxPass.TabIndex = 54;
            // 
            // AddNewDonor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 450);
            this.Controls.Add(this.TextBoxPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.comboBoxBloodGrup);
            this.Controls.Add(this.submitbutton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.Donorpic);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.country);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.age);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNewDonor";
            this.Text = "AddNewDonor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Donorpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.age)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button submitbutton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.LinkLabel Browse;
        private System.Windows.Forms.PictureBox Donorpic;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox country;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown age;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxBloodGrup;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox TextBoxPass;
    }
}