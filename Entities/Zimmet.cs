using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Zimmet
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Detay { get; set; }

        public virtual Personel Personel { get; set; }
    }
}
