using System;
using System.Collections.Generic;

namespace Entities2
{
    public partial class CustomerPackage
    {
        public int CustomerPackageId { get; set; }
        public int CustomerId { get; set; }
        public int PackageId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Package Package { get; set; }
    }
}
