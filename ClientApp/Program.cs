using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductServiceRef.ProductServiceClient client
               = new ProductServiceRef.ProductServiceClient();

            client.SetProductQty(10);
            Console.WriteLine(string.Format("Current Product Qty: {0}", client.GetProductQty()));

            client.SetProductQty(20);
            Console.WriteLine(string.Format("Current Product Qty: {0}", client.GetProductQty()));
            Console.WriteLine(string.Format("Current Product Qty: {0}", client.GetProductQty()));

            client.Close();

            client = new ProductServiceRef.ProductServiceClient();
            Console.WriteLine(string.Format("Current Product Qty: {0}", client.GetProductQty()));

            Console.Read();
        }
    }
}
