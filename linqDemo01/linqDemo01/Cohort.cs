using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqDemo01
{
    public class Cohort
    {
        public int Id { get; set; }
        public string CohortName { get; set; }

    }

    public class Student
    {
        public int StudentId { get; set; }
        public String StudentName { get; set; }
        public int CohortId { get; set; }
    }

}
