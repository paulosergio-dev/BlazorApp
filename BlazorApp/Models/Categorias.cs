using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models
{
    public class Categorias
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O título é obrigatório.")]
        [RegularExpression(@"^[a-zA-ZÀ-ÿ\s]*$", ErrorMessage = "O título deve conter apenas letras.")]
        public string Titulo { get; set; } = string.Empty;

        public string Descricao { get; set; } = string.Empty;
    }
}
