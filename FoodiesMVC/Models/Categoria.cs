using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodiesMVC.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Nome da Categoria")]
        [Required(ErrorMessage = "O campo nome é obrigatório ")]
        [StringLength(100,MinimumLength = 10, ErrorMessage = "O nome precisa ter no máximo 50 caracteres e no mínimo 10 caracteres")]
        public String Nome { get; set; }
        [Required(ErrorMessage = "O campo descrição é obrigatório ")]
        [Display(Name ="Descrição")]
        [MinLength(20, ErrorMessage = "A descrição deve ter no mínimo 20 caracteres")]
        [MaxLength(250, ErrorMessage = "A descrição deve ter no máximo 250 caracteres")]
        public String Descricao { get; set; }
        public List<Lanche> Lanches { get; set; }
    }
}
