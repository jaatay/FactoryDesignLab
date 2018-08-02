using System;

namespace FactoryDesign.Classes
{
    class DocumentFactory
    {
        public static Document CreateDocument(string documentType)
        {
            Document document = null;

            switch (documentType.ToLower())
            {
                case "resume":
                    document = new Resume();
                    break;
                case "divorce":
                    document = new DivorcePapers();
                    break;
                default:
                    break;
            }

            return document;
        }
    }
}
