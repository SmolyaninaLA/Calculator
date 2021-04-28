using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    interface ILogger
    {
        void Event(string message);
        void Error(string message);
    }
}
