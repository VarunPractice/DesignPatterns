using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryPattern
{
    public class PDFDocumentClass : IDocument
    {
        public IDocument CreateDocument()
        {
            Console.WriteLine("PDF Doc Created"); return this;
        }

        public void OpenDocument(string path)
        {
            Console.WriteLine("PDF Doc opened");
        }
    }
}
