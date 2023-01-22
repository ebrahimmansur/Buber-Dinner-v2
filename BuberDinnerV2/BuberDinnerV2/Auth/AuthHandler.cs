using BuberDinnerV2.Auth.Login;
using BuberDinnerV2.Auth.Register;
using BuberDinnerV2.CrossCuttingConcerns;

namespace BuberDinnerV2.Auth
{
    /// <summary>
    /// The model encapsulate the auth process.
    /// </summary>
    public class AuthHandler : ILoginHandler, IRegisterHandler
    {
        private readonly JwtTokenGenerator _jwtTokenGenerator;

        public AuthHandler(JwtTokenGenerator jwtTokenGenerator)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
        }

        public Task<ResultModel<RegisterResultModel>> HandelAsync(RegisterRequestModel requestModel)
        {
            string token = _jwtTokenGenerator.Execute(
             id: Guid.NewGuid(),
             firstName: requestModel.FirstName,
             lastName: requestModel.LastName
             );

            var data = new RegisterResultModel(
                Id: Guid.NewGuid(),
                FirstName: requestModel.FirstName,
                LastName: requestModel.LastName,
                Email: requestModel.Email,
                Token: token
                );

            var result = ResultModel<RegisterResultModel>.Success(data);

            return Task.FromResult(result);
        }

        public Task<ResultModel<LoginResultModel>> HandleAsync(LoginRequestModel loginRequest)
        {
            //handel checking if user exists
            //handle to generate token from 

            string token = _jwtTokenGenerator.Execute(
                id: Guid.NewGuid(),
                firstName: "Ebarahim",
                lastName: "Mansure"
                );
            
            var data = new LoginResultModel(
               Id: Guid.NewGuid(),
               FirstName: "Test first Name",
               LastName: "Test Last Name",
               Email: loginRequest.Email,
               Token:token
               );

            var result = ResultModel<LoginResultModel>.Success(data);
            return Task.FromResult(result);
        }
    }
}
