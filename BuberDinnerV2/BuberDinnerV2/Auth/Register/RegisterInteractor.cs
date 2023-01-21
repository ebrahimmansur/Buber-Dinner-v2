using BuberDinnerV2.CrossCuttingConcerns;

namespace BuberDinnerV2.Auth.Register
{

    /// <summary>
    /// The Model encapsulate the business logic of registration. 
    /// </summary>
    public class RegisterInteractor
    {
        private readonly IRegisterHandler _registerHandler;

        public RegisterInteractor(IRegisterHandler registerHandler)
        {
            _registerHandler = registerHandler;
        }

        public async Task<ResultModel<RegisterResultModel>> ExecuteAsync(RegisterRequestModel request)
            //Process the request and vaildat with business rules - value objects next time.
            => await _registerHandler.HandelAsync(request);
    }
}
