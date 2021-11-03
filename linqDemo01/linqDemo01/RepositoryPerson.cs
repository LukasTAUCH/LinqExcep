using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqDemo01
{
    public class RepositoryPerson
    {
        public static List<Person> persons()
        {
            List<Person> people = new List<Person>()
            {
                new Person() { Id = 1, Name = "Lukas Tauch", Adress = "France", Salary = 100000 },
                new Person() { Id = 2, Name = "Roman gaignault", Adress = "Irlande", Salary = 20000 },
                new Person() { Id = 3, Name = "Tanguy Lichau", Adress = "Suisse", Salary = 30000 },
                new Person() { Id = 4, Name = "kent1 Guillard", Adress = "Allemagne", Salary = 40000 },
            };

            return people;
        }
    }
}
