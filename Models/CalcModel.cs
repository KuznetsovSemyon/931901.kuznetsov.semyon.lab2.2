using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_2._2.Models
{
    public class CalcModel
    {
        public double value1 { get; set; }
        public double value2 { get; set; }
        public string operation { get; set; }

        public CalcModel()
        {

        }

        public CalcModel(double Value1, double Value2, string Operation)
        {
            value1 = Value1;
            value2 = Value2;
            operation = Operation;
        }

        public double Calc()
        {
            double result;

            switch (operation)
            {
                case "+":
                    result = value1 + value2;
                    break;
                case "-":
                    result = value1 - value2;
                    break;
                case "*":
                    result = value1 * value2;
                    break;
                case "/":
                    result = value1 / value2;
                    break;
                default:
                    result = 0;
                    break;
            }

            return result;
        }
    }
}

