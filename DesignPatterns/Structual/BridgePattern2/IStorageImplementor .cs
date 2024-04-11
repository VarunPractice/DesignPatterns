using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structual.BridgePattern2
{
    interface IStorageImplementor
    {
        void Save(string content);
        void Load();
    }
}
