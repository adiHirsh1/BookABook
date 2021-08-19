using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ExtensionRequestDAL
    {
        public List<ExtensionRequest> GetAllExtensionRequests()
        {

            using (BookABookEntities db = new BookABookEntities())
            {
                return db.ExtensionRequests.ToList();
            }
        }
        public bool CreateExtensionRequest(ExtensionRequest extensionRequest)
        {
            using (BookABookEntities db = new BookABookEntities())
            {
                db.ExtensionRequests.Add(extensionRequest);
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
