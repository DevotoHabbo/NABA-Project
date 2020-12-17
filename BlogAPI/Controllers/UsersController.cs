using BlogAPI.Data;
using BlogAPI.Models.UserModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepo _userRepo;
        public UsersController(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        [HttpGet]
        public IEnumerable<UserGetMany> GetUsers()
        {
            return _userRepo.GetUsers();
        }
        [HttpGet("{userId}")]
        public ActionResult<UserGetOne> GetUser(string userId)
        {
            var user = _userRepo.GetUser(userId);
            if(user == null)
            {
                return NotFound();
            }
            return user;
        }
    }
}
