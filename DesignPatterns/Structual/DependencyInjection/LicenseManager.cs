using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structual.DependencyInjection
{
    public class LicenseManager
    {
        private ILicense license {  get; set; }

        public LicenseManager(ILicense license )
        {
            this.license = license;
            
        }
        public void InstallLic()
        {
            license.Activate();
        }
        public void ReturnLic()
        {
            license.Deactivate();
        }
       
    }
}
