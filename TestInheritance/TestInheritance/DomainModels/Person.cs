using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInheritance.DomainModels
{
    public static class ThePerson
    {
        public class Person : BusinessEntity
        {
            public virtual string FirstName { get; set; }
            public virtual string LastName { get; set; }
        }
    }
    
}
