using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Utils
{
    class Operator
    {
        private static Operator instance;

        private Operator()
        {

        }

        public static Operator GetInstance()
        {
            if(instance == null)
            {
                instance = new Operator();
            }
            return instance;
        }

        public double Add(double num1, double num2)
        {
            double sum = num1 + num2;
            return sum;
        }

        public double Subtract(double num1, double num2)
        {
            double ans = num1 - num2;
            return ans;
        }

        public double Multiply(double num1, double num2)
        {
            double ans = num1 * num2;
            return ans;

        }

        public double Divide(double num1, double num2)
        {
            double ans = num1 / num2;
            return ans;
        }
    }
}
