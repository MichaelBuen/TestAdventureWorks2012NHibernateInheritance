using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestInheritance.DomainModels;

namespace TestInheritance.DomainModelMappings
{

    public class EmployeeMapping : JoinedSubclassMapping<Employee>
    {
        public EmployeeMapping()
        {
            Table("HumanResources.Employee");

            Key(k => k.Column("BusinessEntityID"));


            Property(x => x.NationalIDNumber);
            Property(x => x.JobTitle);

            
        }
    }
}
