using Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Classes
{
    public class SirketYoneticisi
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Ad { get; set; }
        [Required]
        public string Soyad { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Gorevi { get; set; }
        [Required]
        public string Parola { get; set; }
        [Required]
        public string ParolaTekrari { get; set; }
        [Required]
        public DateTime DogumTarihi { get; set; }
        [Required]
        public bool AktifMi { get; set; }
        [ForeignKey("Sirket")]
        public int SirketId { get; set; }
        [ForeignKey("Yorum")]
        public int YorumId { get; set; }

        // Todo : Şirket Yönetici fotoğraf tutulaacak
        [Required]
        public virtual Sirket Sirketi { get; set; } 
        public virtual Yorum Yorumu { get; set; }
        [Required]
        public virtual UyelikPaketTipi UyelikPaketTipi { get; set; }
    }
}
