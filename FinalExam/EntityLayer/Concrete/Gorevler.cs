using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Gorevler
    {
        [Key]
        public int GorevID { get; set; }
        public string GorevTitle { get; set; }
        public string GorevAciklama { get; set; }
        public string GorevSahibi { get; set; }
        public string GorevDurumu { get; set; }
        public DateTime GorevTarihi { get; set; }
    }
}
