using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Calculator
{
    class CalcSum : ICalculater
    {
        public static string nText;

        public static void WriteMessage(int tMessage, string message)
        {
            ILogger logger;
            logger = new Logger();
            switch (tMessage)
            {
                case 1:
                    logger.Event(message);
                    break;
                case -1:
                    logger.Error(message);
                    break;
            }



        }

        public void getnText(int num)
        {
            switch (num)
            {
                case 1:
                    nText = "Введите первое число";
                    break;
                case 2:
                    nText = "Введите второе число";
                    break;
            }
        }

        public static decimal GetNumber()
        {
            decimal Number = 0;
            bool res = false;
            
            Console.WriteLine(nText);

            while (!res)
            {
                try
                {
                    res = decimal.TryParse(Console.ReadLine(), out Number);
                                       
                    if (!res)
                    {
                        WriteMessage(-1, "Введено не число");
                       
                    }

                }

                catch (Exception ex)
                {
                    string mess = "Призошла ошибка обработки : " + ex.Message;
                    WriteMessage(-1, mess);
                }
            }
            return Number;
        }

        decimal ICalculater.CalcSum(decimal a, decimal b)
        {
            return a + b;
        }

        public void WriteSum(decimal sum)
        {
            string str = "Полученная суммв : " + sum.ToString();

            WriteMessage(1, str);
            
        }
    }
}
