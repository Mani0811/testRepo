using System;
using System.Collections.Generic;
using System.Linq;

namespace src.ExpressionEvaluator
{
    public class InfixCalculator : NumberCalculator
    {
        public override double Evaluate(string expr)
        {
            Queue<String> terms = GetTerms(expr);
            while (terms.Count() > 2)
            {
                String token1 = terms.Dequeue();
                String token2 = terms.Dequeue();
                String token3 = terms.Dequeue();
                if (IsNumeric(token1) && Operator.IsOperator(token2) && IsNumeric(token3))
                {
                    return Apply(terms, token1, token2, token3);
                }
            }
            throw new InvalidExpressionException();
        }

        private double Apply(Queue<string> terms, string token1, string token2, string token3)
        {
            switch (Operator.GetOperator(token2))
            {
                case "DIV":
                    if (Double.Parse(token3) != 0)
                    {
                        return (Double.Parse(token1) / Double.Parse(token3));
                    }
                    else
                    {
                        return double.MaxValue;
                    }
                case "MUL":
                    return (Double.Parse(token1) * Double.Parse(token3));
                case "SUB":
                    return (Double.Parse(token1) - Double.Parse(token3));
                case "ADD":
                    return (Double.Parse(token1) + Double.Parse(token3));
                default:
                    throw new ExpressionEvaluator.InvalidExpressionException();
            }
        }
    }
}
