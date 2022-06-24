// -----------------------------------------------
//     Author: Ramon Bollen
//      File: IntArrayPuzzle.tests.HighestNumberCalculatorT.cs
// Created on: 20201211
// -----------------------------------------------

using System;
using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntArrayPuzzle.tests
{
    /// <summary>
    ///     Test class for the HighestNumberCalculator
    /// </summary>
    [TestClass]
    public class HighestNumberCalculatorT
    {
        private readonly HighestNumberCalculator _calculator = new();

        [TestMethod]
        public void Example_1_test() => _calculator.Calculate(new List<int> {0, 1, 2, 3, 4, 5}).Should().Be(27);

        [TestMethod]
        public void Example_2_test() => _calculator.Calculate(new List<int> {-1, 0, 1}).Should().Be(1);

        [TestMethod]
        public void Example_3_test() => _calculator.Calculate(new List<int> {1, 1}).Should().Be(2);

        [TestMethod]
        public void SingleValue_test() => _calculator.Calculate(new List<int> {42}).Should().Be(42);

        [TestMethod]
        public void Unsorted_test() =>
            Assert.AreEqual(2000, _calculator.Calculate(new List<int>
            {
                -100, 10, 1, -10, -1, 100
            }));

        [TestMethod]
        public void Multiple_zeros_test() => _calculator.Calculate(new List<int> {-42, -1, 0, 0, 0, 42}).Should().Be(84);

        [TestMethod]
        public void Only_negative_numbers_test() => _calculator.Calculate(new List<int> {-42, -1, -2}).Should().Be(83);

        [TestMethod]
        public void Null_input_test()
        {
            Action action = () => _calculator.Calculate(null);
            action.Should().Throw<ArgumentException>().WithMessage("Parameter cannot be null");
        }

        [TestMethod]
        public void Empty_list_test()
        {
            Action action = () => _calculator.Calculate(new List<int>());
            action.Should().Throw<ArgumentException>().WithMessage("Parameter contains no elements");
        }
    }
}