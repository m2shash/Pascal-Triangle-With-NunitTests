using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PascalTest
{
    [TestFixture]
    public class PascalUnitTests
    {
        [Test]
        public void PascalMethod_ValidRowCol_ReutrnsCorrectValue()
        {
            PascalAssignment obj = new PascalAssignment();
            var actualResult = PascalAssignment.pascal(1, 3);
            var expectedResult = 3;           
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void PascalMethod_InCorrectRowCol_ReutrnsInCorrectValue()
        {
            PascalAssignment obj = new PascalAssignment();
            var actualResult = PascalAssignment.pascal(3, 6);
            var expectedResult = 10;
            Assert.AreNotEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// validates pascal rule (n/k) = (n-1/k-1) + (n-1/k)
        /// </summary>
        [Test]
        public void ValidatePascalRule()
        {
            PascalAssignment obj = new PascalAssignment();
            var first = PascalAssignment.pascal(2, 5);
            var second = PascalAssignment.pascal(3, 5);
            var result = PascalAssignment.pascal(3, 6);
            Assert.AreEqual(result, (first + second));
        }

    }
}
