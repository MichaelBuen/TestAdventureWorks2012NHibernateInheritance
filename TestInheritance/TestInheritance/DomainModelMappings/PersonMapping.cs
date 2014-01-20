
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NHibernate.Mapping.ByCode.Conformist;
using TestInheritance.DomainModels;

namespace TestInheritance.DomainModelMappings
{
    public class PersonMapping : JoinedSubclassMapping<ThePerson.Person>
    {
        public PersonMapping()
        {

            Table("Person.Person");

            Key(k => k.Column("BusinessEntityID"));

            Property(x => x.FirstName);
            Property(x => x.LastName);
        }
    }
}
