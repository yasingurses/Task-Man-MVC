using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repositories
{
    public class YorumRepo : Repostories<Yorum>, IYorum
    {
        Context c = new Context();
        public List<Yorum> GetByGorevId(int gorevId)
        {
           return c.Yorums.Where(o => o.GorevId == gorevId).ToList();
        }
    }
}
