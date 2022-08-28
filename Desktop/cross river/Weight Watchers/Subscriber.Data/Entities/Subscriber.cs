using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Subscriber.Data.Entities
{
    [Index("Email",IsUnique=true)]
    public class Subscriber
    {
        [Key]
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        [Required]
        [MinLength(8)]  
        public string  Password { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
