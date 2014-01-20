using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInheritance.DomainModels
{
    public class Vendor : BusinessEntity
    {
        public virtual string AccountNumber { get; set; }
        public virtual string Name { get; set; }
    }
}
