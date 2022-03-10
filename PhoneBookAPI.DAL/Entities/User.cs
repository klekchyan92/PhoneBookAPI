using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PhoneBookAPI.DAL.Entities
{
    public class User : IEntity
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "FirstName is Required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "LastName is Required")]
        public string LastName { get; set; }

        public string MiddleName { get; set; }
        public string OrganizationName { get; set; }

        public IEnumerable<Phones> Phones { get; set; }
        public IEnumerable<Emails> Emails { get; set; }
    }
}
