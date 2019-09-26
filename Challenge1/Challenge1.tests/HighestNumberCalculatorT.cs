///-------------------------------------------------------------------------------------
///   Namespace:    Challenge1.tests
///   Class:        HighestNumberCalculatorT
///   Description:  Test class for highestNumberCalculator
///   Author:       Ramon Bollen                    
///   Date:         20190714
///-------------------------------------------------------------------------------------

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenge1;
using System.Collections.Generic;
using System;

namespace Challenge1.tests
{
    /// <summary>
    /// Test class for the HighestNumberCalculator
    /// </summary>
    [TestClass]
    public class HighestNumberCalculatorT
    {
        HighestNumberCalculator m_calculator = new HighestNumberCalculator();

        [TestMethod]
        public void Example_1_test()
        {
            Assert.AreEqual(27, m_calculator.Calculate(new List<int>() { 0, 1, 2, 3, 4, 5 }));
        }

        [TestMethod]
        public void Example_2_test()
        {
            Assert.AreEqual(1, m_calculator.Calculate(new List<int>() { -1, 0, 1 }));
        }

        [TestMethod]
        public void Example_3_test()
        {
            Assert.AreEqual(2, m_calculator.Calculate(new List<int>() { 1, 1 }));
        }

        [TestMethod]
        public void SingleValue_test()
        {
            Assert.AreEqual(42, m_calculator.Calculate(new List<int>() { 42 }));
        }
        
        [TestMethod]
        public void Unsorted_test()
        {
            Assert.AreEqual(2000, m_calculator.Calculate(new List<int>() { -100, 10, 1, -10, -1, 100 }));
        }

        [TestMethod]
        public void Multiple_zeros_test()
        {
            Assert.AreEqual(84, m_calculator.Calculate(new List<int>() { -42, -1, 0, 0, 0, 42 }));
        }

        [TestMethod]
        public void Only_negative_numbers_test()
        {
            Assert.AreEqual(83, m_calculator.Calculate(new List<int>() { -42, -1, -2 }));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Parameter cannot be null")]
        public void Null_input_test()
        {
            m_calculator.Calculate(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Parameter contains no elements")]
        public void Empty_list_test()
        {
            Assert.AreEqual(83, m_calculator.Calculate(new List<int>()));
        }
    }
}
