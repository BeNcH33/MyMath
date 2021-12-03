using NUnit.Framework;
using OfficeOpenXml;
using System;
using System.IO;

namespace MyMath
{
    class Test
    {
        MyMaths myMath;
        MyFunction MyFunction;
        [SetUp]
        public void TestProgram()
        {
            myMath = new MyMaths();
            MyFunction = new MyFunction();
        }
        [Test]
        public void TestSin()
        {
            //var x = 5;
            for (double x = -10; x <= 10; x += 0.01)
            {
                var actual = myMath.Sin(x);
                var expected = Math.Sin(x);
                Assert.AreEqual(expected, actual, 0.01);
            }
        }

        [Test]
        public void TestCsc()
        {
            var x = 1;
            var actual = myMath.Csc(x);
            var exp = 1 / Math.Sin(x);

            Assert.AreEqual(exp, actual, 0.01);
        }
        [Test]
        public void TestCos()
        {

            StreamWriter f = new StreamWriter("test.txt");
            
            for (double x = -10; x <= 10; x += 0.01)
            {
                var actual = myMath.Cos(x);
                var exp = Math.Cos(x);
                Assert.AreEqual(actual, exp, 0.01);
                f.WriteLine($"Значение x={Math.Round(x, 2)}, MyMath={actual}, ожидаемое={exp} ");
            }
            f.Close();
        }

        [Test]
        public void testAbs()
        {
            var x = 10;
            var aactual = myMath.Abs(x);
            var exp = Math.Abs(x);
            Assert.AreEqual(aactual, exp, 0.01);
            var x2 = -10;
            var aactual2 = myMath.Abs(x2);
            var exp2 = Math.Abs(x2);
            Assert.AreEqual(aactual2, exp2, 0.01);
        }

        [Test]
        public void TestNegativeAndNull()
        {
            for (double x = -10; x <= -0.01; x += 0.01)
            {
                Assert.AreEqual(MyFunction.MyMath(x), MyFunction.StandartMath(x), 0.1);
            }

        }
        [Test]
        public void TestPositive()
        {            
            for (double x = -10; x <= -0.01; x += 0.01)
            {
                Assert.AreEqual(MyFunction.MyMath(x), MyFunction.StandartMath(x), 0.1);
            }

        }
    }
}
