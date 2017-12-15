using System;
using src.Services;

namespace src.Exceptions
{
    public class StackTraceImpl : IStackTrace
    {
        public void ClearStackTrace()
        {
            try
            {
                method1();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void method1()
        {
            try
            {
                method2();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void method2()
        {
            try
            {
                method3();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void method3()
        {
            throw new Exception("Exception from method3");
        }
    }
}
