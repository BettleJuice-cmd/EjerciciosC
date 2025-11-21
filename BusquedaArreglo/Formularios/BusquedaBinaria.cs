using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusquedaArreglo.Formularios
{
    public partial class BusquedaBinaria : Form
    {
        Random xd = new Random();
        List<int> aleatorios = new List<int>();
        public BusquedaBinaria()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 30; i++)
            {
                aleatorios[i] += xd.Next(1, 25);
            }

        }
    }
}
