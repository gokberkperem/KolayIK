using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class SirketRegisterViewModel
    {

        [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
        [StringLength(50, ErrorMessage = "{0} alanı en fazla {1} kararkter olabilir")]
        [Display(Prompt ="Şirket Adı Giriniz")]
        public string Ad { get; set; }
        [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
        [StringLength(50, ErrorMessage = "{0} alanı en fazla {1} kararkter olabilir")]
        [Display(Name = "SGK SİCİL NO", Prompt = "Şirket SGK No Giriniz")]
        public string SGKSicilNo { get; set; }

        [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
        [StringLength(50, ErrorMessage = "{0} alanı en fazla {1} kararkter olabilir")]
        [DataType(DataType.PhoneNumber)]
        [Display(Prompt = "Şirket Telefon Numarasınız Giriniz")]
        public string Telefon { get; set; }
        [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-mail adresi girin")]
        [DataType(DataType.EmailAddress)]
        [Display(Prompt = "Şirket Mailini Giriniz")]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
        [StringLength(12, MinimumLength = 6, ErrorMessage = "{0} en az {2} en fazla {1} karakterden oluşmalıdır")]
        [DataType(DataType.Password)]
        [Display(Prompt = "Parolanızı Giriniz")]
        public string Parola { get; set; }

        [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
        [StringLength(12, MinimumLength = 6, ErrorMessage = "{0} en az {2} en fazla {1} karakterden oluşmalıdır")]
        [DataType(DataType.Password)]
        [Compare(nameof(Parola), ErrorMessage = "{0} alanı ile {1} alanı aynı olmalıdır")]
        [Display(Name ="Parola Tekrarı", Prompt = "Parola Tekrarını Giriniz")]
        public string ParolaTekrari { get; set; }

    }
}
