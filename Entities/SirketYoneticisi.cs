using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SirketYoneticisi
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string Gorevi { get; set; }
        public string Parola { get; set; }
        public string ParolaTekrari { get; set; }
        public DateTime DogumTarihi { get; set; }
        public bool AktifMi { get; set; }

        // Todo : Şirket Yönetici fotoğraf tutulaacak

        public virtual Sirket Sirketi { get; set; } 
        public virtual Yorum Yorumu { get; set; }
        public virtual List<UyelikPaketTipi> UyelikPaketTipleri { get; set; }
    }
}
