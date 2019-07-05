using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MLGymTrainerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DietController : ControllerBase
    {
        // Get user's BMI result
        [HttpGet]
        public IActionResult GetBmi()
        {
            return NotFound();
        }

        // Get user's daily caloric needs
        [HttpGet]
        public IActionResult GetCaloricNeeds()
        {
            return NotFound();
        }

        // Get user's daily macronutrients
        [HttpGet]
        public IActionResult GetMacronutrientsNeeds()
        {
            return NotFound();
        }
        
    }
}