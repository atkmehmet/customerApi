namespace CustomerApiNew.Application
{
    public class Result<T>
    {
        public bool IsSuccess { get; }
        public string? Message { get; }
        public T? Data { get; }

        private Result(bool isSuccess, string? message, T? data)
        {
            IsSuccess = isSuccess;
            Message = message;
            Data = data;
        }



        public static Result<T> Success (T data,string? messages = null)
            => new Result<T> (true,messages,data);

        public static Result<T> Failure( string messages)
            => new Result<T> (false, messages,default);
    }
}
