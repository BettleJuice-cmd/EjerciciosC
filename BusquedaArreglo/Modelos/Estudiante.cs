using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusquedaArreglo.Modelos
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public override string ToString()
        {
            return $" ID: {Id} - Nombre: {Nombre}";
        }
    }
}
