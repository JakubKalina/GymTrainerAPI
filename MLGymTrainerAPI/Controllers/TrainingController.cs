using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MLGymTrainerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingController : ControllerBase
    {

        // Add new training history
        [HttpPost]
        public IActionResult AddExercise()
        {
            return NotFound();
        }

        // Get performance prediction
        [HttpGet]
        public IActionResult GetExercisePrediction()
        {
            return NotFound();
        }

        // Get user's training history
        [HttpGet]
        public IActionResult GetTrainingHistory()
        {
            return NotFound();
        }
        
    }
}