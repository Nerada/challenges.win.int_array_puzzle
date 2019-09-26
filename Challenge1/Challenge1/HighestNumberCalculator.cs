///-------------------------------------------------------------------------------------
///   Namespace:    Challenge1
///   Class:        HighestNumberCalculator
///   Description:  Given a list of integers, which may be both positive and negative. 
///                 Each integer in the list must either be paired with another element in 
///                 the list or be a single element. Once the elements have been paired, 
///                 the integers in the pairs are multiplied and the results are summed up 
///                 - the sum will include the single elements.
///   Author:       Ramon Bollen                    
///   Date:         20190714
///-------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenge1
{
    /// <summary>
    /// Output the highest possible number based on pairing and multiplying pairs
    /// </summary>
    public class HighestNumberCalculator
    {
        /// <summary>
        /// Handles a calculate call
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

            // Cannot use empty list
            if (numberArray.Count == 0)
            {
                throw new ArgumentException("Parameter contains no elements");
            }

            // Directly return value of single element
            if (numberArray.Count == 1)
            {
                return numberArray.First();
            }

            return CalculateImpl(numberArray);
        }

        /// <summary>
        /// Split the list 
        /// </summary>
        /// <param name="numberArray"></param>
        /// <returns>Total result of calculation</returns>
        private int CalculateImpl(List<int> numberArray)
        {
            int returnValue = 0;

            // Assumption: List is allowed to be ordered
            numberArray.Sort();

            // The number 1 should never be multiplied under these conditions
            numberArray.Where(i => i == 1).ToList().ForEach(i => { returnValue++; });

            List<int> higherThanOneList = numberArray.Where(i => i > 1).ToList();
            higherThanOneList.Reverse(); // Start with the highest numbers

            List<int> smallerThanOneList = numberArray.Where(i => i < 1).ToList();

            returnValue += ListResult(higherThanOneList);
            returnValue += ListResult(smallerThanOneList);

            return returnValue;
        }

        /// <summary>
        /// Makes pairs for multiplication and add left over number if list is odd
        /// </summary>
        /// <param name="partailArray"></param>
        /// <returns>Result of partial array</returns>
        private int ListResult(List<int> partailArray)
        {
            if (partailArray.Count() == 0)
            {
                return 0;
            }

            if (partailArray.Count() == 1)
            {
                return partailArray.First();
            }

            int totalResult = 0;

            // Amount of values is odd, last value will be added and not multiplied
            if (partailArray.Count() % 2 != 0)
            {
                totalResult += partailArray.Last();
                partailArray.RemoveAt(partailArray.Count - 1);
            }

            for (int i = 0; i < partailArray.Count; i += 2)
            {
                totalResult += partailArray[i] * partailArray[i + 1];
            }

            return totalResult;
        }
    }
}
