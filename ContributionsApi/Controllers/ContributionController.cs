using ContributionsApi.BusinessService.Interface;
using ContributionsApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContributionsApi.Controllers
{
    [Route("contributionapi")]
    [ApiController]
    public class ContributionController : ControllerBase
    {
        private readonly IContributionsService _contributionsService;
        public ContributionController(IContributionsService contributionsService)
        {
            _contributionsService= contributionsService;
        }

        [HttpGet("GetContributionById/{contributionId}")]
        public async Task<IActionResult> GetContributionByIdAsync(int contributionId)
        {
            var contribution = await _contributionsService.GetContributionByIdAsync(contributionId);
            return Ok(contribution);
        }

        [HttpGet("GetContributionByTaskId/{taskId}")]
        public async Task<IActionResult> GetContributionByTaskIdAsync(int taskId)
        {
            var contribution = await _contributionsService.GetContributionByIdAsync(taskId);
            return Ok(contribution);
        }

        [HttpGet("GetContributions")]
        public async Task<IActionResult> GetContributionsAsync()
        {
            var contributions = await _contributionsService.GetContributionsAsync();
            return Ok(contributions);
        }

        [HttpPost("PostContribution")]
        public async Task<IActionResult> PostContributionAsync([FromBody] Contributions model)
        {
            var contribution= await _contributionsService.PostContributionAsync(model);
            return Ok(contribution);
        }

        [HttpPut("PutContribution")]
        public async Task<IActionResult> PutContributionAsync([FromBody] Contributions model)
        {
            var contribution = await _contributionsService.PutContributionAsync(model);
            return Ok(contribution);
        }


        [HttpDelete("DeleteContributionByIdAsync/{contributionId}")]
        public async Task<IActionResult> DeleteContributionByIdAsync(int contributionId)
        {
            var response = await _contributionsService.DeleteContributionAsync(contributionId);
            return Ok("Successfully deleted the contribution");
        }
    }
}
