///-------------------------------------------------------------------------------------
///   Namespace:    Challenge1
///   Class:        Program
///   Description:  Main starting point
///   Author:       Ramon Bollen                    
///   Date:         20190714
///-------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Challenge1
{
    class Program
    {
        static List<KeyValuePair<string, List<int>>> m_testLists = new List<KeyValuePair<string, List<int>>>();

        static void Main(string[] args)
        {
            m_testLists.Add(new KeyValuePair<string, List<int>>("example 1 test", new List<int>() { 0, 1, 2, 3, 4, 5 }));
            m_testLists.Add(new KeyValuePair<string, List<int>>("example 2 test", new List<int>() { -1, 0, 1 }));
            m_testLists.Add(new KeyValuePair<string, List<int>>("example 3 test", new List<int>() { 1, 1 }));
            m_testLists.Add(new KeyValuePair<string, List<int>>("negative only test", new List<int>() { -42, -1, -2 }));
            m_testLists.Add(new KeyValuePair<string, List<int>>("manual checked test", new List<int>() { -8, -4, -4, -3, 8, 6, 7 }));
            m_testLists.Add(new KeyValuePair<string, List<int>>("Single value test", new List<int>() { 42 }));
            m_testLists.Add(new KeyValuePair<string, List<int>>("unsorted test", new List<int>() { -100, 10, 1, -10, -1, 100 }));
            m_testLists.Add(new KeyValuePair<string, List<int>>("multiple 0 test", new List<int>() { -42, -1, 0, 0, 0, 42 }));
            m_testLists.Add(new KeyValuePair<string, List<int>>("null exception test", null));
            m_testLists.Add(new KeyValuePair<string, List<int>>("empty list exception test", new List<int>()));

            HighestNumberCalculator m_calculator = new HighestNumberCalculator();

            foreach(var kvp in m_testLists)
            {
                try
                {
                    Console.WriteLine($"Result of test: {kvp.Key}");
                    Console.WriteLine($"{m_calculator.Calculate(kvp.Value)} from {string.Join(",", kvp.Value.ToArray())}");
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
