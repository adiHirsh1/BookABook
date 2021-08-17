using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class BlockingRequestDTO
    {
        public long IdBlockingRequest { get; set; }
        public Nullable<long> IdUser { get; set; }
        public Nullable<long> IdUserForBlocking { get; set; }
        public string Reason { get; set; }

    }
}
