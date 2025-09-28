namespace LSU_App
{
    /// <summary>
    /// Represents a faculty member within the LSU_App system.
    /// Contains identifying information and department assignment.
    /// </summary>
    public class Faculty
    {
        /// <summary>
        /// Unique identifier for the faculty member.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// First name of the faculty member.
        /// </summary>
        public string FirstName { get; set; } = string.Empty;

        /// <summary>
        /// Last name of the faculty member.
        /// </summary>
        public string LastName { get; set; } = string.Empty;

        /// <summary>
        /// Department to which the faculty member belongs.
        /// </summary>
        public string Department { get; set; } = string.Empty;

        /// <summary>
        /// Default constructor for Faculty.
        /// </summary>
        public Faculty() { }

        /// <summary>
        /// Parameterized constructor for Faculty.
        /// </summary>
        /// <param name="id">Faculty ID</param>
        /// <param name="firstName">First name</param>
        /// <param name="lastName">Last name</param>
        /// <param name="department">Department name</param>
        public Faculty(int id, string firstName, string lastName, string department)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Department = department;
        }

        /// <summary>
        /// Returns a string representation of the faculty member.
        /// </summary>
        public override string ToString()
        {
            return $"{FirstName} {LastName} (ID: {Id}, Dept: {Department})";
        }
    }
}