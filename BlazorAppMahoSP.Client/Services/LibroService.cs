using BlazorAppMahoSP.Entities;
using System.ComponentModel;

namespace BlazorAppMahoSP.Client.Services
{

    public class LibroService
    {
        private List<LibroListCLS> lista;
        private TipoLibroService tipoLibroService;
        public LibroService(TipoLibroService _tipoLibroService)
        {
            tipoLibroService=_tipoLibroService;
            lista = new List<LibroListCLS>();
            lista.Add(new LibroListCLS { Id = 1, Titulo = "1Q84", NombreTipoLibro="Novela" });
            lista.Add(new LibroListCLS { Id = 2, Titulo = "Sisifo", NombreTipoLibro = "Cuento" });
        }
        public List<LibroListCLS> listarLibros()
        {
            return lista;
        }
        public int obtenerIdTipoLibro(string nombreTipoLibro)
        {
            var objecto=lista.Where(p => p.NombreTipoLibro == nombreTipoLibro).FirstOrDefault();
            if(objecto!=null)
            {
                return 0;
            }
            else
            {
                return objecto.Id;
            }
        }
        public void eliminarLibro(int id)
        {
            var listaQueQueda = lista.Where(p => p.Id != id).ToList();
            lista = listaQueQueda;
        }
        public LibroFormCLS recuperarLibroPorId(int idLibro)
        {
            var objecto = lista.Where(p => p.Id == idLibro).FirstOrDefault();
            if (objecto != null)
            {
                return new LibroFormCLS
                {
                    Id = objecto.Id,
                    Titulo = objecto.Titulo,
                    Resumen = objecto.Resumen,
                    IdTipoLibro = tipoLibroService.obtenerIdTipoLibro(objecto.NombreTipoLibro)
                };
            }
            else
            {
                return new LibroFormCLS();
            }
        }
        public void guardarLibro(LibroFormCLS oLibroFormClS)
        {
            int idLibro=lista.Select(p => p.Id).Max() + 1;
            lista.Add(new LibroListCLS
            {
                Id = idLibro,
                Titulo = oLibroFormClS.Titulo,
                NombreTipoLibro = tipoLibroService.obtenerNombreTipoLibro(oLibroFormClS.IdTipoLibro)
            });
        }
    }

}
