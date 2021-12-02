using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    class MyFunction
    {
        MyMaths MyMaths = new MyMaths();
        public double InfCalc(double x)
        {
            if (x <= 0)
            {
                return MyMaths.Pow(MyMaths.Pow(MyMaths.Sin(x) - MyMaths.Ctn(x) + MyMaths.Ctn(x), 3), 2) + MyMaths.Pow(MyMaths.Sec(x) + MyMaths.Cos(x), 2);
            }
            else
            {
                return (((MyMaths.Pow(MyMaths.Ln(x), 2) - MyMaths.Log(2, x)) / (MyMaths.Log(3, x) * MyMaths.Log(2, x)))*MyMaths.Ln(x))*MyMaths.Log(10, MyMaths.Pow(x,2));
            }
        }
        public double StandartMath(double x)
        {
            if (x <= 0)
            {
                return Math.Pow(Math.Pow(Math.Sin(x) - MyMaths.Ctn(x) + MyMaths.Ctn(x), 3), 2) + Math.Pow(MyMaths.Sec(x) + Math.Cos(x), 2);
            }
            else 
            {
                return (((Math.Pow(Math.Log(x), 2) - Math.Log(2, x)) / (Math.Log(3, x) * Math.Log(2, x))) * Math.Log(x)) * Math.Log(10, Math.Pow(x, 2));
            }
        }
    }
}
