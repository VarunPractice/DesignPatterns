using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Creational.FactoryPattern;
namespace DesignPatterns.Creational.FactoryPattern
{
    public class DocumentFactory
    {
        public static IDocument GetDocument(string type)
        {
            switch (type)
            {
                case "word":
                    return new WordDocument();
                
                case "pdf":
                    return new PDFDocumentClass();
                 
                    default: throw new ArgumentException("Invalid Type", nameof(type)); break;
            }
         
        }
    }
}
