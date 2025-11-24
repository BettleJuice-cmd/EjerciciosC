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
    public partial class Matriz2D : Form
    {
        int[,] tablero = new int[10, 10];
        Random generador = new Random();
        public Matriz2D()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbNumero.Text, out int objetivo))
            {
                MessageBox.Show("Ingresa un número válido.");
                return;
            }

            bool encontrado = false;
            string posiciones = "";
            int contador = 0;

            
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    
                    if (tablero[i, j] == objetivo)
                    {
                        encontrado = true;
                        contador++;
                        
                        posiciones += $"[{i},{j}] ";
                    }
                }
            }
           

            if (encontrado)
            {
                MessageBox.Show($"¡Encontrado {contador} veces!\nEn las posiciones: {posiciones}");
            }
            else
            {
                MessageBox.Show("El número no está en la matriz.");
            }
        }

        

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            rtbMatriz.Clear();
            string contenidoVisual = "";

            
            for (int i = 0; i < 10; i++)
            {
                
                for (int j = 0; j < 10; j++)
                {
                    
                    tablero[i, j] = generador.Next(1, 101);

                    
                    contenidoVisual += tablero[i, j] + "\t";
                }
                
                contenidoVisual += "\n";
            }

            rtbMatriz.Text = contenidoVisual;
        }
    }
}
