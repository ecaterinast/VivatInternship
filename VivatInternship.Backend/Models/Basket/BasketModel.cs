using Microsoft.EntityFrameworkCore;
using VivatInternship.Backend.Data;

namespace VivatInternship.Backend.Models.Basket
{

    public class BasketModel
    {
        public double Total { get; set; }
        public List<Item> Items { get; set; }

    }
}
