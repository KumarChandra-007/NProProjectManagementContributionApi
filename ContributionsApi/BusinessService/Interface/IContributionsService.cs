using ContributionsApi.Models;

namespace ContributionsApi.BusinessService.Interface
{
    public interface IContributionsService
    {
        Task<Contributions> GetContributionByIdAsync(int contributionId);
        Task<Contributions> GetContributionByTaskIdAsync(int taskId);        
        Task<List<Contributions>> GetContributionsAsync();
        Task<Contributions> PostContributionAsync(Contributions model);
        Task<Contributions> PutContributionAsync(Contributions model);
        Task<bool> DeleteContributionAsync(int contributionId);
    }
}
