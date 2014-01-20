
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestInheritance.DomainModels;

using NHibernate.Mapping.ByCode.Conformist;

namespace TestInheritance.DomainModelMappings
{
    public class BusinessEntityMapping : ClassMapping<BusinessEntity>
    {
        public BusinessEntityMapping()
        {
            Table("Person.BusinessEntity");
            Id(x => x.BusinessEntityID, m => m.Generator(NHibernate.Mapping.ByCode.Generators.Identity));            

        }
    }
}
