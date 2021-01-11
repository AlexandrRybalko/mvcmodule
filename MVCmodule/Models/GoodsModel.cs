using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCmodule.Models
{
    public class GoodsModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public DateTime DeliveryDate { get; set; }
        public decimal Price { get; set; }
    }
}