namespace Aniavalon.Api.Services.Statistics
{
    public interface IStatisticsService
    {
        void AddEntry(int personId, int sideId, int playerCount);
        void GetStatistics();
    }
}