using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInheritance.DomainModels
{
    public class Store : BusinessEntity
    {
        public virtual string Name { get; set; }        
    }
}
