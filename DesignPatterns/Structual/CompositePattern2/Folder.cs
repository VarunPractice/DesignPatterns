using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structual.CompositePattern2
{
    // Composite
    class Folder : IDocumentComponent
    {
        private List<IDocumentComponent> children = new List<IDocumentComponent>();

        public void Add(IDocumentComponent component)
        {
            children.Add(component);
        }

        public void Remove(IDocumentComponent component)
        {
            children.Remove(component);
        }

        public void PerformOperation()
        {
            Console.WriteLine("Performing operation on folder.");
            foreach (var child in children)
            {
                child.PerformOperation();
            }
        }
    }
}
