namespace seminar9
{
    partial class Form1
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
            this.dataSet1 = new System.Data.DataSet();
            this.dataSet2 = new System.Data.DataSet();
            this.dataSet3 = new System.Data.DataSet();
            this.dataSet4 = new System.Data.DataSet();
            this.dataSet5 = new System.Data.DataSet();
            this.dataSet6 = new System.Data.DataSet();
            this.dataSet7 = new System.Data.DataSet();
            this.dataSet8 = new System.Data.DataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numeprenume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataNasterii = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnAbsolvire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specializare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "NewDataSet";
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "NewDataSet";
            // 
            // dataSet4
            // 
            this.dataSet4.DataSetName = "NewDataSet";
            // 
            // dataSet5
            // 
            this.dataSet5.DataSetName = "NewDataSet";
            // 
            // dataSet6
            // 
            this.dataSet6.DataSetName = "NewDataSet";
            // 
            // dataSet7
            // 
            this.dataSet7.DataSetName = "NewDataSet";
            // 
            // dataSet8
            // 
            this.dataSet8.DataSetName = "NewDataSet";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Numeprenume,
            this.DataNasterii,
            this.CNP,
            this.AnAbsolvire,
            this.Specializare});
            this.dataGridView1.Location = new System.Drawing.Point(257, 266);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(963, 432);
            this.dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.Width = 150;
            // 
            // Numeprenume
            // 
            this.Numeprenume.HeaderText = "NumePrenume";
            this.Numeprenume.MinimumWidth = 8;
            this.Numeprenume.Name = "Numeprenume";
            this.Numeprenume.Width = 150;
            // 
            // DataNasterii
            // 
            this.DataNasterii.HeaderText = "DataNasterii";
            this.DataNasterii.MinimumWidth = 8;
            this.DataNasterii.Name = "DataNasterii";
            this.DataNasterii.Width = 150;
            // 
            // CNP
            // 
            this.CNP.HeaderText = "CNP";
            this.CNP.MinimumWidth = 8;
            this.CNP.Name = "CNP";
            this.CNP.Width = 150;
            // 
            // AnAbsolvire
            // 
            this.AnAbsolvire.HeaderText = "AnAbsolvire";
            this.AnAbsolvire.MinimumWidth = 8;
            this.AnAbsolvire.Name = "AnAbsolvire";
            this.AnAbsolvire.Width = 150;
            // 
            // Specializare
            // 
            this.Specializare.HeaderText = "Specializare";
            this.Specializare.MinimumWidth = 8;
            this.Specializare.Name = "Specializare";
            this.Specializare.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 773);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salveaza";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 1028);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dataSet1;
        private System.Data.DataSet dataSet2;
        private System.Data.DataSet dataSet3;
        private System.Data.DataSet dataSet4;
        private System.Data.DataSet dataSet5;
        private System.Data.DataSet dataSet6;
        private System.Data.DataSet dataSet7;
        private System.Data.DataSet dataSet8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numeprenume;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataNasterii;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNP;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnAbsolvire;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specializare;
        private System.Windows.Forms.Button button1;
    }
}

