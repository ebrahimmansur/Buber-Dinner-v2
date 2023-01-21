namespace BuberDinnerV2.CrossCuttingConcerns
{

    public enum FailureCode
    {
        network = 001,
        invaildInput = 002
    }
    public class Failure
    {
        private readonly string _message;
        private readonly FailureCode _statusCode;

        private Failure(FailureCode code, string message)
        {
            _statusCode = code;
            _message = message;
        }
        

        public string Message  => _message;
        public FailureCode Code => _statusCode;

        public static Failure NetworkFailure(string message) => new Failure(FailureCode.network, message);
        public static Failure InvaildInputFailure(string message) => new Failure( FailureCode.invaildInput,  message);


    }

  
}
