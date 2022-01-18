using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Sirket
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string WebSitesi { get; set; }
        public string Email { get; set; }
        public DateTime KurulusTarihi { get; set; }

        // Todo : Logo nasıl tutulacak

        public SirketYoneticisi Yonetici { get; set; }
        public List<Personel> Personeller { get; set; } 
    }
}
