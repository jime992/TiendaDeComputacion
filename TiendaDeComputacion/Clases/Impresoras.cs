using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Impresoras : Productos
    {
        public Impresoras(string marca, string color, int precio = 20000) : base(marca, color, precio)
        {
        }
    }
}
