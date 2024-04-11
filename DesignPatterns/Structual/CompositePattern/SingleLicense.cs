using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structual.CompositePattern
{

    //leaf
    class SingleLicense : ILicenseComponent
    {
        public void Process()
        {
            Console.WriteLine("Processing a single license.");
        }
    }
}
