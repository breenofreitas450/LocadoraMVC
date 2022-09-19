using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loc_data.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Usuario deve ser informado!")]
        [Display(Name = "Usuario")]
        public string Login { get; set; }
        [Required(ErrorMessage = "A senha deve ser informada!")]
        [Display(Name = "Senha")]
        public string Senha { get; set; }   
        public string Nome { get; set; }
    }
}
