using System.ComponentModel.DataAnnotations;
namespace AppCapitulo12.Models
{
    [MetadataType(typeof(CadastroMetadata))]
    public partial class Cadastro { }

    public class CadastroMetadata
    {
        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Digite no mínimo 1 e no máximo 50 caracteres.")]
        [RegularExpression(@"^[a-zá-úA-ZÁ-Ú0-9_üÜ'\s]+$", ErrorMessage = "O nome contém caracteres inválidos. Use a-zá-úA-ZÁ-Ú0-9_üÜ e espaços")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Cpf é obrigatório.")]
        [RegularExpression(@"^\d{2}.\d{2}.\d{2}.\d{3}-\d{2}?$", ErrorMessage = "Cpf inválido. Ex.: 00.00.00.000-00")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "O endereço é obrigatório.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Digite no máximo 100 caracteres.")]
        [RegularExpression(@"^[a-zá-úA-ZÁ-Ú0-9_üÜ'\.\s]+$", ErrorMessage = "O campo Endereço contém caracteres inválidos. Use a-zá-úA-ZÁ-Ú0-9_üÜ. e espaços")]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "O campo Cep é obrigatório.")]
        [RegularExpression(@"^\d{5}-\d{3}?$", ErrorMessage = "Cep inválido.")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "O campo Cidade é obrigatório.")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Digite no máximo 50 caracteres.")]
        [RegularExpression(@"^[a-zá-úA-ZÁ-Ú0-9_üÜ'\.\s]+$", ErrorMessage = "O campo Cidade contém caracteres inválidos. Use a-zá-úA-ZÁ-Ú0-9_üÜ. e espaços")]
        public string Cidade { get; set; }

        [RegularExpression("^[a-zA-Z]{2}$", ErrorMessage = "O campo Estado contém caracteres inválidos")]
        public string Estado { get; set; }
    }
}
