using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Testin1
{
    public class Solver : ISolve
    {
        private string expression;

        public Solver()
        {
            expression = "";
        }

        public void Accumulate(string s)
        {
            expression += s;
        }

        public void Clear()
        {
            expression = "";
        }

        public double solve()
        {
            try
            {
                return Evaluate(expression);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid expression");
                return double.NaN;
            }
        }

        private double Evaluate(string exp)
        {
            var numbers = new List<double>();
            var operators = new List<char>();

            string currentNumber = "";

            foreach (char c in exp)
            {
                if (char.IsDigit(c) || c == '.')
                {
                    currentNumber += c;
                }
                else
                {
                    if (!string.IsNullOrEmpty(currentNumber))
                    {
                        numbers.Add(double.Parse(currentNumber));
                        currentNumber = "";
                    }

                    operators.Add(c);
                }
            }

            if (!string.IsNullOrEmpty(currentNumber))
            {
                numbers.Add(double.Parse(currentNumber));
            }

            while (operators.Count > 0)
            {
                char op = operators[0];
                operators.RemoveAt(0);

                double operand1 = numbers[0];
                numbers.RemoveAt(0);

                double operand2 = numbers[0];
                numbers.RemoveAt(0);

                switch (op)
                {
                    case '+':
                        numbers.Insert(0, operand1 + operand2);
                        break;
                    case '-':
                        numbers.Insert(0, operand1 - operand2);
                        break;
                    case '*':
                        numbers.Insert(0, operand1 * operand2);
                        break;
                    case '/':
                        numbers.Insert(0, operand1 / operand2);
                        break;
                    case '%':
                        numbers.Insert(0, operand1 % operand2);
                        break;
                    default:
                        throw new InvalidOperationException("Invalid operator");
                }
            }

            return numbers[0];
        }
    }

}

