using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Classes

{
    public class Sirket
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Ad { get; set; }
        [Required]
        public string SGKSicilNo { get; set; }
        
        public string Adres { get; set; }
        [Required]
        public string Telefon { get; set; }
        public string WebSitesi { get; set; }
        [Required]
        public string Email { get; set; }
        public string Parola { get; set; }
        public string ParolaTekrari { get; set; }
        public DateTime? KurulusTarihi { get; set; }

        // Todo : Logo nasıl tutulacak

        public virtual SirketYoneticisi Yonetici { get; set; }
        [Required]
        public virtual List<Personel> Personeller { get; set; }
        public virtual UyelikPaketi UyelikPaketi { get; set; }
    }
}
