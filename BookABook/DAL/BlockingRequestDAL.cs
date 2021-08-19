using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BlockingRequestDAL
    {
        public List<BlockingRequest> GetAllBlockingRequests()
        {

            using (BookABookEntities db = new BookABookEntities())
            {
                return db.BlockingRequests.ToList();
            }
        }
        public bool CreateBlockingRequest(BlockingRequest blockingRequest)
        {
            using (BookABookEntities db = new BookABookEntities())
            {
                db.BlockingRequests.Add(blockingRequest);
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
