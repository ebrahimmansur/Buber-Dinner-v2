namespace BuberDinnerV2.CrossCuttingConcerns.DateProviders
{
    public interface IDateTimeProvider
    {
        DateTime UtcNow { get; }
    }
}
