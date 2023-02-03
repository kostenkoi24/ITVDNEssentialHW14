using System;
using System.Collections.Generic;

namespace Homework14_3
{
    class Program
    {
        static void Main(string[] args)
        {

           

            MyDictionary myDictionary = new MyDictionary();


            myDictionary.Add("Akey", "Avalue");
            myDictionary.Add("Bkey", "Bvalue");


            Console.WriteLine(myDictionary.Length);

            Console.WriteLine(myDictionary[0]);
            Console.WriteLine(myDictionary[1]);
            Console.WriteLine(myDictionary[3]); //return default


            foreach (string element in myDictionary)
            {
                Console.WriteLine($"Name:{element}");
            }


            Console.ReadKey();

            
        }
    }
}
