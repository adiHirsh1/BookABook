using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class TopicsToBookDTO
    {
        public long IdTopicToBook { get; set; }
        public Nullable<long> IdBook { get; set; }
        public Nullable<long> IdTopic { get; set; }

    }
}
