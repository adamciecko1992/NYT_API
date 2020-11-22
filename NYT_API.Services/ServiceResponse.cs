using System;

namespace NYT_API.Services
{
    public class ServiceResponse<T>
    {
        public bool IsSuccess { get; set; }
        public bool HasErrors { get; set; }
        public T Data { get; set; }
        public string ErrorMessage { get; set; }
      
    }
}
