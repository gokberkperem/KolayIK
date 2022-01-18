using Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Classes
{
    public class Izin
    {   
        [Key]
        public int Id { get; set; }

        [Required]
        public IzinTurleri Tur { get; set; }
        [Required]
        public DateTime BaslangicTarihi { get; set; }
        [Required]
        public DateTime BitisTarihi { get; set; }
        [Required]
        public IzinDurumu Durumu { get; set; }
        [Required]
        public Personel Personel { get; set; }
        [Required]
        public Odeme Odeme { get; set; }
    }
}
