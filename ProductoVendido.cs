using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_Coderhouse_Quinteros
{
    public class ProductoVendido
    {
        private int ID;
        private int IdProducto;
        private int Stock;
        private int IdVenta;

        public ProductoVendido(int piD, int pidProducto, int pstock, int pidVenta)
        {
            ID = piD;
            IdProducto = pidProducto;
            Stock = pstock;
            IdVenta = pidVenta;
        }
        public ProductoVendido()
        {
            this.ID = 0;
            this.IdProducto = 0;
            this.Stock = 0;
            this.IdVenta = 0;
        }
    
        public int PVendidoID
        {
            get { return ID; }
        }
        public int PVendidoIdProducto
        {
            get { return IdProducto; }
            set { IdProducto = value; }
        }
        public int PVendidoStock
        {
            get { return Stock; }
            set { Stock = value; }
        }
        public int PVendidoIdVenta
        {
            get { return IdVenta; }
            set { IdVenta = value; }
        }
    }    
    
    }


}
