using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structual.DependencyInjection
{
    public class SoftwareLicenseOperation : ILicense
    {
        public void Activate()
        {
            Console.WriteLine("Activating Software License.");
        }

        public void Deactivate()
        {
            Console.WriteLine("Deactivating Software License.");
        }

        public void Renew()
        {
            Console.WriteLine("Renewing Software License.");
        }
    }
}
