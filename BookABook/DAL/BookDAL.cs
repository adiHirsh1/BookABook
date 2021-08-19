using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BookDAL
    {
        public List<Book> GetAllBooks()
        {

            using (BookABookEntities db = new BookABookEntities())
            {
                return db.Books.ToList();
            }
        }
        public bool CreateBook(Book book)
        {
            using (BookABookEntities db = new BookABookEntities())
            {
                db.Books.Add(Book);
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
