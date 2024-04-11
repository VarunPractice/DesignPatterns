using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structual.BridgePattern2
{
    class WordDocumentHandler : DocumentHandler
    {
        public WordDocumentHandler(IStorageImplementor storageImplementor) : base(storageImplementor) { }

        public override void SaveDocument(string content)
        {
            Console.WriteLine("Processing Word document");
            storageImplementor.Save(content);
        }

        public override void LoadDocument()
        {
            Console.WriteLine("Loading Word document");
            storageImplementor.Load();
        }
    }

}
