using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ResponsesToLendDAL
    {
        public List<ResponsesToLend> GetAllResponsesToLends()
        {

            using (BookABookEntities db = new BookABookEntities())
            {
                return db.ResponsesToLends.ToList();
            }
        }
        public bool CreateResponsesToLend(ResponsesToLend responsesToLend)
        {
            using (BookABookEntities db = new BookABookEntities())
            {
                db.ResponsesToLends.Add(responsesToLend);
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
