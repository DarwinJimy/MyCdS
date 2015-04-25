namespace LayerFrames
{
    partial class FrmCurso
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.LblUser = new System.Windows.Forms.Label();
            this.DGVCursos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNombreCurso = new System.Windows.Forms.TextBox();
            this.LblCodigoCurso = new System.Windows.Forms.Label();
            this.TxtCodigoAlumno = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cursoTableAdapter1 = new DBconection.SISPRO_dbDataSetTableAdapters.cursoTableAdapter();
            this.sisprO_dbDataSet1 = new DBconection.SISPRO_dbDataSet();
            this.BtnNotas_curso = new System.Windows.Forms.Button();
            this.BtnGuardarCurso = new System.Windows.Forms.Button();
            this.BtnNuevoCurso = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCursos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sisprO_dbDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblCodigo);
            this.groupBox1.Controls.Add(this.LblUser);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 59);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuario";
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblCodigo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblCodigo.Location = new System.Drawing.Point(612, 29);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(109, 20);
            this.LblCodigo.TabIndex = 2;
            this.LblCodigo.Text = "0000000000";
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblUser.Location = new System.Drawing.Point(16, 29);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(114, 20);
            this.LblUser.TabIndex = 0;
            this.LblUser.Text = "---------------";
            // 
            // DGVCursos
            // 
            this.DGVCursos.AllowUserToAddRows = false;
            this.DGVCursos.AllowUserToDeleteRows = false;
            this.DGVCursos.AllowUserToResizeColumns = false;
            this.DGVCursos.AllowUserToResizeRows = false;
            this.DGVCursos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVCursos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCursos.Location = new System.Drawing.Point(425, 112);
            this.DGVCursos.Name = "DGVCursos";
            this.DGVCursos.ReadOnly = true;
            this.DGVCursos.RowHeadersVisible = false;
            this.DGVCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVCursos.Size = new System.Drawing.Size(322, 178);
            this.DGVCursos.TabIndex = 1;
            this.DGVCursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCursos_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(25, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Curso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Codigo Alumno:";
            // 
            // TxtNombreCurso
            // 
            this.TxtNombreCurso.Location = new System.Drawing.Point(130, 155);
            this.TxtNombreCurso.Name = "TxtNombreCurso";
            this.TxtNombreCurso.Size = new System.Drawing.Size(278, 20);
            this.TxtNombreCurso.TabIndex = 4;
            this.TxtNombreCurso.TextChanged += new System.EventHandler(this.TxtNombreCurso_TextChanged);
            // 
            // LblCodigoCurso
            // 
            this.LblCodigoCurso.AutoSize = true;
            this.LblCodigoCurso.Location = new System.Drawing.Point(105, 18);
            this.LblCodigoCurso.Name = "LblCodigoCurso";
            this.LblCodigoCurso.Size = new System.Drawing.Size(19, 13);
            this.LblCodigoCurso.TabIndex = 6;
            this.LblCodigoCurso.Text = "----";
            // 
            // TxtCodigoAlumno
            // 
            this.TxtCodigoAlumno.Enabled = false;
            this.TxtCodigoAlumno.Location = new System.Drawing.Point(106, 71);
            this.TxtCodigoAlumno.Name = "TxtCodigoAlumno";
            this.TxtCodigoAlumno.Size = new System.Drawing.Size(100, 20);
            this.TxtCodigoAlumno.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.TxtCodigoAlumno);
            this.panel1.Controls.Add(this.LblCodigoCurso);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(22, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 114);
            this.panel1.TabIndex = 10;
            // 
            // cursoTableAdapter1
            // 
            this.cursoTableAdapter1.ClearBeforeFill = true;
            // 
            // sisprO_dbDataSet1
            // 
            this.sisprO_dbDataSet1.DataSetName = "SISPRO_dbDataSet";
            this.sisprO_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnNotas_curso
            // 
            this.BtnNotas_curso.Image = global::LayerFrames.Properties.Resources.notas_curso;
            this.BtnNotas_curso.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnNotas_curso.Location = new System.Drawing.Point(349, 237);
            this.BtnNotas_curso.Name = "BtnNotas_curso";
            this.BtnNotas_curso.Size = new System.Drawing.Size(59, 53);
            this.BtnNotas_curso.TabIndex = 11;
            this.BtnNotas_curso.Text = "Notas";
            this.BtnNotas_curso.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnNotas_curso.UseVisualStyleBackColor = true;
            this.BtnNotas_curso.Click += new System.EventHandler(this.BtnNotas_curso_Click);
            // 
            // BtnGuardarCurso
            // 
            this.BtnGuardarCurso.Image = global::LayerFrames.Properties.Resources.Save_32;
            this.BtnGuardarCurso.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnGuardarCurso.Location = new System.Drawing.Point(89, 237);
            this.BtnGuardarCurso.Name = "BtnGuardarCurso";
            this.BtnGuardarCurso.Size = new System.Drawing.Size(55, 53);
            this.BtnGuardarCurso.TabIndex = 9;
            this.BtnGuardarCurso.Text = "Guardar";
            this.BtnGuardarCurso.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGuardarCurso.UseVisualStyleBackColor = true;
            this.BtnGuardarCurso.Click += new System.EventHandler(this.BtnGuardarCurso_Click);
            // 
            // BtnNuevoCurso
            // 
            this.BtnNuevoCurso.Image = global::LayerFrames.Properties.Resources.agregar_nuevo;
            this.BtnNuevoCurso.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnNuevoCurso.Location = new System.Drawing.Point(32, 237);
            this.BtnNuevoCurso.Name = "BtnNuevoCurso";
            this.BtnNuevoCurso.Size = new System.Drawing.Size(51, 53);
            this.BtnNuevoCurso.TabIndex = 8;
            this.BtnNuevoCurso.Text = "Nuevo";
            this.BtnNuevoCurso.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnNuevoCurso.UseVisualStyleBackColor = true;
            this.BtnNuevoCurso.Click += new System.EventHandler(this.BtnNuevoCurso_Click);
            // 
            // FrmCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(760, 305);
            this.Controls.Add(this.BtnNotas_curso);
            this.Controls.Add(this.BtnGuardarCurso);
            this.Controls.Add(this.BtnNuevoCurso);
            this.Controls.Add(this.TxtNombreCurso);
            this.Controls.Add(this.DGVCursos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCurso";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmCurso_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCursos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sisprO_dbDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.DataGridView DGVCursos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNombreCurso;
        private System.Windows.Forms.Label LblCodigoCurso;
        private System.Windows.Forms.TextBox TxtCodigoAlumno;
        private System.Windows.Forms.Button BtnNuevoCurso;
        private System.Windows.Forms.Button BtnGuardarCurso;
        private System.Windows.Forms.Panel panel1;
        private DBconection.SISPRO_dbDataSetTableAdapters.cursoTableAdapter cursoTableAdapter1;
        private DBconection.SISPRO_dbDataSet sisprO_dbDataSet1;
        private System.Windows.Forms.Button BtnNotas_curso;
    }
}