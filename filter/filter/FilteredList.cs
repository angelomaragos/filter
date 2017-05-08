using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UML.Assignment8
{
    class FilteredList<T> : List<T>, IFilterable<T>
    {
        public bool ElementBelongs(T element, Func<T, bool> filterF)
        {
            return filterF(element);
        }



    }
}
