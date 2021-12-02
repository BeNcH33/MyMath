using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
	class Test
	{
		MyMaths myMath;
		[SetUp]
		public void TestProgram()
		{
			 myMath = new MyMaths();
		}
		[Test]
		public void TestSin()
		{
			var x = 5;
			var actual = myMath.Sin(x);
			var expected = Math.Sin(x);

			Assert.AreEqual(expected, actual, 0.01);
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
			var x = 5;
			var actual = myMath.Cos(x);
			var exp = Math.Cos(x);

			Assert.AreEqual(actual, exp, 0.01);
		}

		[Test]
		public void testAbs()
        {
			var x = 10;
			var aactual = myMath.Abs(x);
			var exp = Math.Abs(x);
			Assert.AreEqual(aactual, exp, 0.01);
			var x2 = -10;
			var aactual2 = myMath.Abs(x);
			var exp2 = Math.Abs(x);
			Assert.AreEqual(aactual2, exp2, 0.01);
		}
	}
}
