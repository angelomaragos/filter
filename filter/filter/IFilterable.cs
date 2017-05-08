using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UML.Assignment8
{
    interface IFilterable<T>
    {
        bool ElementBelongs(T element, Func<T, bool> filterF);
    }
}
