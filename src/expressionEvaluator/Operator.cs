using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace src.ExpressionEvaluator
{
    public class Operator
    {
        private static readonly Dictionary<string, string> _operators=new Dictionary<string, string>();

        static Operator()
        {
            Intilaize();
        }

        private static void Intilaize()
        {
            _operators.Add("+", "ADD");
            _operators.Add("-", "SUB");
            _operators.Add("*", "MUL");
            _operators.Add("/", "DIV");
        }

        public static Boolean IsOperator(String term)
        {
            Regex r = new Regex("[+\\-*/]{1}");
            return r.Match(term).Success;
        }

        public static String GetOperator(String symbol)
        {
            try
            {
                return _operators[symbol];
            }
            catch (KeyNotFoundException knfe)
            {

                throw new KeyNotFoundException("Invalid Operator Symbol: " + symbol);
            }
        }
    }
}
