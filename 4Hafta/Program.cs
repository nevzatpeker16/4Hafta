using System;

namespace _4Hafta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Product product1 = new Product();
            product1.ProductID = 1;
            product1.ProductCategory = 1;
            //1 numaralı kategori , mobilya olsun.
            product1.ProductName = "Masa";
            product1.ProductPrice = 500;
            product1.ProductStock = 3;


            Product product2 = new Product
            {
                ProductID = 2,
                ProductCategory = 2,
                ProductName = "Kalem",
                ProductPrice = 15,
                ProductStock = 1500
            };
            //product kategorisi 2  , kırtasiyedir.


            ProductManager productManager = new ProductManager();
            productManager.AddProduct(product1);

            //Add product artık product tipinde bir nesne bekliyor . 
            //product 2 ve product1 artık buraya gönderilebilir.


            int toplam = productManager.Topla(3, 2);
            Console.WriteLine("Toplam = {0}",toplam);
        }
    }
}
