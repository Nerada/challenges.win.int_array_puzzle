﻿// -----------------------------------------------
//     Author: Ramon Bollen
//       File: Challenge1.HighestNumberCalculator.cs
// Created on: 20190927
// -----------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenge1
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
            if (numberArray == null) { throw new ArgumentException("Parameter cannot be null"); }

            // Cannot use empty list
            if (numberArray.Count == 0) { throw new ArgumentException("Parameter contains no elements"); }

            // Directly return value of single element
            if (numberArray.Count == 1) { return numberArray[0]; }

            return CalculateImpl(numberArray);
        }

        /// <summary>
        ///     Split the list
        /// </summary>
        /// <param name="numberArray"></param>
        /// <returns>Total result of calculation</returns>
        private int CalculateImpl(List<int> numberArray)
        {
            var returnValue = 0;

            // Assumption: List is allowed to be ordered
            numberArray.Sort();

            // The number 1 should never be multiplied under these conditions
            returnValue += numberArray.Count(i => i == 1);

            var higherThanOneList = numberArray.Where(i => i > 1).ToList();
            higherThanOneList.Reverse(); // Start with the highest numbers

            var smallerThanOneList = numberArray.Where(i => i < 1).ToList();

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
            if (partialArray.Count == 0) { return 0; }

            if (partialArray.Count == 1) { return partialArray[0]; }

            var totalResult = 0;

            // Amount of values is odd, last value will be added and not multiplied
            if (partialArray.Count % 2 != 0)
            {
                totalResult += partialArray.Last();
                partialArray.RemoveAt(partialArray.Count - 1);
            }

            for (var i = 0; i < partialArray.Count; i += 2) { totalResult += partialArray[i] * partialArray[i + 1]; }

            return totalResult;
        }
    }
}