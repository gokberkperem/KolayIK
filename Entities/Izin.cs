using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Izin
    {   
        [Key]
        public int Id { get; set; }

        public IzinTurleri Tur { get; set; }

        public DateTime BaslangicTarihi { get; set; }

        public DateTime BitisTarihi { get; set; }

        public IzinDurumu Durumu { get; set; }

        public Personel Personel { get; set; }

        public Odeme Odeme { get; set; }
    }


    public enum IzinDurumu
    {
        Beklemede,
        Kabul,
        Red
    }

    public enum IzinTurleri
    {
        YillikIzin,
        DogumIzni,
        UcretsIzin,
        EvlilikIzni,
        RaporIzni,
        AnnelikIzni,
        BabalikIzni,
        MazaretIzni,
        OlumIzni

    }
}
