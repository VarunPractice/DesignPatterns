using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structual.BridgePattern
{
    abstract class License
    {
        protected ILicenseImplementor implementor;

        protected License(ILicenseImplementor implementor)
        {
            this.implementor = implementor;
        }

        public abstract void ProcessLicense();
    }
}
