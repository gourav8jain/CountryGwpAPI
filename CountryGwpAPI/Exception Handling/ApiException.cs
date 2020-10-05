using System;
using System.Net;

namespace CountryGwpAPI.Exception_Handling
{
    public class ApiException : Exception
    {
        public readonly HttpStatusCode StatusCode;

        public ApiException(HttpStatusCode statusCode, string message, Exception ex)
            : base(message, ex)
        {
            this.StatusCode = statusCode;
        }

        public ApiException(HttpStatusCode statusCode, string message)
            : base(message)
        {
            this.StatusCode = statusCode;
        }

        public ApiException(HttpStatusCode statusCode)
        {
            this.StatusCode = statusCode;
        }
    }
}
