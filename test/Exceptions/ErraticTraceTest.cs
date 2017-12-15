using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using src.Exceptions;
using src.Services;

namespace test.ExceptionsTest
{
    [TestClass]
    public class StackTraceTest
    {
        [TestMethod]
    public void shouldClearInheritedStackTrace()
        {
            IStackTrace stacktrace = new StackTraceImpl();
            try
            {
                stacktrace.ClearStackTrace();
            }
            catch (Exception e)
            {
                Assert.Equals("clearStackTrace", e.StackTrace);
            }
        }
    }
}
