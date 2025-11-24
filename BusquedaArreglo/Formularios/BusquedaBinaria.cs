using System;
using System.Collections.Generic;
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
                int number = xd.Next(1, 45);

                aleatorios.Add(number);
                aleatorios.Sort();
            }
            
            lbNumeros.Items.Clear();
            foreach (int i in aleatorios)
            {
                lbNumeros.Items.Add(i);
            }

        }

        private void BusquedaBinaria_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if(aleatorios == null) //Aquí el programa observa si la lista se encuentra vacía
            {
                MessageBox.Show("Necesitas crear la lista primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            aleatorios.Sort();

            foreach (int i in aleatorios)
            {
                int.TryParse(tbNumero.Text, out int number);

                int posicion = Busqueda(aleatorios, number, lbNumeros);

                if(posicion != -1)
                {
                    MessageBox.Show("NUMERO ENCONTRADO DENTRO DE LA LISTA", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
                else
                {
                    MessageBox.Show("EL NUMERO NO FUE ENCONTRADO DENTRO DE LA LISTA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }

            }
            tbNumero.Clear();
            tbNumero.Focus();


        }
        public int Busqueda(List<int> lista, int objetivo, ListBox pantalla)
        {
            pantalla.Items.Clear(); 
            pantalla.Items.Add($"Iniciando búsqueda del número: {objetivo}");
            pantalla.Items.Add("------------------------------------------------");

            int izquierda = 0;
            int derecha = lista.Count - 1;
            int paso = 1;

            while (izquierda <= derecha)
            {
                int medio = (izquierda + derecha) / 2;
                int valorMedio = lista[medio];

                
                pantalla.Items.Add($"PASO {paso}:");

                
                pantalla.Items.Add($"Rango de búsqueda: índices {izquierda} a {derecha}");

              
                string subListaTexto = "Sub-lista actual: [ ";
                for (int i = izquierda; i <= derecha; i++)
                {
                    
                    if (i == medio) subListaTexto += $"*{lista[i]}* ";
                    else subListaTexto += $"{lista[i]} ";
                }
                subListaTexto += "]";
                pantalla.Items.Add(subListaTexto);

               
                pantalla.Items.Add($"Comparando: ¿Es {valorMedio} igual a {objetivo}?");

               
                if (valorMedio == objetivo)
                {
                    pantalla.Items.Add("EL NUMERO FUE ENCONTRADO");
                    pantalla.Items.Add("------------------------------------------------");
                    return medio;
                }

                if (valorMedio < objetivo)
                {
                    pantalla.Items.Add($"No. {valorMedio} es MENOR que {objetivo}.");
                    pantalla.Items.Add("Descartamos la mitad izquierda. Vamos a la derecha.");
                    izquierda = medio + 1;
                }
                else
                {
                    pantalla.Items.Add($"No. {valorMedio} es MAYOR que {objetivo}.");
                    pantalla.Items.Add("Descartamos la mitad derecha. Vamos a la izquierda.");
                    derecha = medio - 1;
                }

                pantalla.Items.Add(""); 
                paso++;
            }

            pantalla.Items.Add("Terminó el rango. El número no existe.");
            return -1;
        }
    }
}
