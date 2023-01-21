using BuberDinnerV2.Auth.Register;
using BuberDinnerV2.CrossCuttingConcerns;

namespace BuberDinnerV2.Auth.Login
{

    /// <summary>
    /// The Model encapsulate the business logic of login a user. 
    /// </summary>
    public class LoginInteractor
    {
        private readonly ILoginHandler _loginHandler;

        public LoginInteractor(ILoginHandler loginHandler)
        {
            _loginHandler = loginHandler;
        }

        public async Task<ResultModel<LoginResultModel>> ExecuteAsync(LoginRequestModel request)
            //Process the request and vaildat with business rules - value objects next time.
            => await _loginHandler.HandleAsync(request);

    }
}
