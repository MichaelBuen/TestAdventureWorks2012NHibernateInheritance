
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NHibernate;

using NHibernate.Mapping.ByCode.Conformist;

using TestInheritance.DomainModels;


namespace TestInheritance.DomainModelMappings
{
    public sealed class PersonOnlyMapping : PersonMapping
    {
        public PersonOnlyMapping()
        {
            EntityName("Person");
            
            
        }
    }
}
