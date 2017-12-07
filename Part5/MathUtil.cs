using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5
{
    class MathUtil
    {
        private MathUtil() { }

        public static double calculate(string oper, double arg1, double arg2)
        {
            switch (oper)
            {
                case "^": { return Math.Pow(arg1, arg2); }
                case "+": { return arg1 + arg2; }
                case "-": { return arg1 - arg2; }
                case "*": { return arg1 * arg2; }
                case "/": { return arg1 / arg2; }
                default: { throw new ArgumentException("Not existing operator!" + oper); }
            }
        }

        public static byte priority(string oper)
        {
                switch (oper)
            {
                case "^": { return 9; }
                case "+": { return 3; }
                case "-": { return 3; }
                case "*": { return 7; }
                case "/": { return 7; }
                case "(": { return 0; }
                case ")": { return 0; }
                default: { throw new ArgumentException("Not existing operator!" + oper); }
            }
        }


        public static double calculate(string oper, double arg)
        {
            switch (oper)
            {
                case "sin": { return Math.Sin(arg); }
                case "cos": { return Math.Cos(arg); }
                case "tg": { return Math.Tan(arg); }
                case "ln": { return Math.Log(arg); }
                default: { throw new ArgumentException("Not existing unary function!"); }
            }
        }
    }
}
