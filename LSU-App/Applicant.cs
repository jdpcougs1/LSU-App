namespace LSU_App
{
    /// <summary>
    /// Represents an applicant to the LSU_App system.
    /// Contains identifying information, application date, and status.
    /// </summary>
    public class Applicant
    {
        /// <summary>
        /// Unique identifier for the applicant.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// First name of the applicant.
        /// </summary>
        public string FirstName { get; set; } = string.Empty;

        /// <summary>
        /// Last name of the applicant.
        /// </summary>
        public string LastName { get; set; } = string.Empty;

        /// <summary>
        /// Date the application was submitted.
        /// </summary>
        public DateTime ApplicationDate { get; set; }

        /// <summary>
        /// Current status of the application (e.g., Pending, Accepted, Rejected).
        /// </summary>
        public string Status { get; set; } = string.Empty;

        /// <summary>
        /// Default constructor for Applicant.
        /// </summary>
        public Applicant() { }

        /// <summary>
        /// Parameterized constructor for Applicant.
        /// </summary>
        /// <param name="id">Applicant ID</param>
        /// <param name="firstName">First name</param>
        /// <param name="lastName">Last name</param>
        /// <param name="applicationDate">Application date</param>
        /// <param name="status">Application status</param>
        public Applicant(int id, string firstName, string lastName, DateTime applicationDate, string status)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            ApplicationDate = applicationDate;
            Status = status;
        }

        /// <summary>
        /// Returns a string representation of the applicant.
        /// </summary>
        public override string ToString()
        {
            return $"{FirstName} {LastName} (ID: {Id}, Status: {Status})";
        }
    }
}