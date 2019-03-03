using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abogados_Roldan_Administrador.Clases
{
    public class Usuario
    {
        /// <summary>
        /// Id del usuario.
        /// </summary>
        public int Id { get; private set; }
        /// <summary>
        /// Nombre de usuario del usuario.
        /// </summary>
        public String NombreUsuario { get; private set; }
        /// <summary>
        /// Estado del usuario(puede ser Activo o Inactivo).
        /// </summary>
        public String Estado { get; private set; }
        /// <summary>
        /// Fecha en la que dio de alta el usuario
        /// </summary>
        public DateTime FechaAlta { get; private set; }
        /// <summary>
        /// Define el tipo de usuario.
        /// </summary>
        public String Tipo { get; set; }
        /// <summary>
        /// Obtiene de la base de datos el usuario que corresponde al ID
        /// </summary>
        /// <param name="id">ID del usuario a buscar</param>
        public Usuario(int id)
        {

        }
    }
}
