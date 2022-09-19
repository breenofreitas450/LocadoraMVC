using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace loc_data.Models
{
    [Table("Filme")]
    public class Filme
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "o nome do filme deve ser informado!")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        public string Categoria { get; set; }

    }
}
