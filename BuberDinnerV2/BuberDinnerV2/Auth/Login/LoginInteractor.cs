using BuberDinnerV2.Auth.Register;
using BuberDinnerV2.CrossCuttingConcerns;

namespace BuberDinnerV2.Auth.Login
{
    public class LoginInteractor
    {

        public Task<ResultModel<LoginResultModel>> Execute( LoginRequestModel request)
        {

            var data = new LoginResultModel(
               Id: Guid.NewGuid(),
               FirstName: "Test first Name",
               LastName: "Test Last Name",
               Email: request.Email,
               Token: "Test-ejy33044-33223-3ddw3-3r-3-3-3e-3-e-3-efdfsdvdsv"
               );


            var result = ResultModel<LoginResultModel>.Success(data);

            return Task.FromResult(result);

        }

    }
}
