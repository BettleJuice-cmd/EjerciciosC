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
    public partial class Aleatorio : Form
    {
        Random aleatorio = new Random();

        int[] arreglo = new int[20];
        


        public Aleatorio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            

            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = aleatorio.Next(1, 101);
            }
            int.TryParse(tbNumero.Text, out int number);
            bool numeroEncontrado = false;

            foreach (int i in arreglo)
            {
                if(i == number)
                {
                    numeroEncontrado = true;
                    break;
                }
                else
                {
                    break;
                }
               
            }
           
            if(numeroEncontrado == true)
            {
                MessageBox.Show("NUMERO ENCONTRADO");
            }
            else
            {
                MessageBox.Show("El numero no fue encontrado");
            }

            tbNumero.Clear();
            tbNumero.Focus();

        }
    }
}
