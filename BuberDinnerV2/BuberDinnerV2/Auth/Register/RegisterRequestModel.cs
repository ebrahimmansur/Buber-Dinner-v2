namespace BuberDinnerV2.Auth.Register
{
    public record RegisterRequestModel(
        string FirstName,
        string LastName,
        string Email,
        string Password
        );
}
