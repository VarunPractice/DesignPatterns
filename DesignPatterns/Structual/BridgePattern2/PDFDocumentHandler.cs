using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structual.BridgePattern2
{
    class PdfDocumentHandler : DocumentHandler
    {
        public PdfDocumentHandler(IStorageImplementor storageImplementor) : base(storageImplementor) { }

        public override void SaveDocument(string content)
        {
            Console.WriteLine("Processing PDF document");
            storageImplementor.Save(content);
        }
        public override void LoadDocument()
        {
            Console.WriteLine("Loading PDF document");
            storageImplementor.Load();
        }
    }
}
