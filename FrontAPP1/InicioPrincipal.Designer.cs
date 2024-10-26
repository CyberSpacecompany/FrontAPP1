
namespace FrontAPP1
{
    partial class InicioPrincipal
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
            this.MenuOps = new System.Windows.Forms.MenuStrip();
            this.perfilOps = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaOps = new System.Windows.Forms.ToolStripMenuItem();
            this.chatsOps = new System.Windows.Forms.ToolStripMenuItem();
            this.gruposOps = new System.Windows.Forms.ToolStripMenuItem();
            this.crearGrupoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unirseAGrupoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miGrupoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificacionesOps = new System.Windows.Forms.ToolStripMenuItem();
            this.CerrarSesionOps = new System.Windows.Forms.ToolStripMenuItem();
            this.Iniciolbl = new System.Windows.Forms.Label();
            this.BtnCambiarModoIP = new System.Windows.Forms.Button();
            this.flowLayoutPanelPubli = new System.Windows.Forms.FlowLayoutPanel();
            this.MenuOps.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuOps
            // 
            this.MenuOps.BackColor = System.Drawing.Color.Pink;
            this.MenuOps.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuOps.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilOps,
            this.busquedaOps,
            this.chatsOps,
            this.gruposOps,
            this.notificacionesOps,
            this.CerrarSesionOps});
            this.MenuOps.Location = new System.Drawing.Point(0, 0);
            this.MenuOps.Name = "MenuOps";
            this.MenuOps.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MenuOps.Size = new System.Drawing.Size(890, 45);
            this.MenuOps.TabIndex = 0;
            this.MenuOps.Text = "Menu";
            // 
            // perfilOps
            // 
            this.perfilOps.ForeColor = System.Drawing.Color.White;
            this.perfilOps.Name = "perfilOps";
            this.perfilOps.Size = new System.Drawing.Size(89, 41);
            this.perfilOps.Text = "Perfil";
            this.perfilOps.Click += new System.EventHandler(this.PerfilOps_Click);
            // 
            // busquedaOps
            // 
            this.busquedaOps.ForeColor = System.Drawing.Color.White;
            this.busquedaOps.Name = "busquedaOps";
            this.busquedaOps.Size = new System.Drawing.Size(145, 41);
            this.busquedaOps.Text = "Busqueda";
            this.busquedaOps.Click += new System.EventHandler(this.BusquedaOps_Click);
            // 
            // chatsOps
            // 
            this.chatsOps.ForeColor = System.Drawing.Color.White;
            this.chatsOps.Name = "chatsOps";
            this.chatsOps.Size = new System.Drawing.Size(95, 41);
            this.chatsOps.Text = "Chats";
            this.chatsOps.Click += new System.EventHandler(this.ChatsOps_Click);
            // 
            // gruposOps
            // 
            this.gruposOps.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearGrupoToolStripMenuItem,
            this.unirseAGrupoToolStripMenuItem,
            this.miGrupoToolStripMenuItem});
            this.gruposOps.ForeColor = System.Drawing.Color.White;
            this.gruposOps.Name = "gruposOps";
            this.gruposOps.Size = new System.Drawing.Size(115, 41);
            this.gruposOps.Text = "Grupos";
            // 
            // crearGrupoToolStripMenuItem
            // 
            this.crearGrupoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crearGrupoToolStripMenuItem.Name = "crearGrupoToolStripMenuItem";
            this.crearGrupoToolStripMenuItem.Size = new System.Drawing.Size(228, 34);
            this.crearGrupoToolStripMenuItem.Text = "Crear Grupo";
            this.crearGrupoToolStripMenuItem.Click += new System.EventHandler(this.CrearGrupoToolStripMenuItem_Click);
            // 
            // unirseAGrupoToolStripMenuItem
            // 
            this.unirseAGrupoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unirseAGrupoToolStripMenuItem.Name = "unirseAGrupoToolStripMenuItem";
            this.unirseAGrupoToolStripMenuItem.Size = new System.Drawing.Size(228, 34);
            this.unirseAGrupoToolStripMenuItem.Text = "Unirse a Grupo";
            this.unirseAGrupoToolStripMenuItem.Click += new System.EventHandler(this.UnirseAGrupoToolStripMenuItem_Click);
            // 
            // miGrupoToolStripMenuItem
            // 
            this.miGrupoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miGrupoToolStripMenuItem.Name = "miGrupoToolStripMenuItem";
            this.miGrupoToolStripMenuItem.Size = new System.Drawing.Size(228, 34);
            this.miGrupoToolStripMenuItem.Text = "Mi Grupo";
            this.miGrupoToolStripMenuItem.Click += new System.EventHandler(this.MiGrupoToolStripMenuItem_Click);
            // 
            // notificacionesOps
            // 
            this.notificacionesOps.ForeColor = System.Drawing.Color.White;
            this.notificacionesOps.Name = "notificacionesOps";
            this.notificacionesOps.Size = new System.Drawing.Size(197, 41);
            this.notificacionesOps.Text = "Notificaciones";
            this.notificacionesOps.Click += new System.EventHandler(this.NotificacionesOps_Click);
            // 
            // CerrarSesionOps
            // 
            this.CerrarSesionOps.ForeColor = System.Drawing.Color.White;
            this.CerrarSesionOps.Name = "CerrarSesionOps";
            this.CerrarSesionOps.Size = new System.Drawing.Size(182, 41);
            this.CerrarSesionOps.Text = "Cerrar sesion";
            this.CerrarSesionOps.Click += new System.EventHandler(this.CerrarSesionOps_Click);
            // 
            // Iniciolbl
            // 
            this.Iniciolbl.AutoSize = true;
            this.Iniciolbl.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Iniciolbl.Location = new System.Drawing.Point(1, 45);
            this.Iniciolbl.Name = "Iniciolbl";
            this.Iniciolbl.Size = new System.Drawing.Size(163, 85);
            this.Iniciolbl.TabIndex = 2;
            this.Iniciolbl.Text = "Inicio";
            // 
            // BtnCambiarModoIP
            // 
            this.BtnCambiarModoIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCambiarModoIP.Location = new System.Drawing.Point(32, 481);
            this.BtnCambiarModoIP.Name = "BtnCambiarModoIP";
            this.BtnCambiarModoIP.Size = new System.Drawing.Size(81, 44);
            this.BtnCambiarModoIP.TabIndex = 3;
            this.BtnCambiarModoIP.Text = "Cambiar modo";
            this.BtnCambiarModoIP.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelPubli
            // 
            this.flowLayoutPanelPubli.Location = new System.Drawing.Point(155, 172);
            this.flowLayoutPanelPubli.Name = "flowLayoutPanelPubli";
            this.flowLayoutPanelPubli.Size = new System.Drawing.Size(585, 369);
            this.flowLayoutPanelPubli.TabIndex = 4;
            // 
            // InicioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(890, 537);
            this.Controls.Add(this.flowLayoutPanelPubli);
            this.Controls.Add(this.BtnCambiarModoIP);
            this.Controls.Add(this.Iniciolbl);
            this.Controls.Add(this.MenuOps);
            this.Name = "InicioPrincipal";
            this.Text = "Form1";
            this.MenuOps.ResumeLayout(false);
            this.MenuOps.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuOps;
        private System.Windows.Forms.ToolStripMenuItem perfilOps;
        private System.Windows.Forms.ToolStripMenuItem busquedaOps;
        private System.Windows.Forms.ToolStripMenuItem chatsOps;
        private System.Windows.Forms.ToolStripMenuItem gruposOps;
        private System.Windows.Forms.ToolStripMenuItem notificacionesOps;
        private System.Windows.Forms.ToolStripMenuItem CerrarSesionOps;
        private System.Windows.Forms.Label Iniciolbl;
        private System.Windows.Forms.ToolStripMenuItem crearGrupoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unirseAGrupoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miGrupoToolStripMenuItem;
        private System.Windows.Forms.Button BtnCambiarModoIP;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPubli;
    }
}