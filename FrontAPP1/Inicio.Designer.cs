
namespace FrontAPP1
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.BtnCrearCuenta = new System.Windows.Forms.Button();
            this.btnCambiarmodo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Pink;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightPink;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(716, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 74);
            this.button1.TabIndex = 0;
            this.button1.Text = "Iniciar Sesion";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BtnIniciarsesion);
            // 
            // BtnCrearCuenta
            // 
            this.BtnCrearCuenta.BackColor = System.Drawing.Color.Pink;
            this.BtnCrearCuenta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnCrearCuenta.FlatAppearance.BorderSize = 0;
            this.BtnCrearCuenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightPink;
            this.BtnCrearCuenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.BtnCrearCuenta.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrearCuenta.Location = new System.Drawing.Point(70, 295);
            this.BtnCrearCuenta.Name = "BtnCrearCuenta";
            this.BtnCrearCuenta.Size = new System.Drawing.Size(205, 74);
            this.BtnCrearCuenta.TabIndex = 1;
            this.BtnCrearCuenta.Text = "Crear cuenta";
            this.BtnCrearCuenta.UseVisualStyleBackColor = false;
            this.BtnCrearCuenta.Click += new System.EventHandler(this.BtnCrearCuenta_Click);
            // 
            // btnCambiarmodo
            // 
            this.btnCambiarmodo.Location = new System.Drawing.Point(406, 433);
            this.btnCambiarmodo.Name = "btnCambiarmodo";
            this.btnCambiarmodo.Size = new System.Drawing.Size(183, 56);
            this.btnCambiarmodo.TabIndex = 2;
            this.btnCambiarmodo.Text = "Cambiar modo";
            this.btnCambiarmodo.UseVisualStyleBackColor = true;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FrontAPP1.Properties.Resources.blancologozoom;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(985, 526);
            this.Controls.Add(this.btnCambiarmodo);
            this.Controls.Add(this.BtnCrearCuenta);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "Inicio";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnCrearCuenta;
        private System.Windows.Forms.Button btnCambiarmodo;
    }
}

