using BuberDinnerV2.CrossCuttingConcerns.DateProviders;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BuberDinnerV2.Auth
{

    /// <summary>
    /// The model encapsulate the token generating process.
    /// </summary>
    public class JwtTokenGenerator
    {
        private readonly IDateTimeProvider _dateTimeProvider;
        private readonly JwtSettings _jwtSettings;

        public JwtTokenGenerator(IDateTimeProvider dateTimeProvider,IOptions<JwtSettings> jwtSettings)
        {
            _dateTimeProvider = dateTimeProvider;
            _jwtSettings = jwtSettings.Value;
        }

        public string Execute(Guid id, string firstName, string lastName)
        {
            //the payload needed in the token.
            //claims - payload
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, id.ToString()),
                new Claim("first_name", firstName),
                new Claim("last_name", lastName),

            };

            //signingCredentials
            // we need a securt key and algrittom
            var signingCredentials = new SigningCredentials(
                new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Secret)),
                _jwtSettings.Alg
                );
            //security token -> climes + signing cradintoasl
            var securiyToken = new JwtSecurityToken( 
                issuer:_jwtSettings.Issuer,
                expires: _dateTimeProvider.UtcNow.AddMinutes(_jwtSettings.ExpiryMinutes),
                claims:claims,
                signingCredentials:signingCredentials,
                audience: _jwtSettings.Audience
                );


            //create the access token
            var accessToken = new JwtSecurityTokenHandler().WriteToken(securiyToken);


            return accessToken;
        }
    }
}
