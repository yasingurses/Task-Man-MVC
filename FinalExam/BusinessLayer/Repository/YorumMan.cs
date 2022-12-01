using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Repository
{
    public class YorumMan : IYorumService
    {
        IYorum yorum;

        public YorumMan(IYorum yorum)
        {
            this.yorum = yorum;
        }

        public int Adding(Yorum yor)
        {
            return yorum.ekle(yor);
        }

        public int Deleting(Yorum yor)
        {
            return yorum.Sil(yor);
        }

        public List<Yorum> GetByGorevId(int gorevId)
        {
            return yorum.GetByGorevId(gorevId);
        }

        public Yorum GetYorum(int id)
        {
            return yorum.Get(id);
        }

        public List<Yorum> Listing()
        {
            return yorum.Listele();
        }

        public int Updating(Yorum yor)
        {
            return yorum.guncelle(yor);
        }
    }
}
