using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structual.ProtoTypePattern
{
    public class License : ICloneable<License>
    {
        public string LicenseKey { get; set; }  
        public string Owner {  get; set; }  

        public License Clone()
        {
            return (License)this.MemberwiseClone();
        }
    }
}
