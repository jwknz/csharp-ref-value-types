using System;
using System.Collections.Generic;

namespace refvaltype
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Classes = reference types (Arrays and lists<T> are both classes)
                Structs = value types
            */

            Console.WriteLine("DATE TIME = STRUCT");

            //DateTime is a struct (value type, creates a copy of...)
            DateTime date = new DateTime(2010, 1, 1);
            DateTime datecopy = date; //copy the value of date into a new variable 

            date = date.AddYears(1); //change the first variable

            Console.WriteLine(date.Year); // returns 2011
            Console.WriteLine(datecopy.Year); // returns 2010


            //Array is a class (reference type, references to the original variables)
            Console.WriteLine("ARRAY = CLASS");

            int[] number = new int[] {1, 2, 3, 4, 5};
            int[] numberCopy = number;

            number[0] = 10;

            Console.WriteLine(string.Join(",", number));
            Console.WriteLine(string.Join(",", numberCopy));

        }
    }
}
