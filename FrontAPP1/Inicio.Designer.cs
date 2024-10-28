
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnTestearConexion = new System.Windows.Forms.Button();
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
            this.button1.Location = new System.Drawing.Point(568, 278);
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
            this.BtnCrearCuenta.Location = new System.Drawing.Point(22, 278);
            this.BtnCrearCuenta.Name = "BtnCrearCuenta";
            this.BtnCrearCuenta.Size = new System.Drawing.Size(205, 74);
            this.BtnCrearCuenta.TabIndex = 1;
            this.BtnCrearCuenta.Text = "Crear cuenta";
            this.BtnCrearCuenta.UseVisualStyleBackColor = false;
            this.BtnCrearCuenta.Click += new System.EventHandler(this.BtnCrearCuenta_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSalir.Location = new System.Drawing.Point(12, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnTestearConexion
            // 
            this.btnTestearConexion.Location = new System.Drawing.Point(341, 369);
            this.btnTestearConexion.Name = "btnTestearConexion";
            this.btnTestearConexion.Size = new System.Drawing.Size(101, 73);
            this.btnTestearConexion.TabIndex = 3;
            this.btnTestearConexion.Text = "testear";
            this.btnTestearConexion.UseVisualStyleBackColor = true;
            this.btnTestearConexion.Click += new System.EventHandler(this.BtnTestearConexion_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FrontAPP1.Properties.Resources.blancologozoom;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(806, 469);
            this.Controls.Add(this.btnTestearConexion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.BtnCrearCuenta);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "Inicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnCrearCuenta;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnTestearConexion;
    }
}

