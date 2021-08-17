using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class ResponsDTO
    {
        public long IdResponse { get; set; }
        public Nullable<long> IdBook { get; set; }
        public Nullable<long> IdUser { get; set; }
        public string Response { get; set; }
        public Nullable<System.DateTime> DateResponse { get; set; }
        public string Rating { get; set; }
    }
}
