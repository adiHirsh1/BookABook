using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class SearchDTO
    {

        public long IdSearch { get; set; }
        public Nullable<long> IdUser { get; set; }
        public Nullable<long> IdAge { get; set; }
        public Nullable<long> IdTopic { get; set; }
        public Nullable<System.DateTime> SearchDate { get; set; }
        public Nullable<long> FoundOrNot { get; set; }
        public Nullable<long> WantAlertsOrNot { get; set; }

    }
}
