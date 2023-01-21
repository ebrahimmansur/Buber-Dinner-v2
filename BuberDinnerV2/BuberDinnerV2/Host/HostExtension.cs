using BuberDinnerV2.Auth.Login;
using BuberDinnerV2.Auth.Register;
using BuberDinnerV2.CrossCuttingConcerns.Auth;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace BuberDinnerV2.Host
{

    /// <summary>
    /// The host model extension encapsulate the process of
    /// [ adding services and configure middlewares ]
    /// </summary>
    public static class HostExtension
    {

        public static WebApplicationBuilder AddServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();
            builder.Services.AddScoped<LoginInteractor>();
            builder.Services.AddScoped<RegisterInteractor>();
            builder.Services.TryAddScoped<ILoginHandler, AuthHandler>();
            builder.Services.TryAddScoped<IRegisterHandler, AuthHandler>();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            return builder;
        }


        public static WebApplication AddMiddleWares(this WebApplicationBuilder web)
        {
            var app = web.Build(); 
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

            return app;
        }
    }
}
