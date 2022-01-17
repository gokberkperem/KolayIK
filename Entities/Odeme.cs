using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Odeme
    {
        public int Id { get; set; }
        public OdemeTipi Tipi { get; set; }
        public decimal Miktari { get; set; }
        public DateTime OdemeTarihi { get; set; }

        public Personel Personel { get; set; }

    }

    public enum OdemeTipi
    {
        Avans,
        Maas,
        FazlaMesai,
        Ikramiye,
        Evlilik,
        Dogum,
        Sendika,
        Yol,
        Yemek,
        Agi,
        CocukYardimi,
        YakacakYardimi

    }
}
