using DataAccess.Context;
using Entities.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class PersonelRepository
    {
        private DatabaseContext _dbContext = new DatabaseContext();
        public Personel Insert(Personel personel)
        {
            _dbContext.Personeller.Add(personel);
            if (_dbContext.SaveChanges() > 0)
            {
                return personel;
            }

            return null;
        }
        public List<Personel> GetAll()
        {
            return _dbContext.Personeller.ToList();
        }
        public Personel GetPersonelById(int id)
        {
            return _dbContext.Personeller.Find(id);

        }
        public bool Remove(int id)
        {
            Personel personel = GetPersonelById(id);

            _dbContext.Personeller.Remove(personel);

            return _dbContext.SaveChanges() > 0;
        }

        public Personel Update(int id, Personel personel)
        {
            Personel personeldb = GetPersonelById(id);

            if (personeldb != null)
            {
                personeldb.Ad = personel.Ad;
                personeldb.Soyad = personel.Soyad;
                personeldb.Email = personel.Email;
                personeldb.Telefon = personel.Telefon;
                personeldb.IseAlimTarihi = personel.IseAlimTarihi;
                personeldb.DogumTarihi = personel.DogumTarihi;
                personeldb.AktifMi = personel.AktifMi;


                if (_dbContext.SaveChanges() > 0)
                    return personeldb;
            }

            return null;
        }

        public Personel Authorize(string email, string parola)
        {
            Personel personel = _dbContext.Personeller.SingleOrDefault(
                u => u.Email == email && u.Parola == parola);

            return personel;
        }

        public bool IsExistsByEmail(string email, int personelId)
        {
            return _dbContext.Personeller.Any(e => e.Email == email && e.Id != personelId);
        }

        public bool IsExistsByTelefon(string telefon, int personelId)
        {
            return _dbContext.Personeller.Any(e => e.Telefon == telefon && e.Id != personelId);
        }

        public bool ChangePassword(int id, string password)
        {
            Personel personel = GetPersonelById(id);

            personel.Parola = password;

            return _dbContext.SaveChanges() > 0;
        }

        public bool SaveProfileInfo(int id, Personel p)
        {
            Personel personel = GetPersonelById(id);

            personel.Ad = p.Ad;
            personel.Soyad = p.Soyad;
            personel.Email = p.Email;
            personel.Telefon = p.Telefon;

            return _dbContext.SaveChanges() > 0;
        }
    }
}
