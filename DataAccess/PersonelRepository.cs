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
        public List<Personel> GetPersonels()
        {
            return _dbContext.Personeller.ToList();
        }
        public Personel GetPersonel(int id)
        {
           return _dbContext.Personeller.Find(id);

        }
        public bool Remove(int id)
        {
            Personel personel = GetPersonel(id);

            _dbContext.Personeller.Remove(personel);

            return _dbContext.SaveChanges() > 0; 
        }
    }
}
