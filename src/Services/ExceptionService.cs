using System;
using System.Collections.Generic;

namespace src.Services
{
    public class ExceptionService
    {
        private Stack<RandomException> _exceptions = new Stack<RandomException>();

        public void ThrowException()
        {
            int randomCode = new Random().Next();
            RandomException randomException = new RandomException(new RandomError(randomCode));
            _exceptions.Push(randomException);
            throw randomException;
        }

        public RandomException GetLastExceptionThrown()
        {
            return _exceptions.Pop();
        }
    }
}
