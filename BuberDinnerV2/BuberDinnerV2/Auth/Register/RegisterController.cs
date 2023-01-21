using Microsoft.AspNetCore.Mvc;

namespace BuberDinnerV2.Auth.Register
{

    [ApiController]
    [Tags("Auth")]
    [Route("api/[controller]")]
    public class RegisterController : ControllerBase
    {
        private readonly RegisterInteractor _registerInteractor;

        public RegisterController(RegisterInteractor registerInteractor)
        {
            _registerInteractor = registerInteractor;
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterRequestModel resultModel)
        {

            var result = await _registerInteractor.Execute(resultModel);
            if (result.IsSuccess())
            {
                return Ok(result.SuccessData);
            }

            return BadRequest(result.FailureData!.Message);

        }
    }
}
