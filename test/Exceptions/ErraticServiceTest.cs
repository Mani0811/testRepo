using Microsoft.VisualStudio.TestTools.UnitTesting;
using src.Exceptions;
using src.Services;

namespace test.Exceptions
{
    /**
  * Test for @{@link ErraticServiceImpl}
  * Can you play around with fiery exceptions ?
  */
    [TestClass]
    public class ErraticServiceTest
    {
        [TestMethod]
        public void ShouldReturnErrorCodeInCaseOfException()
        {
            IErraticService erraticServiceTest = new ErraticServiceImpl();
            ExceptionService stubService = new ExceptionService();
            RandomError randomError = erraticServiceTest.Execute(stubService);
            RandomException lastExceptionThrown = stubService.GetLastExceptionThrown();

            Assert.Equals(lastExceptionThrown.GetError().GetCode(), randomError.GetCode());
    }
}
}
