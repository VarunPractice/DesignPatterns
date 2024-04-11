using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structual.BridgePattern
{
    
    interface ILicenseImplementor
    {
        void Activate();
        void Deactivate();
    }
}
