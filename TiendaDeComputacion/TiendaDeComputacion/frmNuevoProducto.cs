using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaDeComputacion
{
    public partial class frmNuevoProducto : Form
    {
        
        public frmNuevoProducto(string labelproducto)
        {
            InitializeComponent();
            this.lblNuevo.Text = labelproducto;
        }


        private void TxtPrecioImp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }



        private void FrmNuevoProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmInicio frmInicio = new frmInicio();
            frmInicio.Show();
        }

        private void Btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmNuevoProducto_Load(object sender, EventArgs e)
        {
            ConexionBD conexion = new ConexionBD();
            conexion.abrir();
        }
    }
}
