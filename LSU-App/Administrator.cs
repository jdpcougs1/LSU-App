namespace LSU_App
{
    /// <summary>
    /// Represents an administrator within the LSU_App system.
    /// Contains identifying information and administrative role.
    /// </summary>
    public class Administrator
    {
        /// <summary>
        /// Unique identifier for the administrator.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// First name of the administrator.
        /// </summary>
        public string FirstName { get; set; } = string.Empty;

        /// <summary>
        /// Last name of the administrator.
        /// </summary>
        public string LastName { get; set; } = string.Empty;

        /// <summary>
        /// Role or title of the administrator (e.g., System Admin, Registrar).
        /// </summary>
        public string Role { get; set; } = string.Empty;

        /// <summary>
        /// Default constructor for Administrator.
        /// </summary>
        public Administrator() { }

        /// <summary>
        /// Parameterized constructor for Administrator.
        /// </summary>
        /// <param name="id">Administrator ID</param>
        /// <param name="firstName">First name</param>
        /// <param name="lastName">Last name</param>
        /// <param name="role">Role or title</param>
        public Administrator(int id, string firstName, string lastName, string role)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Role = role;
        }

        /// <summary>
        /// Returns a string representation of the administrator.
        /// </summary>
        public override string ToString()
        {
            return $"{FirstName} {LastName} (ID: {Id}, Role: {Role})";
        }
    }
}