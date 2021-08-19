using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ResponsDAL
    {
        public List<Respons> GetAllResponses()
        {

            using (BookABookEntities db = new BookABookEntities())
            {
                return db.Responses.ToList();
            }
        }
        public bool CreateRespons(Respons respons)
        {
            using (BookABookEntities db = new BookABookEntities())
            {
                db.Responses.Add(respons);
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
