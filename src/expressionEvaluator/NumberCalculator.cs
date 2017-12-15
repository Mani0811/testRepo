using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace src.ExpressionEvaluator
{
    public abstract class NumberCalculator
    {
        protected Boolean IsNumeric(String term)
        {
            Regex r = new Regex("[+-]{0,1}\\d*\\.{0,1}\\d*[flb]{0,1}");
            return r.Match(term).Success;
        }

        protected Queue<String> GetTerms(String expr)
        {
            return new Queue<string>(expr.Split(' ').ToList());
        }

        public abstract double Evaluate(String expr);

    }
}
