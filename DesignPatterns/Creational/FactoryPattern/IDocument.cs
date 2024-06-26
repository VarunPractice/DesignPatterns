﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryPattern
{
    public interface IDocument
    {
        IDocument CreateDocument();
        void OpenDocument(string path);

    }
}
