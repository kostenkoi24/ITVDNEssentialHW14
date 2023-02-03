using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Homework14_4
{
    static class Program
    {
        static void Main(string[] args)
        {

            /*
             Використовуючи Visual Studio, створіть проект за шаблоном Console 
            Application. Створіть метод, що розширює: public static T[ ] GetArray(this IEnumerable list){…} 
            Застосуйте розширюючий метод до екземпляра типу MyList, розробленого в домашньому завданні 2 для даного уроку. 
            Виведіть на екран значення елементів масиву, який повернув метод GetArray(), що розширює метод.
             
             */

            

            MyList<int> myList = new MyList<int>();

            myList.Add(999);
            myList.Add(888);
            myList.Add(666);

            Console.WriteLine(myList.Count);

            Console.WriteLine(myList[2]);


            foreach (int list in myList)
            {
                Console.WriteLine($"Name: {list}");
            }

            var res = GetArray<int>(myList);

            foreach (var t in res)
            {
                Console.WriteLine($"Result of GetArray {t}");
            }

            Console.ReadKey();

                       

        }



        public static T[] GetArray<T>(this IEnumerable list) 
        {
            return (T[])list.Cast<T>().ToArray();
        }
    }
}
