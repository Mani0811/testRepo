using System;

namespace src.ExpressionEvaluator
{
    public class PostfixCalculator: NumberCalculator
    {
        public override double Evaluate(string expr)
        {
            try
            {
                return 0;
            }
            catch (Exception)
            {
                
                throw new InvalidExpressionException();
            }
        }
    }
}
