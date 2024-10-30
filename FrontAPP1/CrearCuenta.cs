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
    public partial class CrearCuenta : Form
    {
        public CrearCuenta()
        {
            InitializeComponent();
        }

        public static class DatosUsuario
        {
            public static string Nombreusuario { get; set; }
        }

        private void BtnCrearusuario_Click(object sender, EventArgs e)
        {
            // Validación de nombre de usuario (5-15 caracteres)
            string usuario = txtUsuarionuevo.Text;
            if (usuario.Length < 5 || usuario.Length > 15)
            {
                MessageBox.Show("El nombre de usuario debe tener entre 5 y 15 caracteres.");
                return;
            }

            // Validación de contraseña (5-13 caracteres, incluyendo al menos un número)
            string contrasenia = txtCreacontrasenia.Text;
            if (contrasenia.Length < 5 || contrasenia.Length > 13 || !contrasenia.Any(char.IsDigit))
            {
                MessageBox.Show("La contraseña debe tener entre 5 y 13 caracteres y contener al menos un número.");
                return;
            }

            // Confirmación de la contraseña
            string confirmacionContrasenia = txtConfirmacontrasenia.Text;
            if (contrasenia != confirmacionContrasenia)
            {
                MessageBox.Show("La confirmación de la contraseña no coincide.");
                return;
            }

            // Validación de correo electrónico con dominios específicos
            string correo = txtCorreoelectronico.Text;
            if (!(correo.Contains("@gmail.com") || correo.Contains("@hotmail.com") || correo.Contains("@yahoo.com") || correo.Contains("@outlook.com")))
            {
                MessageBox.Show("El correo electrónico debe ser válido y con un dominio popular.");
                return;
            }

            // Validación de la edad (mayor o igual a 15 años)
            if (!int.TryParse(txtEdad.Text, out int edad) || edad < 15)
            {
                MessageBox.Show("La edad debe ser un número mayor o igual a 15.");
                return;
            }
            DatosUsuario.Nombreusuario = txtUsuarionuevo.Text;

            // Si todas las validaciones pasan, aquí se podría proceder a guardar en la base de datos.
            MessageBox.Show("Registro completado exitosamente.");

            PersonalizacionPerfil personalizacionPerfil = new PersonalizacionPerfil();
            personalizacionPerfil.Show();
            this.Hide();
            Nombreusuario = txtUsuarionuevo.Text;

        }

        public static string Nombreusuario { get; set; } // En una clase estática o en la clase de usuarios

        private void CrearCuenta_Load(object sender, EventArgs e)
        {

        }
    }
}
