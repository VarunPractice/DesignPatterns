using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.AbstractFactoryPattern
{
    public class InvoiceFooter : Footer
    {
        private string _footer { get; set; }
        public InvoiceFooter(string footer)
        {
            _footer = footer;
        }
        
    }
}
