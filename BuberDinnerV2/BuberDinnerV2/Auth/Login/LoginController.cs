using Microsoft.AspNetCore.Mvc;

namespace BuberDinnerV2.Auth.Login
{

    [ApiController]
    [Tags("Auth")]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly LoginInteractor _interactor;

        public LoginController(LoginInteractor interactor)
        {
            _interactor = interactor;
        }

        [HttpPost] 
        public async Task<IActionResult> login(LoginRequestModel requestModel)
        {

            var result = await _interactor.Execute(requestModel);
            if (result.IsSuccess())
            {

                return Ok(result.SuccessData!);

            }

            return BadRequest(result.FailureData!.Message);
        }
    }
}
