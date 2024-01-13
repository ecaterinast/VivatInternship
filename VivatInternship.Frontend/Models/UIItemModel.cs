using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivatInternship.Frontend.Models
{
    public class UIItemModel
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Barcode { get; set; }
        public int Quantity { get; set; }
    }
}
