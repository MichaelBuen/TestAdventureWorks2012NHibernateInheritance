using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NHibernate;
using NHibernate.Linq;


using TestInheritance.DomainModels;

namespace TestInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var s = TheMapper.Mapper.SessionFactory.OpenSession())
            {
                //var list = s.Query<Employee>();   

                //foreach (var item in list)
                //{
                //    Console.WriteLine("{0} : {1} {2} - {3}", item.BusinessEntityID, item.FirstName, item.LastName, item.JobTitle);
                //}                





                var pxxList = s.Query<TestInheritance.DomainModels.ThePerson.Person>()
                    // .OfType<TestInheritance.DomainModels.ThePerson.Person>()
                    // .Where(x => x.GetType() == typeof(TestInheritance.DomainModels.ThePerson.Person))
                    .ToList();

                

                //var px = s.Load<PersonOnly>(1);


                // var pxList = s.CreateQuery("from Person p where p.class = Person").List<TestInheritance.DomainModels.ThePerson.Person>();

                Console.ReadKey();
                return;

                var pList = s.Query<TestInheritance.DomainModels.ThePerson.Person>()
                    .ToList();


                Console.ReadKey();


                return;
                Console.WriteLine("{0}", pList.Count());

                var e = (Employee)pList.Single(x => x.BusinessEntityID == 291);

                Console.WriteLine("{0} {1}", e.BusinessEntityID);


                Console.ReadKey();
                return;


                var list = s.Query<BusinessEntity>().ToList();

                

                Console.ReadKey();

                int i = 0;
                foreach (var item in list)
                {

           


                    //// Can use, but avoid, order-dependent. Derived classes must be first than base classes
                    //if (item is Employee)
                    //    Console.WriteLine("Employee");
                    //else if (item is Person)
                    //    Console.WriteLine("Person");


                    // Good code
                    if (item.GetType() == typeof(TestInheritance.DomainModels.ThePerson.Person))
                        Console.WriteLine("Employee");
                    else if (item.GetType() == typeof(Employee))
                        Console.WriteLine("Person");

                    if (++i == 5) break;
                }
            }

            Console.ReadKey();
        }
    }
}
