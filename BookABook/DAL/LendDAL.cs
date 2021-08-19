using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LendDAL
    {
        public List<Lend> GetAllLends()
        {

            using (BookABookEntities db = new BookABookEntities())
            {
                return db.Lends.ToList();
            }
        }
        public bool CreateLend(Lend lend)
        {
            using (BookABookEntities db = new BookABookEntities())
            {
                db.Lends.Add(lend);
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
