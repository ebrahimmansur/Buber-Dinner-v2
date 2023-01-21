using BuberDinnerV2.CrossCuttingConcerns;

namespace BuberDinnerV2.Auth.Register
{

    /// <summary>
    /// The Model encapsulate the business logic of registration. 
    /// </summary>
    public class RegisterInteractor
    {
      public  Task<ResultModel<RegisterResultModel>> Execute(RegisterRequestModel request) {


            var data = new RegisterResultModel(
                Id:Guid.NewGuid(),
                FirstName:request.FirstName,
                LastName: request.LastName,
                Email:request.Email,
                Token:"Test-ejy33044-33223-3ddw3-3r-3-3-3e-3-e-3-efdfsdvdsv"
                );

            var result = ResultModel<RegisterResultModel>.Success(data);
            
            return Task.FromResult(result);

        }
    }
}
