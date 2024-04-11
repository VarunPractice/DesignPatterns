using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BridgePattern2
{
    abstract class DocumentHandler
    {
        protected IStorageImplementor storageImplementor;

        protected DocumentHandler(IStorageImplementor storageImplementor)
        {
            this.storageImplementor = storageImplementor;
        }

        public abstract void SaveDocument(string content);
        public abstract void LoadDocument();
    }
}
