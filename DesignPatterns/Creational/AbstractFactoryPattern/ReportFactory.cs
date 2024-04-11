using log4net;
using log4net.Config;
using System.IO;
using System.Reflection;
namespace DesignPatterns.DesignPatterns.Structual.AbstractFactoryPattern
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
