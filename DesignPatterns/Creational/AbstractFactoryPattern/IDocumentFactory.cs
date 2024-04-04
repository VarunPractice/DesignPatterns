using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.AbstractFactoryPattern
{
    public interface IDocumentFactory
    {
        Header SetHeader(string content);
        Footer SetFooter(string content);
    }

}
