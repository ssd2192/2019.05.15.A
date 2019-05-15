﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _739379_15_05_2019_A
{
    class Program
    {
        public static void Main()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            var smallests = GetSmallests(numbers, 3);

            foreach (var number in smallests)
                Console.WriteLine(number);
        }
        public static List<int> GetSmallests(List<int> list, int count)
        {
            var smallests = new List<int>();

            while (smallests.Count < count)
            {
                var min = GetSmallest(list);
                smallests.Add(min);
                list.Remove(min);
            }
            return smallests;
        }

        public static int GetSmallest(List<int> list)
        {
            // Assume the first is the smallest
            var min = list[0];

            for (var i = 1; i < list.Count; i++)
            {
                if (list[i] > min)
                {
                    min = list[i];
                }
            }

            return min;
        }
    }
}
