using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structual.BridgePattern
{
    class TemporaryLicense : License
    {
        public TemporaryLicense(ILicenseImplementor implementor) : base(implementor) { }

        public override void ProcessLicense()
        {
            implementor.Activate();
        }
    }
}
