using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class BookDTO
    {
        public long IdBook { get; set; }
        public string NameBook { get; set; }
        public Nullable<long> IdAuthor { get; set; }
        public Nullable<long> IdLanguage { get; set; }
    }
}
