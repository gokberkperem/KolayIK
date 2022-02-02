using System;
using System.ComponentModel.DataAnnotations;

namespace ViewModels
{
    public class PersonelRegisterViewModel
    {
        [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
        [StringLength(50, ErrorMessage = "{0} alanı en fazla {1} kararkter olabilir")]
        public string Ad { get; set; }
        [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
        [StringLength(50, ErrorMessage = "{0} alanı en fazla {1} kararkter olabilir")]
        public string Soyad { get; set; }
        [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-mail adresi girin")]
        public string Email { get; set; }
        
        [Required]
        // todo günümüzden ilerisini seçememeli 
        public DateTime IseAlimTarihi { get; set; }
        [Required]
        public DateTime DogumTarihi { get; set; }
        [Required]
        public string Telefon { get; set; }
        [Required]
        public string Parola { get; set; }
        [Required]
        public string ParolaTekrari { get; set; }
        
    }


}
