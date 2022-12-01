using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IYorumService
    {
        int Adding(Yorum yor);
        int Deleting(Yorum yor);
        int Updating(Yorum yor);
        List<Yorum> Listing();
        List<Yorum> GetByGorevId(int gorevId);
        Yorum GetYorum(int id);
    }
}
