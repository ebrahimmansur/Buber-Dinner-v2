using BuberDinnerV2.CrossCuttingConcerns;

namespace BuberDinnerV2.Auth.Register
{
    public interface IRegisterHandler
    {
        Task<ResultModel<RegisterResultModel>> HandelAsync(RegisterRequestModel requestModel);
    }
}
