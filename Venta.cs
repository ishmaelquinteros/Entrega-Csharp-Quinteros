using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_Coderhouse_Quinteros
{
    public class Venta
    {
        private int ID;
        private string Comentarios;
        private int IdUsuario;

        public Venta()
        {
            this.ID = 0;
            this.Comentarios = string.Empty;
            this.IdUsuario = 0;
        }
        public Venta(int pId, string pComentarios, int pIdUsuario)
        {
            ID = pId;
            Comentarios = pComentarios;
            IdUsuario = pIdUsuario;
        }

        public int VentasId
        {
            get { return this.ID; }
        }
        public string VentasComentarios
        {
            get { return this.Comentarios; }
            set { this.Comentarios = value; }
        }
        public int VentasIdUsuario
        {
            get { return this.IdUsuario; }
            set { this.IdUsuario = value; }
        }

    }
}


