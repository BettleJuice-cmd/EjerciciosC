using BusquedaArreglo.Modelos;
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
    public partial class BusquedaEstudiante : Form
    {
        List<Estudiante> estudiantes = new List<Estudiante>();
        public BusquedaEstudiante()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbId.Text)|| string.IsNullOrEmpty(tbNombre.Text))
            {
                MessageBox.Show("TIENES QUE LLENAR LAS CASILLAS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            if (!int.TryParse(tbId.Text, out int idEstudiante))
            {
                MessageBox.Show("El ID debe ser un número válido.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            
                lbEstudiantes.Items.Clear();
                Estudiante estudiante = new Estudiante();
                estudiante.Id = idEstudiante;
                estudiante.Nombre = tbNombre.Text;
                estudiantes.Add(estudiante);
                foreach (Estudiante numEst in estudiantes)
                {
                    lbEstudiantes.Items.Add(numEst);

                }
            ActualizarListBox();
            tbId.Clear();
            tbNombre.Clear();
        }

        private void ActualizarListBox()
        {
            lbEstudiantes.Items.Clear();
            foreach (Estudiante est in estudiantes)
            {
                lbEstudiantes.Items.Add(est);
            }
        }
        private void btnId_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbBuscarId.Text);

            Estudiante resultado = BuscarPorId_Lineal(id);

            if (resultado != null)
            {
                MessageBox.Show($"Encontrado: {resultado.Nombre}");
            }
            else
            {
                MessageBox.Show("Estudiante no existe.");
            }

        }
       
        
        public Estudiante BuscarPorId_Lineal(int idBuscado)
        {

            foreach (Estudiante est in estudiantes)
            {

                if (est.Id == idBuscado)
                {
                    return est;
                }
            }

            return null;
        }

        public Estudiante BuscarPorNombre_Binaria(string nombreBuscado)
        {
            int izquierda = 0;
            int derecha = estudiantes.Count - 1;

            while (izquierda <= derecha)
            {
                int medio = (izquierda + derecha) / 2;
                Estudiante estudianteMedio = estudiantes[medio];

               
                int comparacion = estudianteMedio.Nombre.CompareTo(nombreBuscado);

                if (comparacion == 0) 
                {
                    return estudianteMedio; 
                }

                if (comparacion < 0) 
                {
                    
                    izquierda = medio + 1;
                }
                else 
                {
                   
                    derecha = medio - 1;
                }
            }

            return null; 
        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbBuscarNombre.Text))
            {
                MessageBox.Show("Ingresa un nombre para buscar.");
                return;
            }
            estudiantes.Sort((x, y) => x.Nombre.CompareTo(y.Nombre));

            ActualizarListBox();

            string nombre = tbBuscarNombre.Text;
            Estudiante resultado = BuscarPorNombre_Binaria(nombre);
            if (resultado != null)
            {
                MessageBox.Show($"Encontrado! ID: {resultado.Id}, Nombre: {resultado.Nombre}");
            }
            else
            {
                MessageBox.Show("No se encontró a nadie con ese nombre.");
            }
        }
    }
}