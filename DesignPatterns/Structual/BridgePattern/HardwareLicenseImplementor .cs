using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structual.BridgePattern
{
    class HardwareLicenseImplementor : ILicenseImplementor
    {
        public void Activate()
        {
            Console.WriteLine("Activating Hardware License");
        }

        public void Deactivate()
        {
            Console.WriteLine("Deactivating Hardware License");
        }
    }
}
