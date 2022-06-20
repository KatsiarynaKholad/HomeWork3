using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Money
{
    interface IOperationable
    {
        public void DoSum(double x, double y);
        public void DoSubstraction(double x, double y);
        public void DoDivision(double x, double y);
        public void DoDivisionOnFractionNumber(double x, double y, double z);
        public void DoMyltiplicationOnFractionNumber(double x, double z);
        public double ConvertToDouble(long firstPart, byte secondPart);

    }
}