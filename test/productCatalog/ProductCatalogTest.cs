using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using src.ProductCatalog;

namespace test.ProductCatalog
{
/*
ProductCatalog.sortBasedOnPricePerCategory should return the list of all Products sorted by
their price WITHIN their category.
*/
    [TestClass]

    public class ProductCatalogTest
    {
        [TestMethod]
        public void SortProductsBasedOnPricePerCategory()
        {
            Product product1 = new Product("Mobile", 2500);
            Product product2 = new Product("Laptop", 3500);
            Product product3 = new Product("Mobile", 1000);
            Product product4 = new Product("Laptop", 1500);
            Product product5 = new Product("TV", 10000);
            Product product6 = new Product("TV", 10500);

            List<Product> products = new List<Product>{product1, product2, product3, product4, product5, product6};
            src.ProductCatalog.ProductCatalog catalog = new src.ProductCatalog.ProductCatalog(products);
            List<Product> sortedList = catalog.SortBasedOnPricePerCategory();

            Assert.AreEqual(sortedList[0], product3);
            Assert.AreEqual(sortedList[1], product1);
            Assert.AreEqual(sortedList[2], product4);
            Assert.AreEqual(sortedList[3], product2);
            Assert.AreEqual(sortedList[4], product5);
            Assert.AreEqual(sortedList[5], product6);
        }
    }
}
