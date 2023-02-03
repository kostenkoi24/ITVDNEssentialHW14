using System;
using System.Collections.Generic;
using System.Text;

namespace Homework14_4
{
    interface IMyList<in T>
    {
        void Add(T item);

        public int Count { get; }


    }
}
