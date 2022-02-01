using DataAccess.Context;
using Entities.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UserRepository
    {
        private DatabaseContext _dbContext = new DatabaseContext();

        public Sirket Insert(Sirket sirket)
        {
            _dbContext.Sirketler.Add(sirket);
            if (_dbContext.SaveChanges() > 0)
            {
                return sirket;
            }

            return null;
        }
        public Sirket Authorize(string email, string password)
        {
            Sirket sirket = _dbContext.Sirketler.SingleOrDefault(
                u => u.Email == email && u.Parola == password);

            return sirket;
        }
    }
}
