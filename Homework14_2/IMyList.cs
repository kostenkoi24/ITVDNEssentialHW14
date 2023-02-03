using System;
using System.Collections.Generic;
using System.Text;

namespace Homework14_2
{
    interface IMyList<in T>
    {
        void Add(T item);

        public int Count { get; }

        
    }
}
