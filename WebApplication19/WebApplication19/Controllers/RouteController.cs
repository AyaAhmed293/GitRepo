using Microsoft.AspNetCore.Mvc;

namespace WebApplication19.Controllers
{
    public class RouteController : Controller
    {
        public IActionResult Index(int id ,string name)
        {
            return Content(name);
        }
        [Route("Show/{msg:alpha}")]
        public ActionResult Show(string msg)
        { return Content(msg); }
    }
}
