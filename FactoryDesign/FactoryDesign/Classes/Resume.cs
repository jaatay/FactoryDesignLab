using System;

namespace FactoryDesign.Classes
{
    public abstract class Resume
    {
        public void Prepare()
        {
            Console.WriteLine("Go get a job.");
        }

        public void Write()
        {
            Console.WriteLine("Do all the things.");
        }
    }
}
