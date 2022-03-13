using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{


    class Program
    {
        static void Add(int index, string obj, List<string> list)
        {
            list.Insert(index, obj);
        }
        static string Get(int index, List<string> list)
        {
            if (list.Count < index)
            {
                Console.Write("Error of Out Of index");
                return "none";
            }

            return list[index];
        }
        static bool IsEmpty(List<string> list)
        {
            if (list.Count == 0)
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {

            //1
            int[] someYears = new int[] { 2000, 2001, 1994, 1900, 2024, 2025, 2016, 2027, 2028, 1902 };
            IEnumerable<int> leapYears = someYears.Where(x => (x % 4 == 0 && x % 100 != 0) || (x % 400 == 0));

            Console.WriteLine("Leap years= ");
            foreach (int year in leapYears) Console.WriteLine(year);

            //2
            string a = "blue";
            string b = "green";
            string c = "purple";
            string d = "pink";


            List<string> ColorList = new List<string>();
            ColorList.Add(a);
            ColorList.Add(b);


            Add(0, c, ColorList); // Method of add
            Console.WriteLine(Get(5, ColorList)); // Method of get
            Console.WriteLine(IsEmpty(ColorList)); //  Method of IsEmpty


        }



    }

}
