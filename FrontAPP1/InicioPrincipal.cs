using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers; // Importa System.Timers para el temporizador

namespace FrontAPP1
{
    public partial class InicioPrincipal : Form
    {
        public InicioPrincipal()
        {
            InitializeComponent();
         


        }
        private void PerfilOps_Click(object sender, EventArgs e)
        {
            Perfil perfil = new Perfil();
            perfil.Show();
        }

        private void BusquedaOps_Click(object sender, EventArgs e)
        {
            Busqueda busqueda = new Busqueda();
            busqueda.Show();
        }

        private void ChatsOps_Click(object sender, EventArgs e)
        {
            Chats chats = new Chats();
            chats.Show();
        }

        private void CrearGrupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearGrupo crearGrupo = new CrearGrupo();
            crearGrupo.Show();
        }

        private void UnirseAGrupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnirseGrupo unirseGrupo = new UnirseGrupo();
            unirseGrupo.Show();
        }

        private void MiGrupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrupoActual grupoActual = new GrupoActual();
            grupoActual.Show();
        }

        private async Task<List<string>> GetNotificationsFromBackend()
        {
            // Aquí iría la lógica para hacer una llamada a tu backend y obtener las notificaciones
            // Este es un ejemplo ficticio
            return new List<string>(); // Simulando que no hay notificaciones
        }

        private void CerrarSesionOps_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Cierra todas las ventanas abiertas
                foreach (Form form in Application.OpenForms)
                {
                    form.Close();
                }
            }
        }
    }
}
