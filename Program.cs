using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 1, 3, 5, 6 };
            //int val = 5;

            //int[] arr = { 1, 3, 5, 6};
            int[] arr = { 1, 3, 5, 6 };
            int val = -1;
            Console.WriteLine(SearchInsert(arr, val));
            Console.ReadKey();
        }

        public static int SearchInsert(int[] nums, int target)
        {
            int index = 0;
            if (nums.Length == 0)
                return 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                    return i;
                else if (target > nums[i])
                    index = i + 1;

            }

            return index;
        }


    }

}
