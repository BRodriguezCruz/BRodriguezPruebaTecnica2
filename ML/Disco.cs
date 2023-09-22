using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Disco
    {
        public int IdDisco { get; set; }
        public string Titulo { get; set; }
        public string GeneroMusical { get; set; }
        public double? Duracion { get; set; }
        public DateTime Anio { get; set; }
        public string Distribuidora { get; set; }
        public int? Ventas { get; set; }
        public string Disponibilidad { get; set; }
        public ML.Artista Artsita { get; set; }

    }
}
