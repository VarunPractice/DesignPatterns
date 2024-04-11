﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structual.ProtoTypePattern
{
    public interface ICloneable<T>
    {
        T Clone();
    }

}
