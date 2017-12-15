namespace src.Services
{
    public interface IErraticService
    {
        RandomError Execute(ExceptionService stubService);
    }
}
