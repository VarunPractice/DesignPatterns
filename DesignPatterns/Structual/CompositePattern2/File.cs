using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structual.CompositePattern2
{

    //Leaf
    class File : IDocumentComponent
    {
        public void PerformOperation()
        {
            Console.WriteLine("Performing operation on file.");
        }

         
    }
}
