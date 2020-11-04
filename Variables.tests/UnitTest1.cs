using NUnit.Framework;
using System.Linq.Expressions;
using Variables_Math;
namespace Variables.tests
{

    public class VariablesTests
    {
        public class SolveEquation
        {
            [Test]
            public void SimpleFraction()
            {
                double expected = 9;
                double acctual = Variables_Math.VariablesMath.SimpleFraction(1, 2);
                Assert.AreEqual(expected, acctual);
            }
            [TestCase(1, 2, 9)]
            [TestCase(2, 3, 19)]
            [TestCase(2, 6, 11.5)]
            public void SimpleFraction(double a, double b, double expected)
            {
                double acctual = Variables_Math.VariablesMath.SimpleFraction(a, b);
                Assert.AreEqual(expected, acctual);
            }
            [TestCase(2, 2)]
            [TestCase(3, 3)]
            [TestCase(4, 4)]
            [TestCase(20, 20)]

            public void SimpleFractionNegative(double a, double b)
            {
                try
                {
                    Variables_Math.VariablesMath.SimpleFraction(a, b);
                }
                catch
                {
                    Assert.Pass();
                }
                Assert.Fail();
            }
        }
        public class Division
        {
            
            [TestCase(4, 2, 2)]
            [TestCase(8, 2, 4)]
            [TestCase(6, 3, 2)]
            [TestCase(50, 2, 25)]
            [TestCase(60, 2, 30)]
            [TestCase(-4, 2, -2)]
            public void SimpleDivision(double a, double b, double expected)
            {
                double actual = VariablesMath.SimpleDivision(a, b);
                Assert.AreEqual(expected, actual);
            }
            [TestCase(2, 0)]
            public void SimpleDivisionNegative(double a, double b)
            {
                try
                {
                    VariablesMath.SimpleDivision(a, b);
                }
                catch
                {
                    Assert.Pass();
                }
                Assert.Fail();
            }
            [TestCase(4, 2, 0)]
            [TestCase(6, 2, 0)]
            [TestCase(6, 3, 0)]
            [TestCase(35, 10, 5)]
            [TestCase(-4, 2, 0)]
            public void RemainderOfTheDivision(double a, double b, double expected)
            {
                double actual = VariablesMath.FindRemainder(a, b);
                Assert.AreEqual(expected, actual);
            }
        }
        [TestCase(2, 5, 6, 0.5)]
        [TestCase(4, 5, 6, 0.25)]
        [TestCase(25, 8, 5, -0.12)]
        [TestCase(8, 4, 2, -0.25)]
        public void FindX(double a, double b, double c, double expected)
        {
            double actual = VariablesMath.FindX(a, b, c);
        }
        [TestCase(0, 2, 3)]
        public void FindXNegative(double a, double b, double c)
        {
            try
            {
                VariablesMath.FindX(a, b, c);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
        [TestCase(1, 3, 5, 6, 0.75, 2.25)]
        [TestCase(3, 5, 7, 12, 1.75, -0.25)]
        [TestCase(7, 5, 10, 2, -1, 12)]
        public void FindKAndB(double x1, double y1, double x2, double y2, double expectedK, double expectedB)
        {
            double actualK = VariablesMath.SolveIndexK(x1, y1, x2, y2);
            double actualB = VariablesMath.SolveIndexB(x1, y1, x2, y2);
            Assert.AreEqual(expectedK, actualK);
            Assert.AreEqual(expectedB, actualB);
        }
        [TestCase(7, 5, 7, 5)]
        public void FindKAndBNegative(double x1, double y1, double x2, double y2)
        {
            try
            {
                VariablesMath.SolveIndexK(x1, y1, x2, y2);
                VariablesMath.SolveIndexB(x1, y1, x2, y2);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
    }

}


