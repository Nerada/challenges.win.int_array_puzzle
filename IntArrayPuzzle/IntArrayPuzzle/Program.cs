// -----------------------------------------------
//     Author: Ramon Bollen
//       File: IntArrayPuzzle.Program.cs
// Created on: 20200215
// -----------------------------------------------

using System;
using System.Collections.Generic;

namespace IntArrayPuzzle
{
    internal static class Program
    {
        private static readonly List<KeyValuePair<string, List<int>>> TestLists = new List<KeyValuePair<string, List<int>>>();

        private static void Main()
        {
            TestLists.Add(new KeyValuePair<string, List<int>>("example 1 test",            new List<int>() {0, 1, 2, 3, 4, 5}));
            TestLists.Add(new KeyValuePair<string, List<int>>("example 2 test",            new List<int>() {-1, 0, 1}));
            TestLists.Add(new KeyValuePair<string, List<int>>("example 3 test",            new List<int>() {1, 1}));
            TestLists.Add(new KeyValuePair<string, List<int>>("negative only test",        new List<int>() {-42, -1, -2}));
            TestLists.Add(new KeyValuePair<string, List<int>>("manual checked test",       new List<int>() {-8, -4, -4, -3, 8, 6, 7}));
            TestLists.Add(new KeyValuePair<string, List<int>>("Single value test",         new List<int>() {42}));
            TestLists.Add(new KeyValuePair<string, List<int>>("unsorted test",             new List<int>() {-100, 10, 1, -10, -1, 100}));
            TestLists.Add(new KeyValuePair<string, List<int>>("multiple 0 test",           new List<int>() {-42, -1, 0, 0, 0, 42}));
            TestLists.Add(new KeyValuePair<string, List<int>>("null exception test",       null));
            TestLists.Add(new KeyValuePair<string, List<int>>("empty list exception test", new List<int>()));

            var calculator = new HighestNumberCalculator();

            foreach (var kvp in TestLists)
            {
                try
                {
                    Console.WriteLine($"Result of test: {kvp.Key}");
                    Console.WriteLine($"{calculator.Calculate(kvp.Value)} from {string.Join(",", kvp.Value.ToArray())}");
                    Console.WriteLine("");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e}");
                    Console.WriteLine("");
                }
            }

            Console.ReadLine();
        }
    }
}