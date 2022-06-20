using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Money
{
    public class Money : IOperationable, IComparable<Money>
    {
        public double A { get; set; }

        public int CompareTo(Money? other)
        {
            return A.CompareTo(other.A);
        }

        public void DoDivision(double x, double y)
        {
            Console.WriteLine($"first money {x} / second money {y} = {x / y}");
        }

        public void DoDivisionOnFractionNumber(double x, double y, double z)
        {
            Console.WriteLine($"(first money {x} + second money {y}) / fractional number {z} = {(x + y) / z}");
        }

        public void DoMyltiplicationOnFractionNumber(double x, double z)
        {
            Console.WriteLine($"first money {x} * fractional number {z} = {x * z}");
        }

        public void DoSubstraction(double x, double y)
        {
            Console.WriteLine($"first money {x} - second money {y} = {x - y}");
        }

        public void DoSum(double x, double y)
        {
            Console.WriteLine($"first money {x} + second money {y} = {x + y}");
        }
        public double ConvertToDouble(long firstPart, byte secondPart)
        {
            var result = firstPart + "," + secondPart;
            return Convert.ToDouble(result);
        }
    }
}
