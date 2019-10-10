using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Presupuesto
    {
        public IList<Tintas> Tintas;
        public IList<Notebooks> Notebooks;
        public IList<Impresoras> Impresoras;
        public int PrecioTotal { get; set; }
        public void calcPrecioTotal() {
            int preciototal = 0;

            /*foreach ( int tintas in this.Tintas){
                preciototal = tintas.getPrecio() + preciototal;
            }*/
        }



    }

}

