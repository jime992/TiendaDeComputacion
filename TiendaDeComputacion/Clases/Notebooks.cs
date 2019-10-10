using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Notebooks : Productos
    {
        public Notebooks(string marca, string color, int precio = 50000) : base(marca, color, precio)
        {
        }
    }
}
