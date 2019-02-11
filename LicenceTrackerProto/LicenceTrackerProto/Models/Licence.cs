using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LicenceTrackerProto.Models
{
    public class Licence
    {
        public Guid ID { get; set; }
        public string LicenceKey { get; set; }

        public string User { get; set; }
    }
}
