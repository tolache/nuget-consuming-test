using System;

namespace nuget_consuming_test
{
    public class ProductSerializer
    {
        private Product _product = new Product();
        public string GetProductName
        {
            get
            {
                Console.WriteLine("Returning the product name.");
                return "TBD";
            }
        }
    }
}