using System;

//A number is considered perfect if its digits sum up to exactly 10.

//Given a positive integer n, return the n-th perfect number.

//For example, given 1, you should return 19. Given 2, you should return 28

namespace Perfect_number
{
    class Program
    {
        public static int perfect_num { get; set; }
        public static string user_input { get; set; }
        static void Main(string[] args)
        {
            user_conversation();
            perfect_Number(Int32.Parse(user_input));
            repeat();
        }
        public static void repeat()
        {
            Console.WriteLine("Your perfect number is " + user_input);
            Console.WriteLine("enter y or yes to run again, type anything else to exit");
            string ans = Console.ReadLine();
            if (ans.Contains('y'))
            {
                user_conversation();
                perfect_Number(int.Parse(user_input));
                repeat();
            }
        }
        public static void user_conversation()
        {
            Console.WriteLine("Enter a number 1 - 9, and the perfect number will return");
            user_input = Console.ReadLine();
        }
        public static void perfect_Number(int n)
        {
            int perfect_add = 10 - n;

            user_input = n.ToString() + perfect_add.ToString();
        }
    }
}
