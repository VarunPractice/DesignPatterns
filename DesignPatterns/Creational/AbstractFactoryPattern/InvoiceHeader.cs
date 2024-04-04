using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.AbstractFactoryPattern
{
    public class InvoiceHeader: Header
    {
        private string _header { get; set; }
        public InvoiceHeader(string header) => _header = header;
         
    }
}
