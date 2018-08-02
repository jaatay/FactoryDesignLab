using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesign.Classes
{
    public abstract class DocumentStore
    {

        protected abstract Document CreateDocument(string type);

        public Document OrderDocument(string type)
        {
            Document document = CreateDocument(type);

            document.Prepare();
            document.Write();

            return document;
        }
    }
}
