using System;
using System.Collections.Generic;

namespace Homework14_2
{

      

    class Program
    {
        static void Main(string[] args)
        {
            

            

            MyList<int> myList = new MyList<int>();

            myList.Add(1);
            myList.Add(2);
            myList.Add(33);

            Console.WriteLine(myList.Count);

            Console.WriteLine(myList[2]);


            foreach (int list in myList)
            {
                Console.WriteLine($"Name: {list}");
            }



            Console.ReadKey();
            


        }
    }
}
