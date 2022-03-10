using System.ComponentModel.DataAnnotations;

namespace PhoneBookAPI.DAL.Entities
{
    public class Emails : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public bool IsMain { get; set; }

        [Required]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Email address is not valid")]
        public string Email { get; set; }
        
        public User User { get; set; }
    }
}