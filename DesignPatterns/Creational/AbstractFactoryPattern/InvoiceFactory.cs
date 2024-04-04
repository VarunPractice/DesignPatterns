using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.AbstractFactoryPattern
{
    public class InvoiceFactory : IDocumentFactory
    {
        public Footer SetFooter(string footer) => new InvoiceFooter(footer);
      

        public Header SetHeader(string header)=> new InvoiceHeader(header);
       
    }
}
