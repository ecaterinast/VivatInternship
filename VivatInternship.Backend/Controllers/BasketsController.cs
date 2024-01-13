using Microsoft.AspNetCore.Mvc;
using VivatInternship.Backend.Data.DbModel;


namespace VivatInternship.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketsController : ControllerBase
    {
        private BasketContext _basketContext;
        public BasketsController(BasketContext dbContext)
        {
            _basketContext = dbContext;
        }
        [Route("CreateNewBasket")]
        [HttpPost]
        public void CreateNewBasket(string userId)
        {
            _basketContext.SaveChanges();
        }
    }
}
