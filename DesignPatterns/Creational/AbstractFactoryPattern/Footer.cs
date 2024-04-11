using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structual.AbstractFactoryPattern
{
    public abstract class Footer
    {
        public string Content { get; set; }
        public void Show() => Console.WriteLine(Content);
    }
}
