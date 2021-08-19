using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SearchDAL
    {
        public List<Search> GetAllSearches()
        {

            using (BookABookEntities db = new BookABookEntities())
            {
                return db.Searches.ToList();
            }
        }
        public bool CreateSearch(Search search)
        {
            using (BookABookEntities db = new BookABookEntities())
            {
                db.Searches.Add(search);
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
