using BuberDinnerV2.Auth.Login;
using BuberDinnerV2.Auth.Register;
using BuberDinnerV2.CrossCuttingConcerns.DI;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace BuberDinnerV2.Auth
{
    public class AuthServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {


            services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
            services.AddSingleton<JwtTokenGenerator>();
            services.AddScoped<LoginInteractor>();
            services.AddScoped<RegisterInteractor>();
            services.TryAddScoped<ILoginHandler, AuthHandler>();
            services.TryAddScoped<IRegisterHandler, AuthHandler>();
            services.AddScoped<JwtTokenGenerator>();
        }
    }
}
