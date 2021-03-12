namespace ContosoUniversity.Models
{

    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }

        //? means that the class is nullable
        //null means that the grade is unknown and not assigned yet
        public Grade? Grade { get; set; }
        public Student Student { get; set; }



    }
}