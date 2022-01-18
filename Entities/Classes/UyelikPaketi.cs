using Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Classes

{
    public class UyelikPaketi
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public UyelikPaketTipi Tip { get; set; }
        [Required]
        public DateTime BaslangicTarihi { get; set; }
        [Required]
        public DateTime BitisTarihi { get; set; }

        [ForeignKey("Sirket")]
        public int SirketId { get; set; }
        public virtual List<Sirket> Sirketler { get; set; }

    }
}
