using System;
using System.Collections.Generic;
using System.Text;

namespace _4Hafta
{
    class ProductManager
    {
        public void AddProduct(Product product)
        {
            Console.WriteLine(product.ProductName + " Eklendi");
        }
        public void UpdateProduct(Product product)
        {

            Console.WriteLine(product.ProductName + " Güncelleme işlemi başarılı");

        }

        public int Topla(int sayi1 , int sayi2)
        {

            return sayi1 + sayi2;
        }
    }
}
