// -----------------------------------------------
//     Author: Ramon Bollen
//      File: IntArrayPuzzle.HighestNumberCalculator.cs
// Created on: 20201211
// -----------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace IntArrayPuzzle
{
    /// <summary>
    ///     Output the highest possible number based on pairing and multiplying pairs
    /// </summary>
    public class HighestNumberCalculator
    {
        /// <summary>
        ///     Handles a calculate call
        /// </summary>
        /// <param name="numberArray"></param>
        /// <returns>return calculation result or exception</returns>
        public int Calculate(List<int> numberArray)
        {
            // Cannot use empty list
            if (numberArray == null)
            {
                throw new ArgumentException("Parameter cannot be null");
            }

            return numberArray.Count switch
            {
                // Cannot use empty list
                0 => throw new ArgumentException("Parameter contains no elements"),
                // Directly return value of single element
                1 => numberArray[0],
                _ => CalculateImpl(numberArray)
            };
        }

        /// <summary>
        ///     Split the list
        /// </summary>
        /// <param name="numberArray"></param>
        /// <returns>Total result of calculation</returns>
        private int CalculateImpl(List<int> numberArray)
        {
            int returnValue = 0;

            // Assumption: List is allowed to be ordered
            numberArray.Sort();

            // The number 1 should never be multiplied under these conditions
            returnValue += numberArray.Count(i => i == 1);

            List<int> higherThanOneList = numberArray.Where(i => i > 1).ToList();
            higherThanOneList.Reverse(); // Start with the highest numbers

            List<int> smallerThanOneList = numberArray.Where(i => i < 1).ToList();

            returnValue += ListResult(higherThanOneList);
            returnValue += ListResult(smallerThanOneList);

            return returnValue;
        }

        /// <summary>
        ///     Makes pairs for multiplication and add left over number if list is odd
        /// </summary>
        /// <param name="partialArray"></param>
        /// <returns>Result of partial array</returns>
        private int ListResult(List<int> partialArray)
        {
            switch (partialArray.Count)
            {
                case 0:
                    return 0;
                case 1:
                    return partialArray[0];
            }

            int totalResult = 0;

            // Amount of values is odd, last value will be added and not multiplied
            if (partialArray.Count % 2 != 0)
            {
                totalResult += partialArray.Last();
                partialArray.RemoveAt(partialArray.Count - 1);
            }

            for (int i = 0; i < partialArray.Count; i += 2)
            {
                totalResult += partialArray[i] * partialArray[i + 1];
            }

            return totalResult;
        }
    }
}