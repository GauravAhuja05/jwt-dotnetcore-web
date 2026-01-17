using Microsoft.AspNetCore.Mvc;

namespace JwtApp.Controllers
{
    public class VoiceAPIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
