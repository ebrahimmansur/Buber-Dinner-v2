namespace BuberDinnerV2.CrossCuttingConcerns.DI
{
    public interface IServiceInstaller
    {
        void Install(IServiceCollection services, IConfiguration configuration);
    }
}
