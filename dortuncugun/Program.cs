using System;

namespace dortuncugun
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.ID = 1;
            product.CategoryId = 2;
            product.ProductName = "Masa";
            product.UnitPrice = 500;
            product.UnitsInStock = 3;

            Product product1 = new Product
            {
                ID = 2,
                CategoryId = 5,
                ProductName = "kalem",
                UnitsInStock = 56,
                UnitPrice = 45,

            };
            //Referans tiplerini newlemek gerekir
            // PascalCase // camelCase
            ProductManager productManager = new ProductManager();
            //               stack tarafı = heap tarafı
            productManager.Add(product);

            // int /double / bool .. deger tip
            // diziler // class // abstract class / interface referans tiplerdir

          




        }
    }
}
