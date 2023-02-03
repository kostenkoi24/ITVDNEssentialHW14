using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Homework14_2
{

    //https://referencesource.microsoft.com/#mscorlib/system/collections/generic/list.cs,cf7f4095e4de7646 :)


    public class MyList<T> : IMyList<T>
    {
        private const int _defaultCapacity = 4;

        private T[] _items;
        private int _size;

        static readonly T[] _emptyArray = new T[0];

        public MyList()
        {
            _items = _emptyArray;
        }


        public MyList(int capacity)
        {
            if (capacity == 0)
                _items = _emptyArray;
            else
                _items = new T[capacity];
        }


        public int Count
        {
            get
            {
                return _size;
            }
        }


        public void Add(T item)
        {
            if (_size == _items.Length) EnsureCapacity(_size + 1);
            _items[_size++] = item;
        }

        private void EnsureCapacity(int min)
        {
            if (_items.Length < min)
            {
                int newCapacity = _items.Length == 0 ? _defaultCapacity : _items.Length * 2;
                if (newCapacity < min) newCapacity = min;
                Capacity = newCapacity;
            }
        }

        public int Capacity
        {
            get
            {
                return _items.Length;
            }
            set
            {
                if (value != _items.Length)
                {
                    if (value > 0)
                    {
                        T[] newItems = new T[value];
                        if (_size > 0)
                        {
                            Array.Copy(_items, 0, newItems, 0, _size);
                        }
                        _items = newItems;
                    }
                    else
                    {
                        _items = _emptyArray;
                    }
                }
            }
        }


        public T this[int index]
        {
            get
            {
                // Following trick can reduce the range check by one
                if ((uint)index >= (uint)_size)
                {
                    //ThrowHelper.ThrowArgumentOutOfRangeException();
                }
                //Contract.EndContractBlock();
                return _items[index];
            }

            set
            {
                if ((uint)index >= (uint)_size)
                {
                    //ThrowHelper.ThrowArgumentOutOfRangeException();
                }
                //Contract.EndContractBlock();
                _items[index] = value;
                //_version++;
            }
        }



    }




}
