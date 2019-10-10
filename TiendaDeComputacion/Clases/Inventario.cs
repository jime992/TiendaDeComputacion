using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Inventario
    {
        public int StockTintas;
        public int StockNotebooks;
        public int StockImpresoras;
        public IList<Tintas> Tintas;
        public IList<Notebooks> Notebooks;
        public IList<Impresoras> Impresoras;

        public void pushTinta(Tintas tinta)
        {

            if (this.Tintas == null)
            {
                this.Tintas = new List<Tintas>();
            }
            this.Tintas.Add(tinta);
        }

        public void pushImpresora(Impresoras impresora)
        {
            if (this.Impresoras == null)
            {
                this.Impresoras = new List<Impresoras>();
            }
            this.Impresoras.Add(impresora);
        }

        public void pushNotebook(Notebooks notebook)
        {
            if (this.Notebooks == null)
            {
                this.Notebooks = new List<Notebooks>();
            }
            this.Notebooks.Add(notebook);
        }
        public void setStockTintas()
        {
            StockTintas = 0;
            if (this.Tintas != null)
                foreach (var stock in this.Tintas)
                    StockTintas++;
        }

        public void setStockImpresoras()
        {
            StockImpresoras = 0;
            if (this.Impresoras != null)
                foreach (var stock in this.Impresoras)
                    StockTintas++;
        }
        public void setStockNotebooks()
        {
            StockImpresoras = 0;
            if (this.Impresoras != null)
                foreach (var stock in this.Notebooks)
                    StockNotebooks++;
        }
    }
}
