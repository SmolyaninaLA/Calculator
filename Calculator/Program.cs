using System;

namespace Calculator
{
    class Program
    {
        delegate decimal GetNum();
        static void Main(string[] args)
        {

            GetNum getNum = CalcSum.GetNumber;
            ICalculater calculater = new CalcSum();
            
            calculater.getnText(1);
           
            decimal num1 = getNum.Invoke();

           
            calculater.getnText(2);
            decimal num2 = getNum.Invoke();
           
            decimal summ = calculater.CalcSum(num1, num2);

            calculater.WriteSum(summ);


        }
    }
}
