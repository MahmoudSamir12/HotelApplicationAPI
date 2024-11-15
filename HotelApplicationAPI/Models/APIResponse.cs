using System.Net;

namespace HotelApplicationAPI.Models
{
    public class APIResponse<T>
    {
        public bool Success { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
        public object Error { get; set; }

        public APIResponse(T data, HttpStatusCode statusCode = HttpStatusCode.OK, string message = "")
        {
            Success = true;
            StatusCode = statusCode;
            Message = message;
            Data = data;
            Error = null;
        }

        public APIResponse(HttpStatusCode statusCode, string message, object error = null)
        {
            Success = false;
            StatusCode = statusCode;
            Message = message;
            Data = default(T);
            Error = error;
        }
    }
}
