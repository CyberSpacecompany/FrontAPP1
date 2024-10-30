
namespace FrontAPP1
{
    partial class Perfil
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.SeguidoresOps = new System.Windows.Forms.ToolStripMenuItem();
            this.SeguidosOps = new System.Windows.Forms.ToolStripMenuItem();
            this.EditarCuentaOps = new System.Windows.Forms.ToolStripMenuItem();
            this.Guardados = new System.Windows.Forms.ToolStripMenuItem();
            this.LblDescripcionPerfil = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LblNombredeusuarioperf = new System.Windows.Forms.Label();
            this.LblFechaCreacionperf = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnInicioPerf = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Pink;
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.menuStrip2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SeguidoresOps,
            this.SeguidosOps,
            this.EditarCuentaOps,
            this.Guardados});
            this.menuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(934, 33);
            this.menuStrip2.Stretch = false;
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.UseWaitCursor = true;
            // 
            // SeguidoresOps
            // 
            this.SeguidoresOps.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeguidoresOps.Name = "SeguidoresOps";
            this.SeguidoresOps.Size = new System.Drawing.Size(130, 29);
            this.SeguidoresOps.Text = "Seguidores";
            // 
            // SeguidosOps
            // 
            this.SeguidosOps.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeguidosOps.Name = "SeguidosOps";
            this.SeguidosOps.Size = new System.Drawing.Size(111, 29);
            this.SeguidosOps.Text = "Seguidos";
            // 
            // EditarCuentaOps
            // 
            this.EditarCuentaOps.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditarCuentaOps.Name = "EditarCuentaOps";
            this.EditarCuentaOps.Size = new System.Drawing.Size(153, 29);
            this.EditarCuentaOps.Text = "Editar cuenta";
            this.EditarCuentaOps.Click += new System.EventHandler(this.EditarCuentaOps_Click);
            // 
            // Guardados
            // 
            this.Guardados.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardados.Name = "Guardados";
            this.Guardados.Size = new System.Drawing.Size(128, 29);
            this.Guardados.Text = "Guardados";
            // 
            // LblDescripcionPerfil
            // 
            this.LblDescripcionPerfil.AutoSize = true;
            this.LblDescripcionPerfil.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripcionPerfil.Location = new System.Drawing.Point(186, 127);
            this.LblDescripcionPerfil.Name = "LblDescripcionPerfil";
            this.LblDescripcionPerfil.Size = new System.Drawing.Size(138, 28);
            this.LblDescripcionPerfil.TabIndex = 1;
            this.LblDescripcionPerfil.Text = "Descripcion:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(186, 158);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(697, 20);
            this.textBox1.TabIndex = 2;
            // 
            // LblNombredeusuarioperf
            // 
            this.LblNombredeusuarioperf.AutoSize = true;
            this.LblNombredeusuarioperf.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombredeusuarioperf.Location = new System.Drawing.Point(186, 63);
            this.LblNombredeusuarioperf.Name = "LblNombredeusuarioperf";
            this.LblNombredeusuarioperf.Size = new System.Drawing.Size(271, 39);
            this.LblNombredeusuarioperf.TabIndex = 3;
            this.LblNombredeusuarioperf.Text = "Nombre de usuario";
            // 
            // LblFechaCreacionperf
            // 
            this.LblFechaCreacionperf.AutoSize = true;
            this.LblFechaCreacionperf.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaCreacionperf.Location = new System.Drawing.Point(589, 9);
            this.LblFechaCreacionperf.Name = "LblFechaCreacionperf";
            this.LblFechaCreacionperf.Size = new System.Drawing.Size(121, 20);
            this.LblFechaCreacionperf.TabIndex = 4;
            this.LblFechaCreacionperf.Text = "Cuenta creada:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(186, 240);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(697, 271);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // BtnInicioPerf
            // 
            this.BtnInicioPerf.BackColor = System.Drawing.Color.Pink;
            this.BtnInicioPerf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInicioPerf.Location = new System.Drawing.Point(23, 475);
            this.BtnInicioPerf.Name = "BtnInicioPerf";
            this.BtnInicioPerf.Size = new System.Drawing.Size(109, 36);
            this.BtnInicioPerf.TabIndex = 6;
            this.BtnInicioPerf.Text = "Inicio";
            this.BtnInicioPerf.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Orchid;
            this.pictureBox1.Location = new System.Drawing.Point(23, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 142);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(934, 523);
            this.Controls.Add(this.BtnInicioPerf);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.LblFechaCreacionperf);
            this.Controls.Add(this.LblNombredeusuarioperf);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblDescripcionPerfil);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Perfil";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Perfil_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem SeguidoresOps;
        private System.Windows.Forms.ToolStripMenuItem SeguidosOps;
        private System.Windows.Forms.ToolStripMenuItem EditarCuentaOps;
        private System.Windows.Forms.ToolStripMenuItem Guardados;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblDescripcionPerfil;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LblNombredeusuarioperf;
        private System.Windows.Forms.Label LblFechaCreacionperf;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BtnInicioPerf;
    }
}