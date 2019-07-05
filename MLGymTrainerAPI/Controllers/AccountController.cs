using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MLGymTrainerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {

        // Login User
        [HttpPost]
        public IActionResult Login()
        {
            return NotFound();
        }
        
        // Register user - create an account
        [HttpPost]
        public IActionResult Register()
        {
            return NotFound();
        }

        // Create link to reset password - sent to user via email
        [HttpPut]
        public IActionResult ResetPassword()
        {
            return NotFound();
        }

        // Delete user's account
        [HttpDelete]
        public IActionResult DeleteAccount()
        {
            return NotFound();
        }
        
    }
}