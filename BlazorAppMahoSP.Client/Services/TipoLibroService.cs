using BlazorAppMahoSP.Entities;
namespace BlazorAppMahoSP.Client.Services
{
    public class TipoLibroService
    {
        private List<TipoLibroCLS> lista;
        public TipoLibroService()
        {
            lista = new List<TipoLibroCLS>();
            lista.Add(new TipoLibroCLS { IdTipoLibro = 1, NombreTipoLibro = "Novela" });
            lista.Add(new TipoLibroCLS { IdTipoLibro = 2, NombreTipoLibro = "Crónica" });
        }
        public List<TipoLibroCLS> ListarTipoLibros()
        {
            return lista;
        }
        public int obtenerIdTipoLibro(string nombreTipoLibro)
        {
            var objeto = lista.Where(p => p.NombreTipoLibro == nombreTipoLibro).FirstOrDefault();
            if (objeto != null)
            {
                return objeto.IdTipoLibro;
            }
            else
            {
                return 0;
            }
        }
        public string obtenerNombreTipoLibro(int idTipoLibro)
        {
            var objeto = lista.Where(p => p.IdTipoLibro == idTipoLibro).FirstOrDefault();
            if (objeto == null)
            {
                return "";
            }
            else
            {
                return objeto.NombreTipoLibro;
            }
        }
    }
}
