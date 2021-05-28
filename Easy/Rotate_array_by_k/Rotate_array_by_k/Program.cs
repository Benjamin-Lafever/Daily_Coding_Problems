using System;

namespace Rotate_array_by_k
{
    class Program
    {
        public static string[] array = {"a", "b", "c", "d", "e", "f", "g"};
        static string[] shifted_Array = new string[array.Length];
        static int k;

        static void Main(string[] args)
        {
            retry:;
            Console.WriteLine("Enter a number for the array to shift by: \n");
            try
            {
                k = Int32.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine($"Unable to parse '{k}'");
                goto retry;
            }
            Console.WriteLine("Array before the shift = ");
            Console.WriteLine("[{0}]", string.Join(", ", array));
            shifted_Array = Shift_program.shift_Array(array, k, shifted_Array);
            Console.WriteLine("Array after the shift = ");
            Console.WriteLine("[{0}]", string.Join(", ", shifted_Array));
            Console.ReadLine();
 
        }
    }
}
