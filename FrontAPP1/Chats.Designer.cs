
namespace FrontAPP1
{
    partial class Chats
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
            this.lstConversaciones = new System.Windows.Forms.ListBox();
            this.pnlMensajes = new System.Windows.Forms.Panel();
            this.lblMensajeEnviado = new System.Windows.Forms.Label();
            this.lblMensajeRecibido = new System.Windows.Forms.Label();
            this.txtEscribirMensaje = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.BtnNuevaConversacion = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnCmbiarmodoCH = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMensajes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstConversaciones
            // 
            this.lstConversaciones.BackColor = System.Drawing.Color.Pink;
            this.lstConversaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstConversaciones.FormattingEnabled = true;
            this.lstConversaciones.ItemHeight = 24;
            this.lstConversaciones.Location = new System.Drawing.Point(12, 166);
            this.lstConversaciones.Name = "lstConversaciones";
            this.lstConversaciones.Size = new System.Drawing.Size(282, 340);
            this.lstConversaciones.TabIndex = 0;
            // 
            // pnlMensajes
            // 
            this.pnlMensajes.BackColor = System.Drawing.Color.LightPink;
            this.pnlMensajes.Controls.Add(this.lblMensajeEnviado);
            this.pnlMensajes.Controls.Add(this.lblMensajeRecibido);
            this.pnlMensajes.Controls.Add(this.txtEscribirMensaje);
            this.pnlMensajes.Controls.Add(this.btnEnviar);
            this.pnlMensajes.Location = new System.Drawing.Point(390, 118);
            this.pnlMensajes.Name = "pnlMensajes";
            this.pnlMensajes.Size = new System.Drawing.Size(537, 412);
            this.pnlMensajes.TabIndex = 1;
            // 
            // lblMensajeEnviado
            // 
            this.lblMensajeEnviado.AutoSize = true;
            this.lblMensajeEnviado.BackColor = System.Drawing.Color.MediumVioletRed;
            this.lblMensajeEnviado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeEnviado.Location = new System.Drawing.Point(408, 22);
            this.lblMensajeEnviado.Name = "lblMensajeEnviado";
            this.lblMensajeEnviado.Size = new System.Drawing.Size(86, 24);
            this.lblMensajeEnviado.TabIndex = 3;
            this.lblMensajeEnviado.Text = "Enviado";
            // 
            // lblMensajeRecibido
            // 
            this.lblMensajeRecibido.AutoSize = true;
            this.lblMensajeRecibido.BackColor = System.Drawing.Color.HotPink;
            this.lblMensajeRecibido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeRecibido.ForeColor = System.Drawing.Color.Black;
            this.lblMensajeRecibido.Location = new System.Drawing.Point(47, 22);
            this.lblMensajeRecibido.Name = "lblMensajeRecibido";
            this.lblMensajeRecibido.Size = new System.Drawing.Size(93, 24);
            this.lblMensajeRecibido.TabIndex = 2;
            this.lblMensajeRecibido.Text = "Recibido";
            // 
            // txtEscribirMensaje
            // 
            this.txtEscribirMensaje.BackColor = System.Drawing.Color.MistyRose;
            this.txtEscribirMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEscribirMensaje.Location = new System.Drawing.Point(23, 368);
            this.txtEscribirMensaje.Name = "txtEscribirMensaje";
            this.txtEscribirMensaje.Size = new System.Drawing.Size(406, 31);
            this.txtEscribirMensaje.TabIndex = 1;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.MistyRose;
            this.btnEnviar.FlatAppearance.BorderColor = System.Drawing.Color.LavenderBlush;
            this.btnEnviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LavenderBlush;
            this.btnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(450, 365);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 34);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            // 
            // BtnNuevaConversacion
            // 
            this.BtnNuevaConversacion.BackColor = System.Drawing.Color.MistyRose;
            this.BtnNuevaConversacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevaConversacion.Location = new System.Drawing.Point(12, 118);
            this.BtnNuevaConversacion.Name = "BtnNuevaConversacion";
            this.BtnNuevaConversacion.Size = new System.Drawing.Size(282, 29);
            this.BtnNuevaConversacion.TabIndex = 2;
            this.BtnNuevaConversacion.Text = "Crear conversacion";
            this.BtnNuevaConversacion.UseVisualStyleBackColor = false;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Pink;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Location = new System.Drawing.Point(830, 12);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(97, 39);
            this.btnInicio.TabIndex = 3;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = false;
            // 
            // btnCmbiarmodoCH
            // 
            this.btnCmbiarmodoCH.BackColor = System.Drawing.Color.MistyRose;
            this.btnCmbiarmodoCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCmbiarmodoCH.Location = new System.Drawing.Point(393, 74);
            this.btnCmbiarmodoCH.Name = "btnCmbiarmodoCH";
            this.btnCmbiarmodoCH.Size = new System.Drawing.Size(137, 29);
            this.btnCmbiarmodoCH.TabIndex = 4;
            this.btnCmbiarmodoCH.Text = "Cambiar modo";
            this.btnCmbiarmodoCH.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 85);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chats";
            // 
            // Chats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(949, 529);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCmbiarmodoCH);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.BtnNuevaConversacion);
            this.Controls.Add(this.pnlMensajes);
            this.Controls.Add(this.lstConversaciones);
            this.DoubleBuffered = true;
            this.Name = "Chats";
            this.Text = "Form1";
            this.pnlMensajes.ResumeLayout(false);
            this.pnlMensajes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstConversaciones;
        private System.Windows.Forms.Panel pnlMensajes;
        private System.Windows.Forms.Label lblMensajeEnviado;
        private System.Windows.Forms.Label lblMensajeRecibido;
        private System.Windows.Forms.TextBox txtEscribirMensaje;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button BtnNuevaConversacion;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnCmbiarmodoCH;
        private System.Windows.Forms.Label label1;
    }
}