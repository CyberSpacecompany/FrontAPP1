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
    public partial class PersonalizacionPerfil : Form
    {
        public PersonalizacionPerfil()
        {
            InitializeComponent();
            DatosUsuario.DescripcionPerfil = txtDescripcion.Text;

        }

     

        private void BtnHecho_Click(object sender, EventArgs e)
        {
            // Establecer la descripción del perfil
            string descripcion = txtDescripcion.Text.Trim();

            // Verificar si la descripción no está vacía
            if (!string.IsNullOrEmpty(descripcion))
            {
                lblDescripcion.Text = descripcion; // Actualiza el Label con la descripción
                lblDescripcion.Visible = true; // Asegúrate de que el Label sea visible
                txtDescripcion.Visible = false; // Oculta el TextBox
                BtnHecho.Visible = false; // Oculta el botón "Hecho"
            }
            else
            {
                MessageBox.Show("Por favor, ingresa una descripción válida."); // Mensaje de advertencia
            }


            if (PictureBoxPerfil.Image != null)
            {
                DatosUsuario.FotoPerfil = PictureBoxPerfil.Image;
            }

            // Abrir la ventana de Preferencias
            Preferencias preferencias = new Preferencias();
            preferencias.Show();
            this.Hide(); // Oculta la ventana actual de Personalizacion
        }

        private void LblDescripcion_Click(object sender, EventArgs e)
        {
            txtDescripcion.Text = lblDescripcion.Text; // Rellena el TextBox con la descripción actual
            txtDescripcion.Visible = true; // Muestra el TextBox
            BtnHecho.Visible = true; // Muestra el botón "Hecho"
            lblDescripcion.Visible = false; // Oculta el Label
        }

        private void BtnFotoPerfil_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PictureBoxPerfil.Image = Image.FromFile(openFileDialog.FileName);
                PictureBoxPerfil.SizeMode = PictureBoxSizeMode.Zoom; // Ajusta aquí según la opción que prefieras
            }
        }
        private void PersonalizacionPerfil_Load(object sender, EventArgs e)
        {

        }
    }
}
