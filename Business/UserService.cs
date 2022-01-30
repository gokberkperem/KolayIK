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

        public Sirket Register(SirketRegisterViewModel model)
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

            /* if (_userRepository.Insert(sirket)==null)
             {

             }
            */
            return _userRepository.Insert(sirket);
        }
    }
}
