using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Homework14_3 
{


    class MyDictionary //: IEnumerable //, IEnumerator
    {
        string [] dictionaryKeys;
        string [] dictionaryValues;
        int length;


        public MyDictionary()
        {
            dictionaryKeys = null;
            dictionaryValues = null;
        }


        public int Length { get => length; }



        public void Add(string key, string value)
        {

            if (dictionaryKeys == null)
            {
                dictionaryKeys = new string[1];
                dictionaryValues = new string[dictionaryKeys.Length];
            }
            else
            {
                length = dictionaryKeys.Length;
                Array.Resize<string>(ref dictionaryKeys, length + 1);
                Array.Resize<string>(ref dictionaryValues, length + 1);
            }


            dictionaryKeys[length] = key;
            dictionaryValues[length] = value;
        }

        public string this[int index]
        {
            get
            {
                if (index < dictionaryValues.Length)
                {
                    return dictionaryValues[index];
                }
                else
                {
                    return default;
                }

            }
        }

        int position = -1;

        public bool MoveNext()
        {
            if (position < dictionaryKeys.Length - 1)
            {
                position++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }
        }

        public void Reset()
        {
            position = -1;
        }

        public string /*object*/ Current
        {
            get { return dictionaryValues[position]; }
        }

        //public IEnumerator GetEnumerator()
        public MyDictionary GetEnumerator()
        {
            return this;
        }

    }
}
