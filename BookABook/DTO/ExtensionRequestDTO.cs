using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class ExtensionRequestDTO
    {
        public long IdExtensionRequest { get; set; }
        public Nullable<long> IdLend { get; set; }
        public Nullable<long> SeveralDaysForExtension { get; set; }
        public Nullable<bool> ApprovedOrNot { get; set; }
    }
}
