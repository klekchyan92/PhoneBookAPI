using PhoneBookAPI.DAL.Entities;
using PhoneBookAPI.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookAPI.DAL.Repositories
{
    public class EmailRepository : Repository<Emails>, IEmailRepository
    {
        public EmailRepository(PhoneBookContext context) :  base(context)
        {

        }
    }
}
