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
    public class PersonelService
    {
        private PersonelRepository _personelRepository = new PersonelRepository();
        public ServiceResult<Personel> Register(PersonelRegisterViewModel model)
        {
            ServiceResult<Personel> result = new ServiceResult<Personel>();
            Personel personel = new Personel
            {
                Ad = model.Ad,
                Soyad = model.Soyad,
                Email = model.Email,
                Telefon = model.Telefon,
                IseAlimTarihi = model.IseAlimTarihi,
                DogumTarihi = model.DogumTarihi
            };

            if (_personelRepository.Insert(personel) == null)
            {
                result.AddError(string.Empty, "Kayıt yapılamadı.");
                return result;
            }

            result.Data = personel;
            return result;
        }
    }
}
