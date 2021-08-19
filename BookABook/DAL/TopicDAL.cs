using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TopicDAL
    {
        public List<Topic> GetAllTopics()
        {
            using (BookABookEntities db=new BookABookEntities())
            {
                return db.Topics.ToList();
            }
        }
        public bool CreatTopic(Topic topic)
        {
            using(BookABookEntities db=new BookABookEntities())
            {
                db.Topics.Add(topic);
                try
                {
                    db.SaveChanges();
                    return true;
                }
                catch(Exception e)
                {
                    throw e;
                }
            }
        }
    }
}
