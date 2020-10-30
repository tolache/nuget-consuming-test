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
                ProductNameGetter.ProductNameGetter getter = new ProductNameGetter.ProductNameGetter();
                Console.WriteLine("Returning the product name.");
                return getter.GetProductName(_product);
            }
        }
    }
}