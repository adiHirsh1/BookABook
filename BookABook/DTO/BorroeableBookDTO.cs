using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class BorroeableBookDTO
    {
        public long IdBorrowableBook { get; set; }
        public Nullable<long> IdUser { get; set; }
        public Nullable<long> IdBook { get; set; }
        public string RemarksUesr { get; set; }
        public Nullable<long> SeveralDaysForReturn { get; set; }
        public string Status { get; set; }
        public string ConditionOfTheBook { get; set; }
        public Nullable<long> Edition { get; set; }
        public Nullable<System.DateTime> YearOfPublication { get; set; }
        public string Summary { get; set; }

    }
}
