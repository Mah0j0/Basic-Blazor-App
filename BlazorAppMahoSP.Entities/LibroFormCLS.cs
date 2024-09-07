using System.ComponentModel.DataAnnotations;

namespace BlazorAppMahoSP.Entities
{
    public class LibroFormCLS
    {
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "El campo 'Id' no puede ser menor a 0")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo 'Titulo' es requerido")]
        [MaxLength(50, ErrorMessage = "El campo 'Titulo' no puede tener más de 50 caracteres")]
        public string Titulo { get; set; } = null!;

        [Required(ErrorMessage = "El campo 'Resumen' es requerido")]
        [MaxLength(2000, ErrorMessage = "El campo 'Resumen' no puede tener más de 2000 caracteres")]
        [MinLength(50, ErrorMessage = "El campo 'Resumen' no puede tener menos de 50 caracteres")]
        public string Resumen { get; set; } = null!;
        [Range(1, int.MaxValue, ErrorMessage = "El campo 'Tipo del libro' no puede estar vacío")]
        public int IdTipoLibro { get; set; }

    }
}
