using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using NHibernate;
using NHibernate.Cfg;
using NHibernate.Cfg.MappingSchema;
using NHibernate.Engine;
using NHibernate.Mapping.ByCode;
using TestInheritance.DomainModelMappings;
 

namespace TestInheritance.TheMapper
{
    public static class Mapper
    {
        static NHibernate.ISessionFactory _sessionFactory = Mapper.GetSessionFactory();


        public static NHibernate.ISessionFactory SessionFactory
        {
            get { return _sessionFactory; }
        }

        static NHibernate.ISessionFactory GetSessionFactory()
        {
            var mapper = new NHibernate.Mapping.ByCode.ModelMapper();

            mapper.AddMappings(
                new[] { 
                    typeof(BusinessEntityMapping),
                    typeof(PersonMapping),
                    typeof(EmployeeMapping),

                    typeof(StoreMapping),
                    // typeof(VendorMapping)

                    // typeof(PersonOnlyMapping)
                });


            var cfg = new NHibernate.Cfg.Configuration();

            //cfg.AddAssembly(System.Reflection.Assembly.GetCallingAssembly());
            //cfg.Configure();
            

            // cfg.AddAssembly(typeof(Program).Assembly);



            cfg.DataBaseIntegration(c =>
            {
                c.Driver<NHibernate.Driver.Sql2008ClientDriver>();
                c.Dialect<NHibernate.Dialect.MsSql2012Dialect>();
                c.ConnectionString = "Server=.; Database=AdventureWorks2012; Trusted_Connection=true";

                c.LogFormattedSql = true;
                c.LogSqlInConsole = true;
            });



            
            HbmMapping domainMapping = mapper.CompileMappingForAllExplicitlyAddedEntities();


            foreach (var rootClass in domainMapping.JoinedSubclasses)
            {
                Console.WriteLine(rootClass.Name);
                //if (rootClass.Name.StartsWith("Person"))
                    // rootClass.polymorphism = HbmPolymorphismType.Explicit;
            } 


            cfg.AddMapping(domainMapping);


            

            _sessionFactory = cfg.BuildSessionFactory();


            return _sessionFactory;
        }
    }
}


namespace Space.Craft
{
    public class Craft
    {
        public class xCraft
        {
        }
    }
}