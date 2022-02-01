using DataAccess;
using Entities.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace Business
{
    public class UserService
    {
        private UserRepository _userRepository = new UserRepository();

        public ServiceResult<Sirket> Register(SirketRegisterViewModel model)
        {
            ServiceResult<Sirket> result = new ServiceResult<Sirket>();
            Sirket sirket = new Sirket
            {
                Ad=model.Ad,
                Email=model.Email,
                Parola=model.Parola,
                ParolaTekrari=model.ParolaTekrari,
                SGKSicilNo=model.SGKSicilNo,
                Telefon=model.Telefon
            };

            if (_userRepository.Insert(sirket) == null)
            {
                result.AddError(string.Empty, "Kayıt yapılamadı.");
                return result;
            }

            result.Data = sirket;
            return result;
        }
        public ServiceResult<Sirket> Login(SirketLoginViewModel model)
        {
            ServiceResult<Sirket> result = new ServiceResult<Sirket>();

            Sirket sirket = _userRepository.Authorize(model.Email,model.Parola);

            if (sirket == null)
            {
                result.AddError(string.Empty, "Hatalı kullanıcı adı ya da şifre ya da kullanıcı pasif durumdadır.");
                return result;
            }

            result.Data = sirket;
            return result;
        }
       
    }
}
