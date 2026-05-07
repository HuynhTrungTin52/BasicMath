using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicMath;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BasicMathTests
{
    [TestClass]
    public class BasicMathsTests
    {
        [TestMethod]
        [DataRow(1, 1, 2)] // EP: Positive numbers
        [DataRow(-1, -1, -2)] // EP: Negative numbers
        [DataRow(0, 0, 0)] // EP: Zero
        [DataRow(int.MaxValue, 1, (double)int.MaxValue + 1)] // BVA: Upper boundary
        [DataRow(int.MinValue, -1, (double)int.MinValue - 1)] // BVA: Lower boundary
        public void Test_AddMV(int a, int b, double expected)
        {
            BasicMaths bm = new BasicMaths();
            double actual = bm.Add(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(5, 3, 2)] // EP: Positive numbers
        [DataRow(-5, -3, -2)] // EP: Negative numbers
        [DataRow(0, 0, 0)] // EP: Zero
        [DataRow(int.MaxValue, 1, (double)int.MaxValue - 1)] // BVA: Upper boundary
        [DataRow(int.MinValue, -1, (double)int.MinValue + 1)] // BVA: Lower boundary
        public void Test_SubtractMV(int a, int b, double expected)
        {
            BasicMaths bm = new BasicMaths();
            double actual = bm.Subtract(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(6, 3, 2)] // EP: Positive numbers
        [DataRow(-6, -3, 2)] // EP: Negative numbers
        [DataRow(0, 5, 0)] // EP: Zero numerator
        [DataRow(int.MaxValue, 1, (double)int.MaxValue)] // BVA: Upper boundary
        [DataRow(int.MinValue, -1, (double)int.MaxValue + 1)] // BVA: Lower boundary
        public void Test_DivideMV(int a, int b, double expected)
        {
            BasicMaths bm = new BasicMaths();
            double actual = bm.Divide(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(2, 3, 6)] // EP: Positive numbers
        [DataRow(-2, -3, 6)] // EP: Negative numbers
        [DataRow(0, 5, 0)] // EP: Zero
        [DataRow(int.MaxValue, 1, (double)int.MaxValue)] // BVA: Upper boundary
        [DataRow(int.MinValue, 1, (double)int.MinValue)] // BVA: Lower boundary
        public void Test_MultiplyMV(int a, int b, double expected)
        {
            BasicMaths bm = new BasicMaths();
            double actual = bm.Multiply(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
