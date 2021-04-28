using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public interface ICalculater
    {
        public void getnText(int num);
        public decimal CalcSum(decimal a, decimal b);
        public void WriteSum(decimal sum);
    }
 }