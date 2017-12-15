using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.ComTypes;

namespace src.ProductCatalog
{
    public class ProductCatalog
    {
        public List<Product> Products { get; set; }
        public ProductCatalog(List<Product> products)
        {
            Products = products;
        }

        public List<Product> SortBasedOnPricePerCategory()
        {
            var output = new List<Product>();
            
            var Y = Products.GroupBy(x => x.Category);
            foreach (var group in Y)
            {
                var result1= group.OrderBy(i => i.Price);
                output.AddRange(result1.ToList());
            }
           
            return output;
        }
    }
}
