using BuberDinnerV2.Auth.Login;
using BuberDinnerV2.Auth.Register;
using BuberDinnerV2.CrossCuttingConcerns;

namespace BuberDinnerV2.Auth
{
    public class AuthHandler : ILoginHandler, IRegisterHandler
    {
        public Task<ResultModel<RegisterResultModel>> HandelAsync(RegisterRequestModel requestModel)
        {
            var data = new RegisterResultModel(
                Id: Guid.NewGuid(),
                FirstName: requestModel.FirstName,
                LastName: requestModel.LastName,
                Email: requestModel.Email,
                Token: "Test-ejy33044-33223-3ddw3-3r-3-3-3e-3-e-3-efdfsdvdsv"
                );

            var result = ResultModel<RegisterResultModel>.Success(data);

            return Task.FromResult(result);
        }

        public Task<ResultModel<LoginResultModel>> HandleAsync(LoginRequestModel loginRequest)
        {
            var data = new LoginResultModel(
               Id: Guid.NewGuid(),
               FirstName: "Test first Name",
               LastName: "Test Last Name",
               Email: loginRequest.Email,
               Token: "Test-ejy33044-33223-3ddw3-3r-3-3-3e-3-e-3-efdfsdvdsv"
               );


            var result = ResultModel<LoginResultModel>.Success(data);

            return Task.FromResult(result);
        }
    }
}
