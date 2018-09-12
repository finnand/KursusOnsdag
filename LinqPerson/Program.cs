using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start
            var r = new PersonNuGetPackage.PersonRepositoryRandom();
            var people = r.GetPeople(10);

            foreach (var person in people)
                Console.WriteLine(person.Name);

            Console.WriteLine();
            var res1 = people.OrderBy(i => i.Name);
            var res1l = from person in people orderby person.Name select person;
            foreach (var person in res1)
                Console.WriteLine(person.Name);

            Console.WriteLine();
            var res2 = people.OrderBy(i => i.Name);

            // Hold console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
