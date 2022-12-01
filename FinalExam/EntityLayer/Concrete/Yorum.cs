using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Yorum
    {
        public int Id { get; set; }
        public int GorevId { get; set; }
        public string YorumMetni { get; set; }
        public string Kullanıcı { get; set; }
    }
}
