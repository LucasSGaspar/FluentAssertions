using System.ComponentModel.DataAnnotations;

namespace FluenteValidations.ViewModels
{
    public class TagViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(30, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 5)]
        public string Nome { get; set; }

        public string Observacao { get; set; }
    }
}
