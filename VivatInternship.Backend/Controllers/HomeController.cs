using Microsoft.AspNetCore.Mvc;
using VivatInternship.Backend.Data.DbModel;

namespace VivatInternship.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        private readonly BasketContext _context;

        public HomeController(BasketContext context)
        {
            _context = context;
        }
    }
}
