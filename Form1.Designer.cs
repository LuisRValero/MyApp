namespace MyApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            butGuardar = new Button();
            butCargar = new Button();
            dgvRegistros = new DataGridView();
            ofd1 = new OpenFileDialog();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewImageColumn();
            Column5 = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(butGuardar);
            splitContainer1.Panel1.Controls.Add(butCargar);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint_1;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvRegistros);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(917, 555);
            splitContainer1.SplitterDistance = 182;
            splitContainer1.TabIndex = 0;
            // 
            // butGuardar
            // 
            butGuardar.Location = new Point(394, 65);
            butGuardar.Name = "butGuardar";
            butGuardar.Size = new Size(94, 29);
            butGuardar.TabIndex = 1;
            butGuardar.Text = "Guardar";
            butGuardar.UseVisualStyleBackColor = true;
            butGuardar.Click += butGuardar_Click;
            // 
            // butCargar
            // 
            butCargar.Location = new Point(53, 65);
            butCargar.Name = "butCargar";
            butCargar.Size = new Size(139, 29);
            butCargar.TabIndex = 0;
            butCargar.Text = "Cargar";
            butCargar.UseVisualStyleBackColor = true;
            butCargar.Click += butCargar_Click;
            // 
            // dgvRegistros
            // 
            dgvRegistros.AllowUserToAddRows = false;
            dgvRegistros.AllowUserToDeleteRows = false;
            dgvRegistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistros.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvRegistros.Dock = DockStyle.Fill;
            dgvRegistros.Location = new Point(0, 0);
            dgvRegistros.Name = "dgvRegistros";
            dgvRegistros.ReadOnly = true;
            dgvRegistros.RowHeadersWidth = 51;
            dgvRegistros.Size = new Size(917, 369);
            dgvRegistros.TabIndex = 0;
            dgvRegistros.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ofd1
            // 
            ofd1.FileName = "openFileDialog1";
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.FillWeight = 150F;
            Column2.HeaderText = "Nombre";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.FillWeight = 200F;
            Column3.HeaderText = "Correo";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 200;
            // 
            // Column4
            // 
            Column4.HeaderText = "Column4";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Resizable = DataGridViewTriState.True;
            Column4.SortMode = DataGridViewColumnSortMode.Automatic;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Column5";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Resizable = DataGridViewTriState.True;
            Column5.SortMode = DataGridViewColumnSortMode.Automatic;
            Column5.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 555);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Registros";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dgvRegistros;
        private Button butCargar;
        private DataGridView dgv1;
        private OpenFileDialog ofd1;
        private Button butGuardar;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewImageColumn Column4;
        private DataGridViewImageColumn Column5;
    }
}
