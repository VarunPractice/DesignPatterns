using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structual.DependencyInjection
{
    public class HardwareLicenseOperation : ILicense
    {
        public void Activate()
        {
            Console.WriteLine("Activating Hardware License.");
        }

        public void Deactivate()
        {
            Console.WriteLine("Deactivating Hardware License.");
        }

        public void Renew()
        {
            Console.WriteLine("Renewing Hardware License.");
        }
    }
}
