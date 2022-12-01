using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUserService
    {
        int Adding(User use);
        int Deleting(User use);
        int Updating(User use);
        List<User> Listing();
        User GetUser(int id);
    }
}
