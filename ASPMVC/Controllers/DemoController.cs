using Microsoft.AspNetCore.Mvc;

namespace ASPMVC.Controllers
{
    public class DemoController : Controller
    {
        private readonly ILogger<DemoController> _logger;

        public DemoController(ILogger<DemoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return Ok("Bienvenu dans la démo!");
        }

        [Route("DemoRouting")]
        [Route("Demo/Routing")]
        [Route("Demo/RoutingAttribute")]
        public IActionResult RoutingAttribute()
        {
            return Ok("J'ai atteint /Demo/RoutingAttribute à l'aide d'un RouteAttribute");
        }
    }
}
