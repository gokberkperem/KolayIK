using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Harcama
    {
        public int Id { get; set; }
        public HarcamaTipi Tip { get; set; }
        public string Aciklama { get; set; }
        public decimal Tutar { get; set; }
        public DateTime Tarihi { get; set; }
        public HarcamaOnayDurumu Durumu { get; set; }

        public virtual Personel Personel { get; set; }
    }

    public enum HarcamaTipi
    {
        Yol,
        Yemek,
        Diger,
        //....
    }

    public enum HarcamaOnayDurumu
    {
        Beklemede,
        Kabul,
        Red
    }

}
