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
    public partial class Chats : Form
    {
        // Diccionario para almacenar las conversaciones con cada usuario.
        private Dictionary<string, List<string>> conversaciones = new Dictionary<string, List<string>>();
        public Chats()
        {
            InitializeComponent();
            // Asigna el evento de selección de usuario en lstConversaciones.
            lstConversaciones.SelectedIndexChanged += LstConversaciones_SelectedIndexChanged;
            btnEnviar.Click += BtnEnviar_Click;
           // btnNuevaConversacion.Click += BtnNuevaConversacion_Click;
        }

        private void LstConversaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlMensajes.Controls.Clear();
            string usuarioSeleccionado = lstConversaciones.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(usuarioSeleccionado) && conversaciones.ContainsKey(usuarioSeleccionado))
            {
                foreach (string mensaje in conversaciones[usuarioSeleccionado])
                {
                    MostrarMensaje(mensaje, mensaje.StartsWith("Yo:"));
                }
            }
        }

        // Método para enviar un mensaje.
        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            string mensaje = txtEscribirMensaje.Text;
            string usuarioSeleccionado = lstConversaciones.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(mensaje) && !string.IsNullOrEmpty(usuarioSeleccionado))
            {
                string mensajeEnviado = "Yo: " + mensaje;
                if (!conversaciones.ContainsKey(usuarioSeleccionado))
                    conversaciones[usuarioSeleccionado] = new List<string>();

                // Agrega el mensaje a la conversación y lo muestra en el panel.
                conversaciones[usuarioSeleccionado].Add(mensajeEnviado);
                MostrarMensaje(mensajeEnviado, true);

                // Aquí puedes agregar el envío al servidor.
                txtEscribirMensaje.Clear();
            }
        }

        // Método para mostrar el mensaje en el panel con la alineación correspondiente.
        private void MostrarMensaje(string mensaje, bool esEnviado)
        {
            Label lblMensaje = new Label
            {
                Text = mensaje,
                AutoSize = true,
                Padding = new Padding(10),
                Margin = new Padding(5),
                BackColor = esEnviado ? Color.LightBlue : Color.LightGray,
                TextAlign = ContentAlignment.MiddleRight,
                Dock = esEnviado ? DockStyle.Right : DockStyle.Left
            };

            pnlMensajes.Controls.Add(lblMensaje);
            pnlMensajes.ScrollControlIntoView(lblMensaje);
        }

        // Método para crear una nueva conversación.
        private void BtnNuevaConversacion_Click(object sender, EventArgs e)
        {
            string nombreUsuario = Prompt.ShowDialog("Ingrese el nombre del usuario:", "Nueva Conversación");

            if (!string.IsNullOrEmpty(nombreUsuario))
            {
                if (!conversaciones.ContainsKey(nombreUsuario))
              
               {
                   conversaciones[nombreUsuario] = new List<string>();
                   lstConversaciones.Items.Add(nombreUsuario);
                }
                else
               {
                   MessageBox.Show("La conversación ya existe.");
               }
            }
        }
        public static class Prompt
        {
            public static string ShowDialog(string text, string caption)
            {
                Form prompt = new Form
                {
                    Width = 300,
                    Height = 200,
                    Text = caption
                };

                Label lblText = new Label { Left = 20, Top = 20, Text = text, AutoSize = true };
                TextBox txtInput = new TextBox { Left = 20, Top = 50, Width = 250 };
                Button btnOk = new Button { Text = "OK", Left = 170, Top = 80, Width = 100 };

                btnOk.Click += (sender, e) => { prompt.Close(); };
                prompt.Controls.Add(lblText);
                prompt.Controls.Add(txtInput);
                prompt.Controls.Add(btnOk);
                prompt.AcceptButton = btnOk;

                prompt.ShowDialog();
                return txtInput.Text;
            }
        }
    }
}




