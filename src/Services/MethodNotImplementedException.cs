using System;

namespace src.Services
{
    public class MethodNotImplementedException: SystemException
    {
        public MethodNotImplementedException(string methodName): base("Method: "+methodName+" is not implemented")
        {
            
        }
    }
}
