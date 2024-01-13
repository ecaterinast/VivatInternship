using Microsoft.AspNetCore.Mvc;
using VivatInternship.Backend.Data;
using VivatInternship.Backend.Data.DbModel;
using VivatInternship.Backend.Models;

namespace VivatInternship.Backend.Controllers
{
     [Route("api/[controller]")]
     [ApiController]
     public class ItemController : ControllerBase
     {
          private BasketContext _basketContext;
          public ItemController(BasketContext dbContext)
          {
               _basketContext = dbContext;
          }
          
          [HttpPost]
          public void AddItemToBasket(ItemModel item) 
          {
               _basketContext.SaveChanges();
          }
          [HttpGet]
          public Item GetItemByBarcode(string barcode)
          {
               var items = _basketContext.Items; 
               Item item = items.FirstOrDefault(n => n.Barcode == barcode);
               return item;
          }
          [HttpDelete]
          public void DeleteItemFromBasket(Item item, string basketId)
          {
               _basketContext.SaveChanges();
          }
     }
}
                         ;





