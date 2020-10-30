using System;

namespace nuget_consuming_test
{
    public class Product
    {
        public string Name => "Apple";
        public DateTime ExpiryDate => new DateTime(2008, 12, 28);
        public decimal Price => 3.99M;
        public string[] Sizes => new string[] { "Small", "Medium", "Large" };
    }
}