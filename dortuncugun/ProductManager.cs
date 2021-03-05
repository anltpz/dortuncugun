using System;
using System.Collections.Generic;
using System.Text;

namespace dortuncugun
{
    class ProductManager  //crud işlemlerinin yapıldıgı yerler
    {
        //encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+"eklendi");
            Console.WriteLine();
        }
        public void Update (Product product)
        {
            Console.WriteLine(product.ProductName+"guncellendi");

        }

       
    }

}
