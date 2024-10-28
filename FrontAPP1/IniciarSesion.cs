using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;


namespace FrontAPP1
{
    public partial class IniciarSesion : Form
    {
        public IniciarSesion()
        {
            InitializeComponent();

        }
        // En la parte superior de tu archivo, donde declares variables
        private string connectionString = "Server=localhost;Database=Arspace;User Id=root;Password=CONTRASENIA123;";

        private int? VerificarCredenciales(string usuario, string contrasenia)
        {
            int? userId = null;

            // Aquí realizarías la conexión a la base de datos y verificar las credenciales
            string query = "SELECT UserId FROM Usuarios WHERE Username = @Username AND Password = @Password";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", usuario);
                cmd.Parameters.AddWithValue("@Password", contrasenia); // Asegúrate de manejar la encriptación de la contraseña

                conn.Open();
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    userId = Convert.ToInt32(result); // Convertir el resultado a un entero
                }
            }

            return userId;
        }

        public static class UsuarioSesion
        {
            public static int? UserID { get; set; }
        }

        private void BtnInicioSesion_Click(object sender, EventArgs e)
{
            string usuario = txtUsuarioLog.Text; // Suponiendo que 'usuarioIS' es el TextBox para el nombre de usuario
            string contrasenia = txtContraseniaLog.Text; // Suponiendo que 'contraseniaIS' es el TextBox para la contraseña

            // Lógica para verificar las credenciales
            var userId = VerificarCredenciales(usuario, contrasenia); // Este método debe devolver el ID del usuario si las credenciales son correctas

            if (userId != null) // Si las credenciales son válidas
            {
                // Almacenar el ID del usuario en la variable estática
                UsuarioSesion.UserID = userId;
            }

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
            if (contraseniaIngresada.Length < 5 || contraseniaIngresada.Length > 15 || !contraseniaIngresada.Any(char.IsDigit))
            {
                MessageBox.Show("La contraseña debe tener entre 5 y 15 caracteres y contener al menos un número.");
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
