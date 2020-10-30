using System;
using Newtonsoft.Json;

namespace nuget_consuming_test
{
    public class ProductSerializer
    {
        private Product _product = new Product();
        public string SerializedProduct
        {
            get
            {
                string output = JsonConvert.SerializeObject(_product);;
                Console.WriteLine(output);
                return output;
            }
        }
    }
}