using BuberDinnerV2.CrossCuttingConcerns.DateProviders;

namespace BuberDinnerV2.CrossCuttingConcerns.DateTimeProviders
{

    /// <summary>
    /// The Model that handles the process of genrating the data time.
    /// </summary>
    public class DataTimeProvider : IDateTimeProvider
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}
