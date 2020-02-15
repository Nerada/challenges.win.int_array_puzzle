// -----------------------------------------------
//     Author: Ramon Bollen
//       File: Challenge1.tests.HighestNumberCalculatorT.cs
// Created on: 20200215
// -----------------------------------------------

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge1.tests
{
    /// <summary>
    ///     Test class for the HighestNumberCalculator
    /// </summary>
    [TestClass]
    public class HighestNumberCalculatorT
    {
        private readonly HighestNumberCalculator _calculator = new HighestNumberCalculator();

        [TestMethod]
        public void Example_1_test()
        {
            Assert.AreEqual(27, _calculator.Calculate(new List<int> { 0, 1, 2, 3, 4, 5 }));
        }

        [TestMethod]
        public void Example_2_test() { Assert.AreEqual(1, _calculator.Calculate(new List<int> {-1, 0, 1})); }

        [TestMethod]
        public void Example_3_test() { Assert.AreEqual(2, _calculator.Calculate(new List<int> {1, 1})); }

        [TestMethod]
        public void SingleValue_test() { Assert.AreEqual(42, _calculator.Calculate(new List<int> {42})); }

        [TestMethod]
        public void Unsorted_test()
        {
            Assert.AreEqual(2000, _calculator.Calculate(new List<int>() { -100, 10, 1, -10, -1, 100 }));
        }

        [TestMethod]
        public void Multiple_zeros_test()
        {
            Assert.AreEqual(84, _calculator.Calculate(new List<int>() { -42, -1, 0, 0, 0, 42 }));
        }

        [TestMethod]
        public void Only_negative_numbers_test()
        {
            Assert.AreEqual(83, _calculator.Calculate(new List<int>() { -42, -1, -2 }));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Parameter cannot be null")]
        public void Null_input_test() { _calculator.Calculate(null); }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Parameter contains no elements")]
        public void Empty_list_test() { Assert.AreEqual(83, _calculator.Calculate(new List<int>())); }
    }
}