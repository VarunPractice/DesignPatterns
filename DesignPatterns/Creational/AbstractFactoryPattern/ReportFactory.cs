using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.AbstractFactoryPattern
{
    public class ReportFactory : IDocumentFactory
    {
        public Header SetHeader(string content)
        {
            return new ReportHeader { Content = content };
        }

        public Footer SetFooter(string content)
        {
            return new ReportFooter { Content = content };
        }
    }


}
