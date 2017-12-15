using System;

namespace src.Services
{
    public class RandomException : SystemException
    {
        private RandomError _error;

        public RandomException(RandomError error)
        {
            _error = error;
        }

        public RandomError GetError()
        {
            return _error;
        }
    }
}
