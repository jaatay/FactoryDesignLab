using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesign.Classes
{
     public class DocumentCreator: DocumentStore
    {

        protected override Document CreateDocument(string type)
        {
            Console.WriteLine("May good fortune befall you. Hopefully you didn't pick divorce papers.");

            return DocumentFactory.CreateDocument(type);
        }
    }
}