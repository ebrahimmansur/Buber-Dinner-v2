
using BuberDinnerV2.CrossCuttingConcerns.DI;
using BuberDinnerV2.Host;

namespace BuberDinnerV2
{
    public class Program
    {
        public static void Main(string[] args)
        {
           WebApplication
                .CreateBuilder(args)
                .AddServices(typeof(IServiceInstaller).Assembly)
                .AddMiddleWares()
                .Run();
          

           
        }
    }
}