using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using src.ExpressionEvaluator;

namespace test.ExpressionEvaluator
{
    [TestClass]
    public class PostfixCalculatorTest
    {
        private PostfixCalculator _calculator;

        [TestInitialize]
        public void SetUp()
        {
            _calculator = new PostfixCalculator();
        }

        [TestMethod]

        [ExpectedException(typeof(src.ExpressionEvaluator.InvalidExpressionException))]
        public void ShouldThrowErrorOnInvalidExpression()
        {
            _calculator.Evaluate("xyz dfa fad");
        }

        [TestMethod]
        public void ShouldAdd()
        {
            Assert.IsTrue(Math.Abs(6.0 - _calculator.Evaluate("4.0 2.0 +")) <= 0.05);
            Assert.IsTrue(Math.Abs(5.5 - _calculator.Evaluate("2.2 3.3 +")) <= 0.05);
            Assert.IsTrue(Math.Abs(100.05 - _calculator.Evaluate("99.0 1.05 +")) <= 0.05);
        }

        [TestMethod]
        public void ShouldMultiply()
        {
            Assert.IsTrue(Math.Abs(8.0 - _calculator.Evaluate("4.0 2.0 *")) <= 0.05);
            Assert.IsTrue(Math.Abs(6.0 - _calculator.Evaluate("2.0 3.0 *")) <= 0.05);
            Assert.IsTrue(Math.Abs(99.0 - _calculator.Evaluate("99.0 1.0 *")) <= 0.05);
        }

        [TestMethod]
        public void ShouldSubtract()
        {
            Assert.IsTrue(Math.Abs(2.0 - _calculator.Evaluate("4.0 2.0 -")) <= 0.05);
            Assert.IsTrue(Math.Abs(2.2 - _calculator.Evaluate("5.5 3.3 -")) <= 0.05);
            Assert.IsTrue(Math.Abs(99.0 - _calculator.Evaluate("100.05 1.05 -")) <= 0.05);
        }

        [TestMethod]
        public void ShouldDivide()
        {
            Assert.IsTrue(Math.Abs(2.0 - _calculator.Evaluate("4.0 2.0 /")) <= 0.05);
            Assert.IsTrue(Math.Abs(20.0 - _calculator.Evaluate("60.0 3.0 /")) <= 0.05);
            Assert.IsTrue(Math.Abs(15.0 - _calculator.Evaluate("60.0 4.0 /")) <= 0.05);
        }

    }
}
