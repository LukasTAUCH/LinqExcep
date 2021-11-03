using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqDemo01
{
    class Program
    {
        static void Main(string[] args)
        {
            //ShowPeople();
            ShowStudents();
        }

        public static void ShowStudents()
        {
            //Can you retreive the student who are in cohort id 2 ?
            List<Student> student = RepositoryCollege.students();
           // List<Cohort> cohort = RepositoryCollege.cohorts();

            Student s = student.Where(x => x.StudentId == 2).First();
            Console.WriteLine($"Person Id is {s.StudentId} and his name is {s.StudentName}");
            Console.WriteLine();

            var result = (from std in RepositoryCollege.students()
                          join cohort in RepositoryCollege.cohorts() on std.CohortId equals cohort.Id
                          // where std.CohortId == 2
                          select new
                          {
                              _Student = std.StudentName,
                              _Cohort = cohort.CohortName,

                          }).Take(3);

            foreach(var item in result)
            {
                Console.WriteLine($"{item._Student}\t{item._Cohort}");
            }
            Console.WriteLine();


            Console.ReadKey();
        }

        public static void ShowPeople(string[] args)
        {
          

            List<Person> people = RepositoryPerson.persons();

            //foreach (Person p in people)
            //{
            //    Console.WriteLine($"Person Id is {p.Id}");
            //}
            //Console.WriteLine();

            Person p = people.Where(x=>x.Id == 1).First();
            Console.WriteLine($"Person Id is {p.Id}");
            Console.WriteLine();


            Person p31 = people.Where(x => x.Id == 31).FirstOrDefault();
            if (p31 == null)
            {
                Console.WriteLine($"Person Id is not found ");
            }
            else
            {
                Console.WriteLine($"Person Id 31 is {p31.Name}");
            }
            Console.WriteLine();



            List<Person> listbelow5k = people.Where(x => x.Salary <= 50000).ToList();
            foreach( Person currentPerson in listbelow5k)
            {
                Console.WriteLine($"Person name is {currentPerson.Name} and earns {currentPerson.Salary}");
            }
            Console.WriteLine();


            int countFrance = people.Where(x => x.Adress == "France").Count();        
            Console.WriteLine($"{countFrance} people live in France");
            Console.WriteLine();


            IEnumerable<string> result = from p1 in people where p.Name.Length > 4 select p1.Name;
            foreach(var name in result)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();


            Console.ReadKey();

        }
    }
}
