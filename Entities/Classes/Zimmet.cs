using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Classes
{
    public class Zimmet
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Ad { get; set; }
        public string Detay { get; set; }
        [Required]
        public virtual Personel Personel { get; set; }
    }
}
