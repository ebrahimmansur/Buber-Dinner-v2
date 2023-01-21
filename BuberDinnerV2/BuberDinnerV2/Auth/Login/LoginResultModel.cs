namespace BuberDinnerV2.Auth.Login
{
    public record LoginResultModel (
       Guid Id,
       string FirstName,
       string LastName,
       string Email,
       string Token
        );
}

