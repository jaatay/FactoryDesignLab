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
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }

        public static void DocumentCreateTest()
        {
            Document document = null;
            DocumentCreator documentCreator = new DocumentCreator();
            document = documentCreator.OrderDocument("divorce");
        }
    }
}
