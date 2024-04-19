using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structual.BridgePattern2
{
    class CloudStorageImplementor : IStorageImplementor
    {
        public void Save(string content)
        {
            Console.WriteLine($"Saving to cloud storage: {content}");
        }

        public void Load()
        {
            Console.WriteLine("Loading from cloud storage");
        }
    }
}
