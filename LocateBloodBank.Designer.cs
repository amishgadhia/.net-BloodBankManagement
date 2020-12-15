namespace Assignment2
{
    partial class LocateBloodBank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocateBloodBank));
            this.lblheading = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxStates = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblbloodbankname = new System.Windows.Forms.Label();
            this.lblmanagername = new System.Windows.Forms.Label();
            this.lblmonum = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.buttonshow = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // lblheading
            // 
            this.lblheading.AutoSize = true;
            this.lblheading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheading.Location = new System.Drawing.Point(194, 55);
            this.lblheading.Name = "lblheading";
            this.lblheading.Size = new System.Drawing.Size(341, 31);
            this.lblheading.TabIndex = 0;
            this.lblheading.Text = "Blood Bank In Your State";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select State";
            // 
            // comboBoxStates
            // 
            this.comboBoxStates.FormattingEnabled = true;
            this.comboBoxStates.Items.AddRange(new object[] {
            "Gujarat",
            "Maharashtra"});
            this.comboBoxStates.Location = new System.Drawing.Point(354, 119);
            this.comboBoxStates.Name = "comboBoxStates";
            this.comboBoxStates.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStates.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Details Of Blood Bank";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Blood Bank Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Manager Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(97, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mobile No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(97, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Address:";
            // 
            // lblbloodbankname
            // 
            this.lblbloodbankname.AutoSize = true;
            this.lblbloodbankname.Location = new System.Drawing.Point(224, 215);
            this.lblbloodbankname.Name = "lblbloodbankname";
            this.lblbloodbankname.Size = new System.Drawing.Size(34, 13);
            this.lblbloodbankname.TabIndex = 8;
            this.lblbloodbankname.Text = "        -";
            // 
            // lblmanagername
            // 
            this.lblmanagername.AutoSize = true;
            this.lblmanagername.Location = new System.Drawing.Point(208, 252);
            this.lblmanagername.Name = "lblmanagername";
            this.lblmanagername.Size = new System.Drawing.Size(34, 13);
            this.lblmanagername.TabIndex = 9;
            this.lblmanagername.Text = "        -";
            // 
            // lblmonum
            // 
            this.lblmonum.AutoSize = true;
            this.lblmonum.Location = new System.Drawing.Point(176, 287);
            this.lblmonum.Name = "lblmonum";
            this.lblmonum.Size = new System.Drawing.Size(34, 13);
            this.lblmonum.TabIndex = 10;
            this.lblmonum.Text = "        -";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Location = new System.Drawing.Point(165, 319);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(34, 13);
            this.lbladdress.TabIndex = 11;
            this.lbladdress.Text = "        -";
            // 
            // buttonshow
            // 
            this.buttonshow.Location = new System.Drawing.Point(507, 117);
            this.buttonshow.Name = "buttonshow";
            this.buttonshow.Size = new System.Drawing.Size(75, 23);
            this.buttonshow.TabIndex = 12;
            this.buttonshow.Text = "Show";
            this.buttonshow.UseVisualStyleBackColor = true;
            this.buttonshow.Click += new System.EventHandler(this.buttonshow_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(301, 362);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(75, 23);
            this.buttonPrint.TabIndex = 13;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDetails);
            // 
            // LocateBloodBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 397);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonshow);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lblmonum);
            this.Controls.Add(this.lblmanagername);
            this.Controls.Add(this.lblbloodbankname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxStates);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblheading);
            this.Name = "LocateBloodBank";
            this.Text = "LocateBloodBank";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblheading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxStates;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblbloodbankname;
        private System.Windows.Forms.Label lblmanagername;
        private System.Windows.Forms.Label lblmonum;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Button buttonshow;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}