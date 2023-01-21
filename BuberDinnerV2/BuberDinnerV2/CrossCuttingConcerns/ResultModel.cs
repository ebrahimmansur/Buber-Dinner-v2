namespace BuberDinnerV2.CrossCuttingConcerns
{
    public class ResultModel<Type>
     where Type : class

    {
        private readonly Failure? _failureData;
        private readonly Type? _sucessData;
        private readonly ResultState _state;

        public bool IsSuccess() => _state == ResultState.Success;

        public Failure? FailureData => _failureData;
        public Type? SuccessData => _sucessData;


        private ResultModel(Failure failure, ResultState state)
        {
            _failureData = failure;
            _state = state;
        }

        private ResultModel(Type success, ResultState state)
        {
            _sucessData = success;
            _state = state;
        }


        public static ResultModel<Type> Success(Type success) => new ResultModel<Type>(success, ResultState.Success);

        public static ResultModel<Type> Failure(Failure failure) => new ResultModel<Type>(failure, ResultState.Failure);
    }

    internal enum ResultState { Success, Failure }
}
