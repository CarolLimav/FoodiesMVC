using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodiesMVC.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O Nome do Lanche deve ser informado")]
        [Display(Name = "Nome do Lanche")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {1}")]
        public String Nome { get; set; }
        [Required(ErrorMessage = "O Preço deve ser informado")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage = "O Preço deve estar entre {0} e {1}")]
        public double Preco { get; set; }
        [Required(ErrorMessage = "A descrição deve ser informado")]
        [Display(Name = "Descrição")]
        [MinLength(20, ErrorMessage = "A descrição deve ter no mínimo 20 caracteres")]
        [MaxLength(250, ErrorMessage = "A descrição deve ter no máximo 250 caracteres")]
        public String Descricao { get; set; }

        [Required(ErrorMessage ="O campo é obrigatório")]
        public int TempoDePreparo { get; set; }
        [Display(Name = "É Preferido?")]
        public bool IsFavorite { get; set; }
        [Display(Name = "Estoque")]
        public bool Estoque { get; set; }
        [Display(Name = "Caminho da Imagem Normal")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "O {0} deve ter no máximo {1}")]
        public String ImageAsset { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
