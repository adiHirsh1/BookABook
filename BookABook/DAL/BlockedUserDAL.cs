using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BlockedUserDAL
    {
        public List<BlockedUser> GetAllBlockedUsers()
        {
            using (BookABookEntities db = new BookABookEntities())
            {
                return db.BlockedUsers.ToList();
            }
        }
        public bool CreateBlockedUser(BlockedUser blockedUser)
        {
            using (BookABookEntities db = new BookABookEntities())
            {
                db.BlockedUsers.Add(blockedUser);
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
