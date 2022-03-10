using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using PhoneBookAPI.BLL.Interfaces;
using PhoneBookAPI.DAL.Entities;
using System.Threading.Tasks;

namespace PhoneBookAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{id}")]
        public Task<User> Get(int id) => _userService.GetAsync(id);

        [HttpPut]
        public void Update(User model) => _userService.Update(model);

        [HttpDelete]
        public void Delete(User model) => _userService.Delete(model);

        [HttpPost]
        public User Add(User model) => _userService.Add(model);

    }
}
