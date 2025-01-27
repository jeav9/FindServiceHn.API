﻿
using FindServiceHn.Database.Models;
using FindServiceHN.Core.Authentication;
using FindServiceHN.Core.ProviderManager;
using Microsoft.AspNetCore.Mvc;
namespace FindServiceHn.API.Controllers
{
	[Authorize]
	[Route("api/[controller]")]

	public class ProviderController : ControllerBase
	{
		private readonly IProviderManager ProviderManager;
		public ProviderController(IProviderManager ProviderManager)
		{
			this.ProviderManager = ProviderManager;
		}
        #region"provider"
        [HttpGet("GetProvider")]

        public async Task<IActionResult> GetAllAsync()
        {
            var providersResult = await ProviderManager.GetAllAsync();
            if (!providersResult.Any())
            {
                return NotFound();
            }
            return this.Ok(providersResult);
        }

        [AllowAnonymous]
        [HttpPost("Create")]
        public async Task<IActionResult> Post([FromBody] ProviderDTO provider)
        {
            if (provider != null)
            {
                var result = await this.ProviderManager.CreateProviderAsync(provider);
                return this.Ok(result);
            }
            return this.BadRequest();
        }

        [HttpPut("Update")]
        public async Task<IActionResult> UpdateAsync([FromBody] Provider provider
            )
        {
            var result = await this.ProviderManager.UpdateProviderAsync(provider);
            if (result != null)
                return this.Accepted(provider);

            return this.BadRequest();
        }

        [HttpDelete("Remove/{id}")]
        public async Task<IActionResult> RemoveAsync(int id)
        {
            var result = await this.ProviderManager.DeleteProviderAsync(id);
            return this.Ok(result);
        }
        #endregion


        #region"providerplanjob"
        [HttpGet("GetProviderPlanJob")]

        public async Task<IActionResult> GetProviderPlanJob()
        {
            var providerPlanJobResult = await this.ProviderManager.GetProviderPlanJobAsync();
            if (!providerPlanJobResult.Any())
            {
                return NotFound();
            }
            return this.Ok(providerPlanJobResult);
        }
        [AllowAnonymous]
        [HttpPost("CreatePlanJob")]
        public async Task<IActionResult> CreatePlanJob([FromBody] ProviderPlanJobDTO providerPlanJob)
        {
            if (providerPlanJob != null)
            {
                var result = await this.ProviderManager.CreateProviderPlanJobAsync(providerPlanJob);
                return this.Ok(result);
            }
            return this.BadRequest();
        }
        [HttpPut("UpdatePlanJob")]
        public async Task<IActionResult> UpdatePlanJob([FromBody] ProviderPlanJob providerPlanJob
            )
        {
            var result = await this.ProviderManager.UpdateProviderPlanJobAsync(providerPlanJob);
            if (result != null)
                return this.Accepted(providerPlanJob);

            return this.BadRequest();
        }

        [HttpDelete("RemovePlanJob")]
        public async Task<IActionResult> RemovePlanJob(int id)
        {
            var result = await this.ProviderManager.DeleteProviderPlanJobAsync(id);
            return this.Ok(result);
        }
        #endregion
        #region
        [HttpGet("GetProviderService")]

        public async Task<IActionResult> GetProviderService()
        {
            var ProviderServiceResult = await this.ProviderManager.GetAllAsync();
            if (!ProviderServiceResult.Any())
            {
                return NotFound();
            }
            return this.Ok(ProviderServiceResult);
        }
        [AllowAnonymous]
        [HttpPost("CreateService")]
        public async Task<IActionResult> CreateService([FromBody] ProviderServiceDTO providerService)
        {
            if (providerService != null)
            {
                var result = await this.ProviderManager.CreateProviderServiceAsync(providerService);
                return this.Ok(result);
            }
            return this.BadRequest();
        }
        [HttpPut("UpdateService")]
        public async Task<IActionResult> UpdateService([FromBody] ProviderService providerService
            )
        {
            var result = await this.ProviderManager.UpdateProviderServiceAsync(providerService);
            if (result != null)
                return this.Accepted(providerService);

            return this.BadRequest();
        }

        [HttpDelete("RemoveService")]
        public async Task<IActionResult> RemoveService(int id)
        {
            var result = await this.ProviderManager.DeleteProviderServiceAsync(id);
            return this.Ok(result);
        }
        #endregion

        #region

        [HttpGet("GetProviderEval")]

        public async Task<IActionResult> GetProviderEval()
        {
            var ProviderEvalResult = await this.ProviderManager.GetAllAsync();
            if (!ProviderEvalResult.Any())
            {
                return NotFound();
            }
            return this.Ok(ProviderEvalResult);
        }
        [AllowAnonymous]
        [HttpPost("CreateProviderEval")]
        public async Task<IActionResult> CreateProviderEval([FromBody] ProviderEvalDTO providerEval)
        {
            if (providerEval != null)
            {
                var result = await this.ProviderManager.CreateProviderEvalAsync(providerEval);
                return this.Ok(result);
            }
            return this.BadRequest();
        }
        [HttpPut("UpdateProviderEval")]
        public async Task<IActionResult> UpdateProviderEval([FromBody] ProviderEval providerEval
            )
        {
            var result = await this.ProviderManager.UpdateProviderEvalAsync(providerEval);
            if (result != null)
                return this.Accepted(providerEval);

            return this.BadRequest();
        }
        #endregion


    }
}