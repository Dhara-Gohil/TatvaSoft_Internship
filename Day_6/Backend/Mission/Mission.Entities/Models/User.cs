using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission.Entities.Models
{
    [Table("users")] // Force lowercase table name for PostgreSQL compatibility
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string UserType { get; set; }
        public string? UserImage { get; set; }
    }
}
