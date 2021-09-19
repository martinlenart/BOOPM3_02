using System;

namespace BOOPM3_02_07
{
    class Program
    {
        static int Sum(params int[] ints)
        {
            int sum = 0;
            for (int i = 0; i < ints.Length; i++)
                sum += ints[i];
            return sum;
        }
        static void Main(string[] args)
        {
            int total = Sum(1, 2, 3, 4);
            Console.WriteLine(total);  // 10

            // The call to Sum above is equivalent to:
            int total2 = Sum(new int[] { 1, 2, 3, 4 });
            Console.WriteLine(total2); // 10
        }
    }

    //Exercises
    //1.    Create a class type and declare a method taking params of that type. Create a single dimension array of the 
    //      type and calling the method both with comma separated list and as an array
    //2.    Make the array multidimensional and try. What happens?
}
