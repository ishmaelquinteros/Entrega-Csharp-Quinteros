using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_Coderhouse_Quinteros
{
    public class Producto

    {
        #region Atributos
        private int ID;
        private string Descripcion;
        private double Precio;
        private double PrecioVenta;
        private int Stock;
        private int IdUsuario;
        #endregion

        #region Constructor
        public Producto()
        {
            this.ID = 0;
            this.Descripcion = string.Empty;
            this.Precio = 0;
            this.PrecioVenta = 0;
            this.Stock = 0;
            this.IdUsuario = 0;
        }
        public Producto(int pId, string pDescripcion, double pPrecio, double pPrecioVenta, int pStock, int pIdUsuario)
        {
            this.ID = pId;
            this.Descripcion = pDescripcion;
            this.Precio = pPrecio;
            this.PrecioVenta = pPrecioVenta;
            this.Stock = pStock;
            this.IdUsuario = pIdUsuario;
        }
        #endregion

        #region Setter y Getter
        
        public int ProductoId
        {
            get { return ID; }
        }
        public string ProductoDescripcion
        {
            get { return Descripcion; }
            set { Descripcion = value; }
        }
        public double ProductoPrecio
        {
            get { return Precio; }
            set { Precio = value; }
        }
        public double ProductoPrecioVenta
        {
            get { return PrecioVenta; }
            set { PrecioVenta = value; }
        }
        public int ProductoStock
        {
            get { return Stock; }
            set { Stock = value; }
        }
        public int ProductoIdUsuario
        {
            get { return IdUsuario; }
            set { IdUsuario = value; }
        }
        #endregion
    }
}
