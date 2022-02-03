using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.Classes
{
    public class Personel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Ad { get; set; }

        [Required]
        public string Soyad { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Telefon { get; set; }

        [Required]
        public string Parola { get; set; }

        [Required]
        public string ParolaTekrari { get; set; }

        [Required]
        public DateTime DogumTarihi { get; set; }

        [Display(Name = "İşe Alım Tarihi")]
        public DateTime IseAlimTarihi { get; set; }
        
        public bool AktifMi { get; set; }

        public virtual List<Izin> Izinler { get; set; } // navigation property
                
        public virtual Sirket Sirketi { get; set; } // navigation property

        public virtual List<Odeme> Odemeler { get; set; } // navigation property

        public virtual List<Zimmet> Zimmetler { get; set; } // navigation property

        public virtual List<Harcama> Harcamalar { get; set; }
    }
}
