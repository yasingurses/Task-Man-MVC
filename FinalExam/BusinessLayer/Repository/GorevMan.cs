using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Repository
{
    public class GorevMan : IGorevService
    {
        IGorev gorev;

        public GorevMan(IGorev gorev)
        {
            this.gorev = gorev;
        }

        public int Adding(Gorevler Gor)
        {
            Gor.GorevDurumu = Status.Oluştruldu.ToString();
            return gorev.ekle(Gor);
        }

        public int Deleting(Gorevler Gor)
        {
            return gorev.Sil(Gor);
        }

        public Gorevler GetGorev(int id)
        {
            return gorev.Get(id);
        }

        public List<Gorevler> Listing()
        {
            return gorev.Listele();
        }

        public int Updating(Gorevler Gor)
        {
            var result = gorev.Get(Gor.GorevID);
            result.GorevTarihi = DateTime.Now;
            if ((result.GorevDurumu==Status.Devamediyor.ToString() && Gor.GorevDurumu==Status.Oluştruldu.ToString()) ||
                (result.GorevDurumu==Status.Bitti.ToString() && (Gor.GorevDurumu==Status.Devamediyor.ToString()|| Gor.GorevDurumu==Status.Oluştruldu.ToString()) ))
            {
                return 0;
            }
            if (result.GorevDurumu != Status.Oluştruldu.ToString())
            {
                result.GorevDurumu = Gor.GorevDurumu;
                return gorev.guncelle(result);
            }
            else
            {
                result.GorevDurumu = Gor.GorevDurumu;
                result.GorevTitle = Gor.GorevTitle;
                result.GorevAciklama = Gor.GorevAciklama;
                result.GorevSahibi = Gor.GorevSahibi;
                return gorev.guncelle(result);
            }
        }
    }
}
