using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Repository
{
    public class IUserMan : IUserService
    {
        IUser userdal;

        public IUserMan(IUser userdal)
        {
            this.userdal = userdal;
        }

        public int Adding(User use)
        {
            return userdal.ekle(use);
        }

        public int Deleting(User use)
        {
           return userdal.Sil(use);
        }

        public User GetUser(int id)
        {
            return userdal.Get(id);
        }

        public List<User> Listing()
        {
           return userdal.Listele();
        }

        public int Updating(User use)
        {
            return userdal.guncelle(use);
        }
    }
}
