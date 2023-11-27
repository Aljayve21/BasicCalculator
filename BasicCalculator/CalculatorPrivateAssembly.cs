using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    internal class CalculatorPrivateAssembly
    {
        public float Addition(float number1, float number2)
        {
            float result = number1 + number2;
            return result;
        }
        public float Subtraction(float number1, float number2)
        {
            float result = number1 - number2;
            return result;
        }

        public float Multiplication(float number1, float number2)
        {
            float result = number1 * number2;
            return result;
        }

        public float Division(float number1, float number2)
        {
            float result = number1 / number2;
            return result;
        }
    }
}
