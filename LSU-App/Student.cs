namespace LSU_App
{
    /// <summary>
    /// Represents a student within the LSU_App system.
    /// Contains identifying information and date of birth.
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Unique identifier for the student.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// First name of the student.
        /// </summary>
        public string FirstName { get; set; } = string.Empty;

        /// <summary>
        /// Last name of the student.
        /// </summary>
        public string LastName { get; set; } = string.Empty;

        /// <summary>
        /// Date of birth of the student.
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Default constructor for Student.
        /// </summary>
        public Student() { }

        /// <summary>
        /// Parameterized constructor for Student.
        /// </summary>
        /// <param name="id">Student ID</param>
        /// <param name="firstName">First name</param>
        /// <param name="lastName">Last name</param>
        /// <param name="dateOfBirth">Date of birth</param>
        public Student(int id, string firstName, string lastName, DateTime dateOfBirth)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        /// <summary>
        /// Returns a string representation of the student.
        /// </summary>
        public override string ToString()
        {
            return $"{FirstName} {LastName} (ID: {Id})";
        }
    }
}