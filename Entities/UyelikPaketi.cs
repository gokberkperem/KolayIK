using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class UyelikPaketi
    {
        public int Id { get; set; }
        public UyelikPaketTipi Tip { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }

    }

    public enum UyelikPaketTipi
    {
        Aylik,
        Yillik
    }
}
