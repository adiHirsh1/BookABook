using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class UserDTO
    {
        //בלי מאפיינים של קשרי גומלין
        public long IdUser { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }
        public Nullable<long> SMS { get; set; }
        public string Address { get; set; }
        public Nullable<long> CellPhonNumber { get; set; }
        public string Remarks { get; set; }
    }
}
