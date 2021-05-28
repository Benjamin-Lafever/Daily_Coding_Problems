using System;

//A permutation can be specified by an array P, where P[i] represents the location of the element at i in the permutation. 
//For example, [2, 1, 0] represents the permutation where elements at the index 0 and 2 are swapped.

//Given an array and a permutation, apply the permutation to the array. 
//For example, given the array ["a", "b", "c"] and the permutation [2, 1, 0], return ["c", "b", "a"].


namespace Permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] starting_array = { 'a', 'b', 'c' };
            int[] new_positions = { 2, 1, 0 };
            char[] permutated_array = (char[])starting_array.Clone();
            int position = 0;

           for(int i = 0; i < new_positions.Length; i++)
           {
                permutated_array[position] = starting_array[new_positions[i]];
                position++;
           }

           for(int i = 0; i < permutated_array.Length; i++)
            {
                Console.WriteLine(permutated_array[i]);
            }
        }
    }
}
