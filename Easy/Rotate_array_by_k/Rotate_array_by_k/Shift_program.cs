using System;
using System.Collections.Generic;
using System.Text;

namespace Rotate_array_by_k
{
    class Shift_program
    {
        static int true_Shift;
        static int array_Length;

        public static string[] shift_Array(string[] array, int shift_Length, string[] shifted_Array)
        {
            array_Length = array.Length - 1;
            if(shift_Length > array_Length)
            {
                true_Shift = shift_Length % array_Length;
            }
            else
            {
                true_Shift = shift_Length;
            }
            for( int i = 0; i < array.Length; i++)
            {
                int new_po = i + true_Shift;
                if(new_po == array.Length)
                {
                    new_po = 0;
                }
                if( new_po > array_Length)
                {
                    new_po %= array.Length;
                }


                shifted_Array[new_po] = array[i];
            }
            return shifted_Array;
        }
    }
}

