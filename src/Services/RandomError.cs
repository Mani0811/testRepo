namespace src.Services
{
    public class RandomError
    {
        private int _code;

        public RandomError(int code)
        {
            _code = code;
        }

        public int GetCode()
        {
            return _code;
        }
    }
}
