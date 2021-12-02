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
            var Numerator = x * x * x; //Числитель

            var factorialStart = 5;

            double factorialResult = 6;

            var result = x - Numerator / factorialResult;

            var X = 1;

            for (int i = 1; i <= nTerms; i++)

            {

                Numerator *= x * x;

                factorialResult *= factorialStart * (factorialStart - 1);

                factorialStart += 2;

                result += X * (Numerator / factorialResult);

                X *= -1;

            }

            return result;

        }

        public double Cos(double x, int nTerms = 15)

        {
            var Numerator = x * x;

            var factorialStart = 4;

            double factorialResult = 2;

            var result = 1 - Numerator / factorialResult;

            var X = 1;

            for (int i = 3; i <= nTerms; i++)

            {

                Numerator *= x * x;

                factorialResult *= factorialStart * (factorialStart - 1);

                factorialStart += 2;

                result += X * (Numerator / factorialResult);

                X *= -1;

            }

            return result;

        }

        public double tan(double x)
        {
            return Math.Round(Sin(x) / Cos(x), 2);
        }

        public double Ctn(double x)
        {
            return Math.Round(Cos(x) / Sin(x), 2);
        }
        public double Csc(double x)

        {
            return 1 / Sin(x);
        }
        public double Abs(double x)

        {
            return x >= 0 ? x : -x;
        }
    }
}

