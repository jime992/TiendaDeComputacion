using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Tintas : Productos
    {
        public Tintas(string marca, string color, int precio = 100) : base(marca, color, precio)
        {
        }

        public int getPrecio()
        {
            return Precio;
        }
    }
}
