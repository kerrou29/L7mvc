namespace ContosoUniversity.Models
{
    //tinfo200:[2021-03-11-kerrou29-dykstra1]-- Identifying grades with letters using Enumeration 

    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        //tinfo200:[2021-03-11-kerrou29-dykstra1]--Enrollement properties
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }

        //tinfo200:[2021-03-11-kerrou29-dykstra1]--? means that the class is nullable
        //null means that the grade is unknown and not assigned yet
        public Grade? Grade { get; set; }
        public Student Student { get; set; }



    }
}