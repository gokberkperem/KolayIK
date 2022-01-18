using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Classes
{
    public class Yorum
    {
        [Key]
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Detay { get; set; }
        public DateTime? YazilmaTarihi { get; set; }
        [Required]
        public virtual SirketYoneticisi SirketYoneticisi { get; set; }
    }
}
