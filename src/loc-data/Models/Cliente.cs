using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loc_data.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }

        [Required(ErrorMessage = "o Cpf deve ser informado!")]
        [Display(Name = "CPF")]
        public string Cpf { get; set; }

    }
}