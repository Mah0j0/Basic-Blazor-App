using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAppMahoSP.Entities
{
    public class LibroListCLS
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = null!;
        public string Resumen { get; set; }=null!;
        public string NombreTipoLibro { get; set; }=null!;
    }
}
