using BuberDinnerV2.CrossCuttingConcerns.DateProviders;
using BuberDinnerV2.CrossCuttingConcerns.DI;

namespace BuberDinnerV2.CrossCuttingConcerns.DateTimeProviders
{
    public class DateTimeServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
           services.AddSingleton<IDateTimeProvider, DataTimeProvider>();
        }
    }
}
