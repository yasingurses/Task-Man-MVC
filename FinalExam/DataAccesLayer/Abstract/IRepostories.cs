using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    public interface IRepostories<T> where T : class
    {
        int ekle(T t);
        int Sil(T t);
        int guncelle(T t);
        List<T> Listele();
        T Get(int id);
    }
}
