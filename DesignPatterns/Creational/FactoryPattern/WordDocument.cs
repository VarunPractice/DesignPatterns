using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryPattern
{
    public class WordDocument : IDocument
    {
        public IDocument CreateDocument()
        {
            Console.WriteLine("Word Doc Created"); return this;
        }

        public void OpenDocument(string path)
        {
            Console.WriteLine("Word Doc opened");  
        }
    }
}
