using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Items
    {
        public string ItemCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string UrlImage { get; set; }
        public decimal Price { get; set; }

        public Trademarks TradeDesciption { get; set; }

        public Category CategoryDescription { get; set; }
    }
}
