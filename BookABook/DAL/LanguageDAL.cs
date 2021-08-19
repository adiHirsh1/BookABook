using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LanguageDAL
    {
        public List<Language> GetAllLanguages()
        {

            using (BookABookEntities db = new BookABookEntities())
            {
                return db.Languages.ToList();
            }
        }
        public bool CreateLanguage(Language language)
        {
            using (BookABookEntities db = new BookABookEntities())
            {
                db.Languages.Add(language);
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
