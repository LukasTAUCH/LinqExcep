using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqDemo01
{
    public class RepositoryCollege
    {
        public static List<Cohort> cohorts()
        {
            List<Cohort> cohorts = new List<Cohort>()
            {
                new Cohort{Id = 1, CohortName = "French"},
                new Cohort{Id = 2, CohortName = "English"},
                new Cohort{Id = 3, CohortName = "Spanish"},
            };
            return cohorts;
        }

        public static List<Student> students()
        {
            List<Student> students = new List<Student>()
            {
                new Student{CohortId = 1, StudentId = 1, StudentName = "Luaks Tauch"},
                 new Student{CohortId = 2, StudentId =2, StudentName = "roman Gaignault"},
                  new Student{CohortId = 3, StudentId = 3, StudentName = "Tanguy Livchau"},
            };

            return students;
        }
    }
}
