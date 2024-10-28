
namespace FrontAPP1
{
    partial class PersonalizacionPerfil
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnHecho = new System.Windows.Forms.Button();
            this.btnFotoPerfil = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PictureBoxPerfil = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.PictureBoxPerfil);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 246);
            this.panel1.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(246, 148);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(424, 20);
            this.txtDescripcion.TabIndex = 5;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.TxtDescripcion_TextChanged);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(241, 116);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(158, 29);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripcion";
            this.lblDescripcion.Click += new System.EventHandler(this.LblDescripcion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de usuario";
            // 
            // BtnHecho
            // 
            this.BtnHecho.BackColor = System.Drawing.Color.Pink;
            this.BtnHecho.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnHecho.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnHecho.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnHecho.Location = new System.Drawing.Point(872, 496);
            this.BtnHecho.Name = "BtnHecho";
            this.BtnHecho.Size = new System.Drawing.Size(103, 45);
            this.BtnHecho.TabIndex = 3;
            this.BtnHecho.Text = "Hecho";
            this.BtnHecho.UseVisualStyleBackColor = false;
            this.BtnHecho.Click += new System.EventHandler(this.BtnHecho_Click);
            // 
            // btnFotoPerfil
            // 
            this.btnFotoPerfil.BackColor = System.Drawing.Color.Pink;
            this.btnFotoPerfil.Location = new System.Drawing.Point(12, 265);
            this.btnFotoPerfil.Name = "btnFotoPerfil";
            this.btnFotoPerfil.Size = new System.Drawing.Size(247, 23);
            this.btnFotoPerfil.TabIndex = 4;
            this.btnFotoPerfil.Text = "Seleccionar Imagen";
            this.btnFotoPerfil.UseVisualStyleBackColor = false;
            this.btnFotoPerfil.Click += new System.EventHandler(this.BtnFotoPerfil_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PictureBoxPerfil
            // 
            this.PictureBoxPerfil.BackColor = System.Drawing.Color.Pink;
            this.PictureBoxPerfil.Location = new System.Drawing.Point(12, 24);
            this.PictureBoxPerfil.Name = "PictureBoxPerfil";
            this.PictureBoxPerfil.Size = new System.Drawing.Size(228, 192);
            this.PictureBoxPerfil.TabIndex = 7;
            this.PictureBoxPerfil.TabStop = false;
            // 
            // PersonalizacionPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(998, 553);
            this.Controls.Add(this.btnFotoPerfil);
            this.Controls.Add(this.BtnHecho);
            this.Controls.Add(this.panel1);
            this.Name = "PersonalizacionPerfil";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PersonalizacionPerfil_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPerfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnHecho;
        private System.Windows.Forms.Button btnFotoPerfil;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox PictureBoxPerfil;
    }
}