using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FrontAPP1
{
    public static class DatosUsuario
{
    // Propiedad para almacenar el nombre de usuario
    public static string NombreUsuario { get; set; }

    // Propiedad para almacenar la descripción del perfil
    public static string DescripcionPerfil { get; set; }

    // Propiedad para almacenar la imagen de la foto de perfil
    public static Image FotoPerfil { get; set; }

    // Propiedad para almacenar la preferencia de contenido del usuario
    public static string PreferenciaContenido { get; set; }
}
}