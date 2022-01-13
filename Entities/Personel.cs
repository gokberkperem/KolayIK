using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Personel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Ad { get; set; }

        [Required]
        [StringLength(50)]
        public string Soyad { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string Parola { get; set; }

        public string ParolaTekrari { get; set; }

        public DateTime DogumTarihi { get; set; }

        [Required]
        public DateTime IseAlimTarihi { get; set; }
    }
}
