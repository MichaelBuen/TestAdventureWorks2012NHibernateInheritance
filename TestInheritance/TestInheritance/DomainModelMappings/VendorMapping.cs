
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NHibernate.Mapping.ByCode.Conformist;

using TestInheritance.DomainModels;

namespace TestInheritance.DomainModelMappings
{
    public class VendorMapping : JoinedSubclassMapping<Vendor>
    {
        public VendorMapping()
        {
            Table("Purchasing.Vendor");

            Key(x => x.Column("BusinessEntityID"));

            Property(x => x.AccountNumber);
            Property(x => x.Name);
        }
    }
}
