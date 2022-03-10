using System.ComponentModel.DataAnnotations;

namespace PhoneBookAPI.DAL.Entities
{
    public class Phones : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public bool IsMain { get; set; }

        [Required]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$", ErrorMessage = "The PhoneNumber is not a valid")]
        public string PhoneNumber { get; set; }
        
        public User User { get; set; }
    }
}
