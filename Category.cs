using System.ComponentModel.DataAnnotations;
namespace AppCapitulo12.Models
{
    [MetadataType(typeof(CategoryMetadata))]
    public partial class Category { }

    public class CategoryMetadata
    {
        [Required(ErrorMessage = "O nome da categoria é obrigatório.")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Digite no mínimo 3 e no máximo 15 caracteres.")]
        [RegularExpression(@"^[a-zA-Z0-9_\/\s]$", ErrorMessage = "O nome da categoria contém caracteres inválidos. Use a-zA-Z0-9_/ e espaços")]
        [Display(Name = "Categoria")]
        public string CategoryName { get; set; }

        [StringLength(150, MinimumLength = 0, ErrorMessage = "Digite no máximo 150 caracteres.")]
        [RegularExpression(@"^[a-zA-Z0-9_,\.\s]$", ErrorMessage = "A descrição contém caracteres inválidos. Use a-zA-Z0-9_,. e espaços")]
        [Display(Name = "Descrição")]
        public string Description { get; set; }
    }
}
