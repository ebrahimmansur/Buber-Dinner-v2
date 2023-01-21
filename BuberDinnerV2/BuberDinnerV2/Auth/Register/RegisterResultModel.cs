namespace BuberDinnerV2.Auth.Register
{
    public record RegisterResultModel(
       Guid Id,
       string FirstName,
       string LastName,
       string Email,
       string Token
        );
}
