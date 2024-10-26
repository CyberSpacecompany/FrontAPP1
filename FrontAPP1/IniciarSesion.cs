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
    public partial class IniciarSesion : Form
    {
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void BtnInicioSesion_Click(object sender, EventArgs e)
        {
            // Obtener los datos ingresados en los TextBox
            string usuarioIngresado = txtUsuarioLog.Text;
            string contraseniaIngresada = txtContraseniaLog.Text;

            // Validación de nombre de usuario (5-15 caracteres)
            if (usuarioIngresado.Length < 5 || usuarioIngresado.Length > 15)
            {
                MessageBox.Show("El nombre de usuario debe tener entre 5 y 15 caracteres.");
                return;
            }

            // Validación de contraseña (5-13 caracteres, incluyendo al menos un número)
            if (contraseniaIngresada.Length < 5 || contraseniaIngresada.Length > 13 || !contraseniaIngresada.Any(char.IsDigit))
            {
                MessageBox.Show("La contraseña debe tener entre 5 y 13 caracteres y contener al menos un número.");
                return;
            }
            Inicio inicio = new Inicio();
            inicio.Close();
            this.Hide();
            // Si las validaciones se cumplen, abre la ventana de InicioPrincipal
            InicioPrincipal inicioPrincipal = new InicioPrincipal();
            inicioPrincipal.Show();
            this.Hide(); // Oculta la ventana actual
        }
    }
}
