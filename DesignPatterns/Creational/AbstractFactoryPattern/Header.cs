using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.AbstractFactoryPattern
{
    public abstract class Header
    {
        public string Content { get; set; }
        public void Show() => Console.WriteLine(Content);
    }

}
