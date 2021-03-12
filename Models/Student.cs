using System;
using System.Collections.Generic;
using System.Linq;

namespace ContosoUniversity.Models
{
    public class Student
    {
        //tinfo200:[2021-03-11-kerrou29-dykstra1]--Student properties
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        //tinfo200:[2021-03-11-kerrou29-dykstra1]--refering back to the Enrollement class
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}