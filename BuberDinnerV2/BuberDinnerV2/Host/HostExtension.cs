﻿namespace BuberDinnerV2.Host
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