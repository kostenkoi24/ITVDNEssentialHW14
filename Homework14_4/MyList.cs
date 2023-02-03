using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Homework14_4
{

    public class MyList<T> : IMyList<T>, IEnumerable
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
                return _items[index];
            }

            set
            {
                _items[index] = value;
            }
        }



        int position = -1;

        public void Reset()
        {
            position = -1;
        }


        public IEnumerator GetEnumerator()
        {
            while (true)
            {
                if (position < _items.Length - 1)
                {
                    position++;
                    yield return _items[position];
                }
                else
                {
                    Reset();
                    yield break;
                }
            }
        }


    }




}
