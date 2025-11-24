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
    public partial class BusquedaTexto : Form
    {
        public BusquedaTexto()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            




        }
        public int ContarPalabrasManual(string parrafo, string palabra)
        {
            
            if (string.IsNullOrEmpty(parrafo) || string.IsNullOrEmpty(palabra))
            {
                return 0;
            }

            if (palabra.Length > parrafo.Length)
            {
                return 0; 
            }

            int contador = 0;

            
            for (int i = 0; i <= parrafo.Length - palabra.Length; i++)
            {
                bool coincide = true;

                
                for (int j = 0; j < palabra.Length; j++)
                {
                    
                    char letraTexto = char.ToLower(parrafo[i + j]);
                    char letraPalabra = char.ToLower(palabra[j]);

                    if (letraTexto != letraPalabra)
                    {
                        coincide = false;
                        break; 
                    }
                }

               
                if (coincide)
                {
                    contador++;
                }
            }

            return contador;
        }

        private void BusquedaTexto_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string parrafo = tbParrafo.Text; 
            string palabra = tbPalabra.Text; 

            int veces = ContarPalabrasManual(parrafo, palabra);

            MessageBox.Show($"La palabra '{palabra}' aparece {veces} veces.", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            tbParrafo.Clear();
            tbPalabra.Clear();

            
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            lblParrafo.Text = "PARRAFO AGREGADO: ";
            string parrafo = tbParrafo.Text;

            lblParrafo.Text += parrafo;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblParrafo.Text = "";
        }
    }
}
