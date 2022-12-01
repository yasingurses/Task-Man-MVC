using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGorevService
    {
        int Adding(Gorevler Gor);
        int Deleting(Gorevler Gor);
        int Updating(Gorevler Gor);
        List<Gorevler> Listing();
        Gorevler GetGorev(int id);
    }
}
