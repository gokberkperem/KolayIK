using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Yorum
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Detay { get; set; }
        public DateTime YazilmaTarihi { get; set; }

        public virtual SirketYoneticisi SirketYoneticisi { get; set; }
    }
}
