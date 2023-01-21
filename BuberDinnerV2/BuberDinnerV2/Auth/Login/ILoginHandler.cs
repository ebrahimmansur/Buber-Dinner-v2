using BuberDinnerV2.CrossCuttingConcerns;

namespace BuberDinnerV2.Auth.Login
{
    public interface ILoginHandler
    {
       Task<ResultModel<LoginResultModel>> HandleAsync(LoginRequestModel loginRequest);
    }
}
