using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class BlockedUserDTO
    {
        public long IdUser { get; set; }
        public Nullable<bool> BlockedOrNot { get; set; }
    }
}
