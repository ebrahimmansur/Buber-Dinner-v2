
using BuberDinnerV2.Host;

namespace BuberDinnerV2
{
    public class Program
    {
        public static void Main(string[] args)
        {
           WebApplication
                .CreateBuilder(args)
                .AddServices()
                .AddMiddleWares()
                .Run();
          

           
        }
    }
}