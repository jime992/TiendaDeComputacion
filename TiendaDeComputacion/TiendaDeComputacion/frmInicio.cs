using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TiendaDeComputacion
{
    public partial class frmInicio : Form
    {
        public string labelProducto;
        public frmInicio()
        {
            InitializeComponent();
        }


        private void NuevoPresupuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNuevoPresupuesto frmNuevoPresupuesto = new frmNuevoPresupuesto();
            frmNuevoPresupuesto.Show();
        }


        private void ListaDeImpresorasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CargarNuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void NuevaImpresoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelProducto = "Nueva Impresora";
            frmNuevoProducto frmNuevoProducto = new frmNuevoProducto(labelProducto);
            frmNuevoProducto.Show();
            this.Hide();

            
        }

        private void NuevaNotebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelProducto = "Nueva Notebook";
            frmNuevoProducto frmNuevoProducto = new frmNuevoProducto(labelProducto);
            frmNuevoProducto.Show();
            this.Hide();
        }

        private void ListaDeTintasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelProducto = "Nueva Tinta";
            frmNuevoProducto frmNuevoProducto = new frmNuevoProducto(labelProducto);
            frmNuevoProducto.Show();
            this.Hide();
        }
    }
}
