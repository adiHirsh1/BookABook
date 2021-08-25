using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL    
{
    public class UserDAL
    {
        public List<User> GetAllUsers()
        {

            using (BookABookEntities db = new BookABookEntities())
            {
                return db.Users.ToList();
            }
        }
        public bool CreateUser(User user)
        {
            using (BookABookEntities db = new BookABookEntities())
            {
                db.Users.Add(user);
                try
                {
                    db.SaveChanges();
                    return true;
                }
                catch(Exception e)
                {
                    throw e;
                }
            }
        }
    }
}
