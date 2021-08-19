using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BorrowableBookDAL
    {
        public List<BorrowableBook> GetAllBorrowableBooks()
        {

            using (BookABookEntities db = new BookABookEntities())
            {
                return db.BorrowableBooks.ToList();
            }
        }
        public bool CreateBorrowableBook(BorrowableBook borrowableBook)
        {
            using (BookABookEntities db = new BookABookEntities())
            {
                db.BorrowableBooks.Add(borrowableBook);
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
