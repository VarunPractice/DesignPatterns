using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structual.BridgePattern2
{

    class LocalStorageImplementor : IStorageImplementor
    {
        public void Save(string content)
        {
            Console.WriteLine($"Saving to local storage: {content}");
        }

        public void Load()
        {
            Console.WriteLine("Loading from local storage");
        }
    }
}
