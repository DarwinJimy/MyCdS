namespace LayerFrames
{
    partial class FrmPrincipal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnNotas = new System.Windows.Forms.Button();
            this.BtnCurso = new System.Windows.Forms.Button();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblCodigo);
            this.groupBox1.Controls.Add(this.LblUsuario);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuario";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(7, 19);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(37, 20);
            this.LblUsuario.TabIndex = 0;
            this.LblUsuario.Text = "----";
            this.LblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.LightCoral;
            this.BtnCerrar.Location = new System.Drawing.Point(23, 244);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(21, 21);
            this.BtnCerrar.TabIndex = 1;
            this.BtnCerrar.Text = "x";
            this.BtnCerrar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnNotas
            // 
            this.BtnNotas.Image = global::LayerFrames.Properties.Resources.notas1;
            this.BtnNotas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnNotas.Location = new System.Drawing.Point(334, 110);
            this.BtnNotas.Name = "BtnNotas";
            this.BtnNotas.Size = new System.Drawing.Size(108, 97);
            this.BtnNotas.TabIndex = 2;
            this.BtnNotas.Text = "Notas";
            this.BtnNotas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnNotas.UseVisualStyleBackColor = true;
            // 
            // BtnCurso
            // 
            this.BtnCurso.Image = global::LayerFrames.Properties.Resources.curso;
            this.BtnCurso.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCurso.Location = new System.Drawing.Point(168, 110);
            this.BtnCurso.Name = "BtnCurso";
            this.BtnCurso.Size = new System.Drawing.Size(108, 97);
            this.BtnCurso.TabIndex = 1;
            this.BtnCurso.Text = "Cursos";
            this.BtnCurso.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCurso.UseVisualStyleBackColor = true;
            this.BtnCurso.Click += new System.EventHandler(this.BtnCurso_Click);
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblCodigo.Location = new System.Drawing.Point(479, 19);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(109, 20);
            this.LblCodigo.TabIndex = 1;
            this.LblCodigo.Text = "0000000000";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(618, 274);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnNotas);
            this.Controls.Add(this.BtnCurso);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnCurso;
        private System.Windows.Forms.Button BtnNotas;
        private System.Windows.Forms.Label LblCodigo;
    }
}