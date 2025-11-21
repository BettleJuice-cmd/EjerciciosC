using BusquedaArreglo.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusquedaArreglo
{
    public partial class INICIO : Form
    {
        public INICIO()
        {
            InitializeComponent();
        }

        private void aleatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            new Aleatorio().Show();
        }

        private void busquedaListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BusquedaBinaria().Show();
        }
    }
}
