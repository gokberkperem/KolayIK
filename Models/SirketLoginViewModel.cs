using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class SirketLoginViewModel
    {
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
    }
}
