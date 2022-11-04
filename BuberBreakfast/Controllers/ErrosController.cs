using Microsoft.AspNetCore.Mvc;

namespace BuberBreakfast.Controllers
{
    public class ErrosController : ControllerBase
    {
        [Route("/error")]
        [NonAction]
        public IActionResult Error()
        {
            return Problem();
        }
    }
}
