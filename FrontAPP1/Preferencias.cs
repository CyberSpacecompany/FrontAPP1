using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontAPP1
{
    public partial class Preferencias : Form
    {
        public Preferencias()
        {
            InitializeComponent();
        }

        private void BtnHechoPreferencias_Click(object sender, EventArgs e)
        {
            // Reinicia la preferencia de contenido antes de asignar una nueva
            DatosUsuario.PreferenciaContenido = string.Empty;

            // Verifica qué CheckBox está seleccionado y guarda la preferencia de contenido
            if (checkBoxDanza.Checked)
            {
                DatosUsuario.PreferenciaContenido = "Danza";
            }
            else if (checkBoxLiteratura.Checked)
            {
                DatosUsuario.PreferenciaContenido = "Literatura";
            }
            else if (checkBoxPintura.Checked)
            {
                DatosUsuario.PreferenciaContenido = "Pintura";
            }
            else if (checkBoxMusica.Checked)
            {
                DatosUsuario.PreferenciaContenido = "Música";
            }

            // Validación para asegurarse de que se ha seleccionado una preferencia
            if (string.IsNullOrEmpty(DatosUsuario.PreferenciaContenido))
            {
                MessageBox.Show("Por favor, selecciona al menos una preferencia de contenido.");
                return;
            }

            // Abre la ventana de inicio si se seleccionó una preferencia
            InicioPrincipal inicio = new InicioPrincipal();
            inicio.Show();
            Inicio inicio2 = new Inicio();
            inicio2.Hide();
            this.Hide(); // Oculta la ventana actual de Preferencias
        }
    }
}
