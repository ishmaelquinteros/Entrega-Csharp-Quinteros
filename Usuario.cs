using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_Coderhouse_Quinteros
{
    public class Usuario
    {
        #region Atributos
        private int ID;
        private string Nombre;
        private string Apellido;
        private string NombreUsuario;
        private string Contrasena;
        private string Mail;
        #endregion

        #region Constructor
        public Usuario()
        {
            this.ID = 0;
            this.Nombre = string.Empty;
            this.Apellido = string.Empty;
            this.NombreUsuario = string.Empty;
            this.Contrasena = string.Empty;
            this.Mail = string.Empty;
        }

        public Usuario(int pId, string pNombre, string pApellido, string pNombreUsuario, string pContrasena, string pMail)
        {
            this.ID = pId;
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.NombreUsuario = pNombreUsuario;
            this.Contrasena = pContrasena;
            this.Mail = pMail;
        }
        #endregion
        #region Setter y Getter
        public int UsuarioID
        {
            get { return ID; }
        }
        public string UsuarioNombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public string UsuarioApellido
        {   get { return Apellido; } 
            set { Apellido = value; } 
        }
        
        public string UsuarioNombreUsuario
        {
            get { return NombreUsuario; }
            set { NombreUsuario = value; }
        }
        public string UsuarioContrasena
        {
            get { return Contrasena; }
            set { Contrasena = value; }
        }
        public string UsuarioMail
        {
            get { return Mail; }
            set { Mail = value; }
        }
        #endregion


    }


}
