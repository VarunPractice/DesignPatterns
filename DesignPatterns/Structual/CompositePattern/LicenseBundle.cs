using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structual.CompositePattern
{
    //composite
    class LicenseBundle : ILicenseComponent
    {
        private List<ILicenseComponent> licenses = new List<ILicenseComponent>();

        public void Add(ILicenseComponent license)
        {
            licenses.Add(license);
        }

        public void Remove(ILicenseComponent license)
        {
            licenses.Remove(license);
        }

        public void Process()
        {
            Console.WriteLine("Processing a bundle of licenses.");
            foreach (var license in licenses)
            {
                license.Process();
            }
        }
    }
}
