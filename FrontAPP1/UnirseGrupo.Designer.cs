
namespace FrontAPP1
{
    partial class UnirseGrupo
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
            this.btnUnirseG = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LstGrupos = new System.Windows.Forms.ListBox();
            this.txtGrupos = new System.Windows.Forms.TextBox();
            this.BtnBuscarGrupo = new System.Windows.Forms.Button();
            this.LstGruposBusq = new System.Windows.Forms.ListBox();
            this.BtnInicioUg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUnirseG
            // 
            this.btnUnirseG.BackColor = System.Drawing.Color.Pink;
            this.btnUnirseG.Location = new System.Drawing.Point(290, 190);
            this.btnUnirseG.Name = "btnUnirseG";
            this.btnUnirseG.Size = new System.Drawing.Size(104, 40);
            this.btnUnirseG.TabIndex = 0;
            this.btnUnirseG.Text = "Unirse";
            this.btnUnirseG.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unirse a un grupo";
            // 
            // LstGrupos
            // 
            this.LstGrupos.FormattingEnabled = true;
            this.LstGrupos.Location = new System.Drawing.Point(28, 166);
            this.LstGrupos.Name = "LstGrupos";
            this.LstGrupos.Size = new System.Drawing.Size(224, 225);
            this.LstGrupos.TabIndex = 2;
            // 
            // txtGrupos
            // 
            this.txtGrupos.BackColor = System.Drawing.Color.MistyRose;
            this.txtGrupos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrupos.Location = new System.Drawing.Point(290, 133);
            this.txtGrupos.Name = "txtGrupos";
            this.txtGrupos.Size = new System.Drawing.Size(226, 26);
            this.txtGrupos.TabIndex = 3;
            // 
            // BtnBuscarGrupo
            // 
            this.BtnBuscarGrupo.BackColor = System.Drawing.Color.Pink;
            this.BtnBuscarGrupo.Location = new System.Drawing.Point(412, 190);
            this.BtnBuscarGrupo.Name = "BtnBuscarGrupo";
            this.BtnBuscarGrupo.Size = new System.Drawing.Size(104, 40);
            this.BtnBuscarGrupo.TabIndex = 4;
            this.BtnBuscarGrupo.Text = "Buscar";
            this.BtnBuscarGrupo.UseVisualStyleBackColor = false;
            // 
            // LstGruposBusq
            // 
            this.LstGruposBusq.FormattingEnabled = true;
            this.LstGruposBusq.Location = new System.Drawing.Point(549, 166);
            this.LstGruposBusq.Name = "LstGruposBusq";
            this.LstGruposBusq.Size = new System.Drawing.Size(223, 225);
            this.LstGruposBusq.TabIndex = 5;
            // 
            // BtnInicioUg
            // 
            this.BtnInicioUg.BackColor = System.Drawing.Color.Pink;
            this.BtnInicioUg.Location = new System.Drawing.Point(352, 398);
            this.BtnInicioUg.Name = "BtnInicioUg";
            this.BtnInicioUg.Size = new System.Drawing.Size(88, 40);
            this.BtnInicioUg.TabIndex = 6;
            this.BtnInicioUg.Text = "Inicio";
            this.BtnInicioUg.UseVisualStyleBackColor = false;
            // 
            // UnirseGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnInicioUg);
            this.Controls.Add(this.LstGruposBusq);
            this.Controls.Add(this.BtnBuscarGrupo);
            this.Controls.Add(this.txtGrupos);
            this.Controls.Add(this.LstGrupos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUnirseG);
            this.Name = "UnirseGrupo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.UnirseGrupo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUnirseG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LstGrupos;
        private System.Windows.Forms.TextBox txtGrupos;
        private System.Windows.Forms.Button BtnBuscarGrupo;
        private System.Windows.Forms.ListBox LstGruposBusq;
        private System.Windows.Forms.Button BtnInicioUg;
    }
}