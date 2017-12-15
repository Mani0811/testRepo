using src.Services;

namespace src.Exceptions
{
    public class ErraticServiceImpl : IErraticService
    {
        public RandomError Execute(ExceptionService stubService)
        {
            stubService.ThrowException();
            return new RandomError(code: -1);
        }
    }
}
