﻿using ContributionsApi.BusinessService.Interface;
using ContributionsApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContributionsApi.Controllers
{
    [Route("api/[controller]")]
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
            if (contribution == null)
            {
                return BadRequest("Error while reading contribution");
            }

            return Ok(contribution);
        }

        [HttpGet("GetContributions")]
        public async Task<IActionResult> GetContributionsAsync()
        {
            var contributions = await _contributionsService.GetContributionsAsync();
            if (contributions== null)
            {
                return BadRequest("Error while reading contributions");
            }

            return Ok(contributions);
        }

        [HttpPost("PostContribution")]
        public async Task<IActionResult> PostContributionAsync([FromBody] Contributions model)
        {
            var contribution= await _contributionsService.PostContributionAsync(model);
            if(contribution==null)
            {
                return BadRequest("Error while saving contribution");
            }

            return Ok(contribution);
        }

        [HttpPut("PutContribution")]
        public async Task<IActionResult> PutContributionAsync([FromBody] Contributions model)
        {
            var contribution = await _contributionsService.PutContributionAsync(model);
            if (contribution == null)
            {
                return BadRequest("Error while updating contribution");
            }

            return Ok(contribution);
        }


        [HttpDelete("DeleteContributionByIdAsync/{contributionId}")]
        public async Task<IActionResult> DeleteContributionByIdAsync(int contributionId)
        {
            var response = await _contributionsService.DeleteContributionAsync(contributionId);
            if (!response)
            {
                return BadRequest("Failed to delete contribution");
            }

            return Ok("Successfully deleted the contribution");
        }
    }
}