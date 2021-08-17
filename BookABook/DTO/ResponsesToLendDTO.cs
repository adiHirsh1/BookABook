using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class ResponsesToLendDTO
    {

        public long IdResponsesToLends { get; set; }
        public Nullable<long> IdBook { get; set; }
        public Nullable<long> IdLend { get; set; }

    }
}
