﻿using System;
using System.Collections.Generic;
namespace randomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random random = new Random();
            List<int> numbers = new List<int> {
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
            };

            for (int i=0; i<numbers.Count; i++) {
            // Determine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.
                if(numbers.Contains(i)){
                    Console.WriteLine($"Yes, {i} is in numbers list");
                }else{
                    Console.WriteLine($"No, the index, {i} is not in the numbers' list.");
                }
            
            }
        }
    }
}
