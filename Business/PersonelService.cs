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
                DogumTarihi = model.DogumTarihi,
                Parola = model.Parola,
                ParolaTekrari = model.ParolaTekrari

            };

            if (_personelRepository.Insert(personel) == null)
            {
                result.AddError(string.Empty, "Kayıt yapılamadı.");
                return result;
            }

            result.Data = personel;
            return result;
        }

        public ServiceResult<Personel> Login(PersonelLoginViewModel model)
        {
            ServiceResult<Personel> result = new ServiceResult<Personel>();

            Personel personel = _personelRepository.Authorize(model.Email, model.Parola);

            if (personel == null)
            {
                result.AddError(string.Empty, "Hatalı kullanıcı adı ya da şifre ya da kullanıcı pasif durumdadır.");
                return result;
            }

            result.Data = personel;
            return result;
        }

        public List<Personel> GetPersonels()
        {
            List<Personel> personels = _personelRepository.GetPersonels();

            if (personels != null)
            {
                return personels;
            }

            return new List<Personel>();
        }

        public ServiceResult<Personel> Find(int id)
        {
            ServiceResult<Personel> result = new ServiceResult<Personel>();

            Personel personel = _personelRepository.GetPersonel(id);

            result.Data = personel;

            if (result.Data == null)
            {
                result.NotFound = true;
                result.AddError(string.Empty, "Kayıt bulunamadı.");
            }

            return result;
        }
        public ServiceResult<object> Remove(int id)
        {
            ServiceResult<object> result = new ServiceResult<object>();
            bool isRemoved = _personelRepository.Remove(id);

            if (isRemoved == false)
            {
                result.AddError(string.Empty, "Kayıt silinemedi.");
            }

            return result;
        }

        public ServiceResult<Personel> Update(int id, PersonelEditViewModel model)
        {
            ServiceResult<Personel> result = new ServiceResult<Personel>();

            model.Email = model.Email?.Trim();

            if (_personelRepository.IsExistsByEmail(model.Email, id))
            {
                result.AddError(nameof(PersonelEditViewModel.Email), "Aynı isimli mail mevcuttur.");
                return result;
            }

            model.Telefon = model.Telefon?.Trim();

            if (_personelRepository.IsExistsByTelefon(model.Telefon, id))
            {
                result.AddError(nameof(PersonelEditViewModel.Telefon), "Aynı telefon numarası mevcuttur.");
                return result;
            }

            Personel personel = new Personel
            {
                Id = id,
                Ad = model.Ad,
                Soyad = model.Soyad,
                Email = model.Email,
                Telefon = model.Telefon,
                IseAlimTarihi = model.IseAlimTarihi,
                DogumTarihi = model.DogumTarihi,
                AktifMi = model.AktifMi,
            };

            personel = _personelRepository.Update(id, personel);

            if (personel == null)
            {
                result.AddError(string.Empty, "Kayıt yapılamadı.");
                return result;
            }

            result.Data = personel;
            return result;
        }
    }
}
