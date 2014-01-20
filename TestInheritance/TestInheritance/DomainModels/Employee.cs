using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInheritance.DomainModels
{
    public class Employee : TestInheritance.DomainModels.ThePerson.Person
    {
        public virtual string NationalIDNumber { get; set; }
        public virtual string JobTitle { get; set; }
    }
}
