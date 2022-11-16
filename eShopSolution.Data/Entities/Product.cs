using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public decimal Price { set; get; }

        public decimal OriginalPrice { set; get; }
        
        public int Stock { set; get; }
        
        public int ViewCount { set; get; }

        public DateTime DateCreated { set; get; }
        
        public string SeoAlias { set; get; }

        public string Image { get; set; }


        public List<ProductInCategory> ProductInCategories { set; get; }

        public List<OrderDetail> OrderDetails { get; set; }

        public List<Cart> Carts { get; set; }

        public List<ProductTranslation> ProductTranslations { get; set; }
    }
}
