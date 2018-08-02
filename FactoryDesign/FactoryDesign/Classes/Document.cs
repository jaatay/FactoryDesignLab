using System;

namespace FactoryDesign.Classes
{
    public abstract class Document
    {
        public void Prepare()
        {
            Console.WriteLine("Choose your fate. We are preparing the document.");
        }

        public void Write()
        {
            Console.WriteLine("Do all the things. We are writing the document.");
        }
    }
}
