using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AuthorDAL
    {
        public List<Author> GetAllAuthors()
        {

            using (BookABookEntities db = new BookABookEntities())
            {
                return db.Authors.ToList();
            }
        }
        public bool CreateAuthor(Author author)
        {
            using (BookABookEntities db = new BookABookEntities())
            {
                db.Authors.Add(author);
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
