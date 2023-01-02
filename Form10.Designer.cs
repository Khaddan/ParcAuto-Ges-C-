
namespace Ges_PARCAUTO
{
    partial class Form10
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
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.closebtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nMatriculeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fCarburantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fAutorouteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fDeplaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dejaRepaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freparationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fraisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aUTOPCDataSet3 = new Ges_PARCAUTO.AUTOPCDataSet3();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.fraisTableAdapter = new Ges_PARCAUTO.AUTOPCDataSet3TableAdapters.FraisTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fraisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTOPCDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 39);
            this.button3.TabIndex = 6;
            this.button3.Text = "<";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.closebtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1174, 100);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(359, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(339, 45);
            this.label6.TabIndex = 1;
            this.label6.Text = "Exportation Excel";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // closebtn
            // 
            this.closebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closebtn.FlatAppearance.BorderSize = 0;
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebtn.ForeColor = System.Drawing.Color.White;
            this.closebtn.Location = new System.Drawing.Point(1134, 0);
            this.closebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(40, 39);
            this.closebtn.TabIndex = 5;
            this.closebtn.Text = "X";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.matriVDataGridViewTextBoxColumn,
            this.nMatriculeDataGridViewTextBoxColumn,
            this.fCarburantDataGridViewTextBoxColumn,
            this.fAutorouteDataGridViewTextBoxColumn,
            this.fDeplaDataGridViewTextBoxColumn,
            this.dejaRepaDataGridViewTextBoxColumn,
            this.freparationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fraisBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1174, 319);
            this.dataGridView1.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // matriVDataGridViewTextBoxColumn
            // 
            this.matriVDataGridViewTextBoxColumn.DataPropertyName = "matriV";
            this.matriVDataGridViewTextBoxColumn.HeaderText = "matriV";
            this.matriVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.matriVDataGridViewTextBoxColumn.Name = "matriVDataGridViewTextBoxColumn";
            this.matriVDataGridViewTextBoxColumn.ReadOnly = true;
            this.matriVDataGridViewTextBoxColumn.Width = 125;
            // 
            // nMatriculeDataGridViewTextBoxColumn
            // 
            this.nMatriculeDataGridViewTextBoxColumn.DataPropertyName = "N_Matricule";
            this.nMatriculeDataGridViewTextBoxColumn.HeaderText = "N_Matricule";
            this.nMatriculeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nMatriculeDataGridViewTextBoxColumn.Name = "nMatriculeDataGridViewTextBoxColumn";
            this.nMatriculeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nMatriculeDataGridViewTextBoxColumn.Width = 125;
            // 
            // fCarburantDataGridViewTextBoxColumn
            // 
            this.fCarburantDataGridViewTextBoxColumn.DataPropertyName = "F_Carburant";
            this.fCarburantDataGridViewTextBoxColumn.HeaderText = "F_Carburant";
            this.fCarburantDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fCarburantDataGridViewTextBoxColumn.Name = "fCarburantDataGridViewTextBoxColumn";
            this.fCarburantDataGridViewTextBoxColumn.ReadOnly = true;
            this.fCarburantDataGridViewTextBoxColumn.Width = 125;
            // 
            // fAutorouteDataGridViewTextBoxColumn
            // 
            this.fAutorouteDataGridViewTextBoxColumn.DataPropertyName = "F_Autoroute";
            this.fAutorouteDataGridViewTextBoxColumn.HeaderText = "F_Autoroute";
            this.fAutorouteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fAutorouteDataGridViewTextBoxColumn.Name = "fAutorouteDataGridViewTextBoxColumn";
            this.fAutorouteDataGridViewTextBoxColumn.ReadOnly = true;
            this.fAutorouteDataGridViewTextBoxColumn.Width = 125;
            // 
            // fDeplaDataGridViewTextBoxColumn
            // 
            this.fDeplaDataGridViewTextBoxColumn.DataPropertyName = "F_Depla";
            this.fDeplaDataGridViewTextBoxColumn.HeaderText = "F_Depla";
            this.fDeplaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fDeplaDataGridViewTextBoxColumn.Name = "fDeplaDataGridViewTextBoxColumn";
            this.fDeplaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fDeplaDataGridViewTextBoxColumn.Width = 125;
            // 
            // dejaRepaDataGridViewTextBoxColumn
            // 
            this.dejaRepaDataGridViewTextBoxColumn.DataPropertyName = "Deja_Repa";
            this.dejaRepaDataGridViewTextBoxColumn.HeaderText = "Deja_Repa";
            this.dejaRepaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dejaRepaDataGridViewTextBoxColumn.Name = "dejaRepaDataGridViewTextBoxColumn";
            this.dejaRepaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dejaRepaDataGridViewTextBoxColumn.Width = 125;
            // 
            // freparationDataGridViewTextBoxColumn
            // 
            this.freparationDataGridViewTextBoxColumn.DataPropertyName = "F_reparation";
            this.freparationDataGridViewTextBoxColumn.HeaderText = "F_reparation";
            this.freparationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.freparationDataGridViewTextBoxColumn.Name = "freparationDataGridViewTextBoxColumn";
            this.freparationDataGridViewTextBoxColumn.ReadOnly = true;
            this.freparationDataGridViewTextBoxColumn.Width = 125;
            // 
            // fraisBindingSource
            // 
            this.fraisBindingSource.DataMember = "Frais";
            this.fraisBindingSource.DataSource = this.aUTOPCDataSet3;
            // 
            // aUTOPCDataSet3
            // 
            this.aUTOPCDataSet3.DataSetName = "AUTOPCDataSet3";
            this.aUTOPCDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button1.Location = new System.Drawing.Point(922, 492);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 42);
            this.button1.TabIndex = 38;
            this.button1.Text = "   Exporter ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Image = global::Ges_PARCAUTO.Properties.Resources.exc;
            this.pictureBox2.Location = new System.Drawing.Point(922, 493);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // fraisTableAdapter
            // 
            this.fraisTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(63, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "ID ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox1.Image = global::Ges_PARCAUTO.Properties.Resources.search_more;
            this.pictureBox1.Location = new System.Drawing.Point(233, 499);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(233, 499);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 42);
            this.button2.TabIndex = 42;
            this.button2.Text = "    Recherche";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 44;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 558);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fraisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTOPCDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private AUTOPCDataSet3 aUTOPCDataSet3;
        private System.Windows.Forms.BindingSource fraisBindingSource;
        private AUTOPCDataSet3TableAdapters.FraisTableAdapter fraisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nMatriculeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fCarburantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fAutorouteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fDeplaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dejaRepaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn freparationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}