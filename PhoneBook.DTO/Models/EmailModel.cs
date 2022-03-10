using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookAPI.DTO.Models
{
    class EmailModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Email { get; set; }
        public bool IsMain { get; set; }
        public UserModel User { get; set; }
    }
}
