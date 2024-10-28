
namespace FrontAPP1
{
    partial class Preferencias
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
            this.checkBoxMusica = new System.Windows.Forms.CheckBox();
            this.checkBoxLiteratura = new System.Windows.Forms.CheckBox();
            this.checkBoxDanza = new System.Windows.Forms.CheckBox();
            this.checkBoxPintura = new System.Windows.Forms.CheckBox();
            this.btnHechoPreferencias = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxMusica
            // 
            this.checkBoxMusica.AutoSize = true;
            this.checkBoxMusica.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxMusica.Font = new System.Drawing.Font("Mongolian Baiti", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMusica.Location = new System.Drawing.Point(144, 211);
            this.checkBoxMusica.Name = "checkBoxMusica";
            this.checkBoxMusica.Size = new System.Drawing.Size(147, 41);
            this.checkBoxMusica.TabIndex = 0;
            this.checkBoxMusica.Text = "Musica";
            this.checkBoxMusica.UseVisualStyleBackColor = false;
            // 
            // checkBoxLiteratura
            // 
            this.checkBoxLiteratura.AutoSize = true;
            this.checkBoxLiteratura.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxLiteratura.Font = new System.Drawing.Font("Mongolian Baiti", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLiteratura.Location = new System.Drawing.Point(133, 442);
            this.checkBoxLiteratura.Name = "checkBoxLiteratura";
            this.checkBoxLiteratura.Size = new System.Drawing.Size(187, 41);
            this.checkBoxLiteratura.TabIndex = 1;
            this.checkBoxLiteratura.Text = "Literatura";
            this.checkBoxLiteratura.UseVisualStyleBackColor = false;
            // 
            // checkBoxDanza
            // 
            this.checkBoxDanza.AutoSize = true;
            this.checkBoxDanza.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDanza.Font = new System.Drawing.Font("Mongolian Baiti", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDanza.Location = new System.Drawing.Point(621, 211);
            this.checkBoxDanza.Name = "checkBoxDanza";
            this.checkBoxDanza.Size = new System.Drawing.Size(132, 41);
            this.checkBoxDanza.TabIndex = 2;
            this.checkBoxDanza.Text = "Danza";
            this.checkBoxDanza.UseVisualStyleBackColor = false;
            // 
            // checkBoxPintura
            // 
            this.checkBoxPintura.AutoSize = true;
            this.checkBoxPintura.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxPintura.Font = new System.Drawing.Font("Mongolian Baiti", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPintura.Location = new System.Drawing.Point(621, 442);
            this.checkBoxPintura.Name = "checkBoxPintura";
            this.checkBoxPintura.Size = new System.Drawing.Size(146, 41);
            this.checkBoxPintura.TabIndex = 3;
            this.checkBoxPintura.Text = "Pintura";
            this.checkBoxPintura.UseVisualStyleBackColor = false;
            // 
            // btnHechoPreferencias
            // 
            this.btnHechoPreferencias.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnHechoPreferencias.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
            this.btnHechoPreferencias.ForeColor = System.Drawing.Color.White;
            this.btnHechoPreferencias.Location = new System.Drawing.Point(803, 528);
            this.btnHechoPreferencias.Name = "btnHechoPreferencias";
            this.btnHechoPreferencias.Size = new System.Drawing.Size(93, 40);
            this.btnHechoPreferencias.TabIndex = 4;
            this.btnHechoPreferencias.Text = "Hecho";
            this.btnHechoPreferencias.UseVisualStyleBackColor = false;
            this.btnHechoPreferencias.Click += new System.EventHandler(this.BtnHechoPreferencias_Click);
            // 
            // Preferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FrontAPP1.Properties.Resources.preferenciascolor;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(908, 580);
            this.Controls.Add(this.btnHechoPreferencias);
            this.Controls.Add(this.checkBoxPintura);
            this.Controls.Add(this.checkBoxDanza);
            this.Controls.Add(this.checkBoxLiteratura);
            this.Controls.Add(this.checkBoxMusica);
            this.DoubleBuffered = true;
            this.Name = "Preferencias";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Preferencias_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxMusica;
        private System.Windows.Forms.CheckBox checkBoxLiteratura;
        private System.Windows.Forms.CheckBox checkBoxDanza;
        private System.Windows.Forms.CheckBox checkBoxPintura;
        private System.Windows.Forms.Button btnHechoPreferencias;
    }
}