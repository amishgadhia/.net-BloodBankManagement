namespace Assignment2
{
    partial class ViewAllDonor
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewDonor = new System.Windows.Forms.DataGridView();
            this.database1DataSet = new Assignment2.Database1DataSet();
            this.bloodDonatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bloodDonatorTableAdapter = new Assignment2.Database1DataSetTableAdapters.BloodDonatorTableAdapter();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new Assignment2.Database1DataSet1();
            this.bloodDonatorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bloodDonatorTableAdapter1 = new Assignment2.Database1DataSet1TableAdapters.BloodDonatorTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDonor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodDonatorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodDonatorBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDonor
            // 
            this.dataGridViewDonor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDonor.Location = new System.Drawing.Point(123, 127);
            this.dataGridViewDonor.Name = "dataGridViewDonor";
            this.dataGridViewDonor.Size = new System.Drawing.Size(498, 245);
            this.dataGridViewDonor.TabIndex = 0;
            this.dataGridViewDonor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDonor_CellContentClick);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bloodDonatorBindingSource
            // 
            this.bloodDonatorBindingSource.DataMember = "BloodDonator";
            this.bloodDonatorBindingSource.DataSource = this.database1DataSet;
            // 
            // bloodDonatorTableAdapter
            // 
            this.bloodDonatorTableAdapter.ClearBeforeFill = true;
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bloodDonatorBindingSource1
            // 
            this.bloodDonatorBindingSource1.DataMember = "BloodDonator";
            this.bloodDonatorBindingSource1.DataSource = this.database1DataSet1;
            // 
            // bloodDonatorTableAdapter1
            // 
            this.bloodDonatorTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Details Of All Donors";
            // 
            // ViewAllDonor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 406);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewDonor);
            this.Name = "ViewAllDonor";
            this.Text = "ViewAllDonor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ViewAllDonor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDonor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodDonatorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodDonatorBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDonor;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource bloodDonatorBindingSource;
        private Database1DataSetTableAdapters.BloodDonatorTableAdapter bloodDonatorTableAdapter;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource bloodDonatorBindingSource1;
        private Database1DataSet1TableAdapters.BloodDonatorTableAdapter bloodDonatorTableAdapter1;
        private System.Windows.Forms.Label label1;
    }
}