using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestInheritance.DomainModels;

namespace TestInheritance.DomainModelMappings
{
    public class StoreMapping : JoinedSubclassMapping<Store>
    {
        public StoreMapping()
        {
            Table("Sales.Store");

            Key(x => x.Column("BusinessEntityID"));

            Property(x => x.Name);
        }
    }
}
