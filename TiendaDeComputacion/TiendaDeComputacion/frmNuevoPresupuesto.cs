﻿using System;
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
    public partial class frmNuevoPresupuesto : Form
    {
        public frmNuevoPresupuesto()
        {
            InitializeComponent();
                

        }

        private void FrmNuevoPresupuesto_Load(object sender, EventArgs e)
        {

        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInicio frmInicio = new frmInicio();
            frmInicio.Show();
            
        }
    }
}
