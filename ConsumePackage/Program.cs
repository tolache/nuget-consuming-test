using System;

namespace nuget_consuming_test
{
    static class Program
    {
        static void Main(string[] args)
        {
            ProductSerializer serializer = new();
            Console.WriteLine(serializer.GetProductName);
        }
    }
}
