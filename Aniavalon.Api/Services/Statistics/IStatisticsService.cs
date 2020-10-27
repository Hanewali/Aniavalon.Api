using Aniavalon.Api.ApiModels;

namespace Aniavalon.Api.Services.Statistics
{
    public interface IStatisticsService
    {
        void AddEntry(AddEntryRequest request);
        void GetStatistics();
    }
}