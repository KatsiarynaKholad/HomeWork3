using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.Fractions
{
    public class Fraction : ICanDoMathOperations, IComparable<Fraction>
    {
        public double A { get; set; }
        public int CompareTo(Fraction? other)
        {
            return A.CompareTo(other.A);
        }

        public double ConvertToDouble(int firstPart, uint secondPart)
        {
            var result = firstPart + "," + secondPart;
            return Convert.ToDouble(result);
        }

        public double DoMyltiplication(double x, double y)
        {
            return (x * y);
        }

        public double DoSubtraction(double x, double y)
        {
            return (x - y);
        }

        public double DoSum(double x, double y)
        {
            return (x + y);
        }
    }
}
