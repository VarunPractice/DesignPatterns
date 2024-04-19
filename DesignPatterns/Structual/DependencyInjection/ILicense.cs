using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structual.DependencyInjection
{
    public interface ILicense
    { 
        void Activate();
        void Deactivate();
        void Renew();
    }
   

   

}
