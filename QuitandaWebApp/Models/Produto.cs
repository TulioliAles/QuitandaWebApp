using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuitandaWebApp.Models
{
    public class Produto
    {
        [Key]
        public int IdProduto { get; set; }

        [Required(ErrorMessage = "O campo {0} é de preechimento obrigatório.")]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é de preechimento obrigatório.")]
        [MaxLength(1000)]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo {0} é de preechimento obrigatório.")]
        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "O campo {0} é de preechimento obrigatório.")]
        public int Estoque { get; set; }
    }
}
