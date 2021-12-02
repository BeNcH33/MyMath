using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    class MyMaths
    {
        public double Sin(double x, int nTerms = 15)

        {

            var Numerator = x * x * x;//Числитель

            var factorialStart = 3;

            double factorialResult = 6;

            var result = x + Numerator / factorialStart;

            var X = 1;

            for (int i = 3; i <= nTerms; i++)

            {

                Numerator *= x * x;

                factorialResult *= factorialStart * factorialStart - 1;

                factorialStart += 2;

                result += Numerator / factorialResult;

                //X *= -1;

            }

            return result;

        }
    }
}

