using FactoryDesign.Classes;
using System;

namespace FactoryDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DocumentCreateTest();
        }

        public static void DocumentCreateTest()
        {
            Document document = null;
            DocumentCreator documentCreator = new DocumentCreator();
            document = documentCreator.OrderDocument("divorce");
        }
    }
}
