using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loc_data.Models
{
    [Table("Locacao")]
    public class Locacao
    {
        [Key]
        public int Id { get; set; }
        public string IdLocacao { get; set; }
        public DateTime DataCriacao { get; set; }
        public Filme Filme { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
