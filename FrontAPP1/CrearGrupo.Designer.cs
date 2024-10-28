
namespace FrontAPP1
{
    partial class CrearGrupo
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
            this.btnIniciocg = new System.Windows.Forms.Button();
            this.btnCrearGrupo = new System.Windows.Forms.Button();
            this.BtnCambiarmodoCG = new System.Windows.Forms.Button();
            this.txtCrearGrupo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIniciocg
            // 
            this.btnIniciocg.BackColor = System.Drawing.Color.Pink;
            this.btnIniciocg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciocg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIniciocg.Location = new System.Drawing.Point(12, 406);
            this.btnIniciocg.Name = "btnIniciocg";
            this.btnIniciocg.Size = new System.Drawing.Size(102, 32);
            this.btnIniciocg.TabIndex = 0;
            this.btnIniciocg.Text = "Inicio";
            this.btnIniciocg.UseVisualStyleBackColor = false;
            this.btnIniciocg.Click += new System.EventHandler(this.btnIniciocg_Click);
            // 
            // btnCrearGrupo
            // 
            this.btnCrearGrupo.BackColor = System.Drawing.Color.Pink;
            this.btnCrearGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearGrupo.ForeColor = System.Drawing.Color.Black;
            this.btnCrearGrupo.Location = new System.Drawing.Point(519, 153);
            this.btnCrearGrupo.Name = "btnCrearGrupo";
            this.btnCrearGrupo.Size = new System.Drawing.Size(180, 39);
            this.btnCrearGrupo.TabIndex = 1;
            this.btnCrearGrupo.Text = "Crear";
            this.btnCrearGrupo.UseVisualStyleBackColor = false;
            // 
            // BtnCambiarmodoCG
            // 
            this.BtnCambiarmodoCG.BackColor = System.Drawing.Color.Pink;
            this.BtnCambiarmodoCG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCambiarmodoCG.Location = new System.Drawing.Point(710, 390);
            this.BtnCambiarmodoCG.Name = "BtnCambiarmodoCG";
            this.BtnCambiarmodoCG.Size = new System.Drawing.Size(78, 48);
            this.BtnCambiarmodoCG.TabIndex = 2;
            this.BtnCambiarmodoCG.Text = "Cambiar modo";
            this.BtnCambiarmodoCG.UseVisualStyleBackColor = false;
            // 
            // txtCrearGrupo
            // 
            this.txtCrearGrupo.BackColor = System.Drawing.Color.Thistle;
            this.txtCrearGrupo.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrearGrupo.Location = new System.Drawing.Point(12, 153);
            this.txtCrearGrupo.Name = "txtCrearGrupo";
            this.txtCrearGrupo.Size = new System.Drawing.Size(463, 39);
            this.txtCrearGrupo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 85);
            this.label1.TabIndex = 4;
            this.label1.Text = "Crear grupo";
            // 
            // CrearGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCrearGrupo);
            this.Controls.Add(this.BtnCambiarmodoCG);
            this.Controls.Add(this.btnCrearGrupo);
            this.Controls.Add(this.btnIniciocg);
            this.DoubleBuffered = true;
            this.Name = "CrearGrupo";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciocg;
        private System.Windows.Forms.Button btnCrearGrupo;
        private System.Windows.Forms.Button BtnCambiarmodoCG;
        private System.Windows.Forms.TextBox txtCrearGrupo;
        private System.Windows.Forms.Label label1;
    }
}