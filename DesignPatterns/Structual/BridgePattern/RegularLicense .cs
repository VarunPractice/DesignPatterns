using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structual.BridgePattern
{
    class RegularLicense : License
    {
        public RegularLicense(ILicenseImplementor implementor) : base(implementor) { }

        public override void ProcessLicense()
        {
            implementor.Activate();
            // Additional processing for regular license
        }
    }

}
