using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class LendDTO
    {
        public long IdLend { get; set; }
        public Nullable<long> IdBorrowableBook { get; set; }
        public Nullable<long> IdUser { get; set; }
        public Nullable<System.DateTime> LendDate { get; set; }
        public Nullable<System.DateTime> ReturnDate { get; set; }
    }
}
