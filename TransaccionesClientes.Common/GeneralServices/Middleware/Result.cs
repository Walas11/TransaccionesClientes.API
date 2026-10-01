namespace TransaccionesClientes.Common.GeneralServices.Middleware
{
    public class Result<T>
    {
        public bool IsSuccess { get; set; }
        public T? Value { get; set; }
        public string? Error { get; set; }
        public List<string>? Errors { get; set; }

        private Result(bool isSuccess, T? value, string? error, List<string>?  errors)
        {
            IsSuccess = isSuccess;
            Value = value;
            Error = error;
            Errors = errors;
        }

        public static Result<T> Success(T value) => new(true, value, null, null);
        public static Result<T> Failure(string? error) => new(false, default, error, null);
        public static Result<T> Failure(List<string>? errors) => new(false, default, null, errors);
    }
}
