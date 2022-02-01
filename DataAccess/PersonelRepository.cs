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
    }
}
