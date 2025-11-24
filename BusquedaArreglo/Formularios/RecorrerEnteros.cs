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
    public partial class RecorrerEnteros : Form
    {

        List<int> enteros = new List<int>();
        public RecorrerEnteros()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lbNumeros.Items.Clear();
            int.TryParse(tbNumero.Text, out int numero);
            enteros.Add(numero);
            foreach(int i in enteros)
            {
                lbNumeros.Items.Add(i);

            }
            tbNumero.Clear();
            tbNumero.Focus();

        }

       
        public void EncontrarMaxMin(List<int> numeros, out int max, out int min, out int iteraciones)
        {
            
            if (numeros == null || numeros.Count == 0)
            {
                max = 0;
                min = 0;
                iteraciones = 0;
                return;
            }

            
            max = numeros[0];
            min = numeros[0];
            iteraciones = 0;

           
            foreach (int numero in numeros)
            {
                iteraciones++; 

               
                if (numero > max)
                {
                    max = numero;
                }

                
                if (numero < min)
                {
                    min = numero;
                }
            }
        }

        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            if (enteros.Count == 0)
            {
                MessageBox.Show("Primero genera la lista.");
                return;
            }

            int valorMaximo, valorMinimo, totalVueltas;

            EncontrarMaxMin(enteros, out valorMaximo, out valorMinimo, out totalVueltas);

            lblMax.Text += valorMaximo;
            lblMin.Text += valorMinimo;
            lblIteraciones.Text += totalVueltas;
        }
    }
}
