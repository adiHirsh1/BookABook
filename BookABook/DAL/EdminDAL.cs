using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EdminDAL
    {
        public List<Edmin> GetAllEdmins()
        {

            using (BookABookEntities db = new BookABookEntities())
            {
                return db.Edmins.ToList();
            }
        }
        public bool CreateEdmin(Edmin edmin)
        {
            using (BookABookEntities db = new BookABookEntities())
            {
                db.Edmins.Add(edmin);
                try
                {
                    db.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

    }
}
