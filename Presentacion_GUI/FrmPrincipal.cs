﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion_GUI
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnFamiliar_Click(object sender, EventArgs e)
        {
            new FrmFamiliar().ShowDialog();
        }

        private void btnEmprearial_Click(object sender, EventArgs e)
        {
            new FrmEmpresarial().ShowDialog();
        }
    }
}
