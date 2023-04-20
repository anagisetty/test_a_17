using System;
using System.Collections.Generic;
using Test_a_17;
using Microsoft.AspNetCore.Mvc;

namespace Test_a_17.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RenewalDataController : ControllerBase
    {
        private readonly RenewalDataService _renewalDataService;

        public RenewalDataController(RenewalDataService renewalDataService)
        {
            _renewalDataService = renewalDataService;
        }
        
        [HttpPost]
        public void CreateRenewalData(RenewalData renewalData)
        {
            if(renewalData.RenewalDate >= DateTime.Now)
            {
                _renewalDataService.CreateRenewalData(renewalData);
            }
        }

        [HttpGet("{id}")]
        public RenewalData GetRenewalData(int id)
        {
            return _renewalDataService.GetRenewalData(id);
        }

        [HttpGet("before1stJan2020")]
        public List<RenewalData> GetRenewalDataBefore1stJan2020()
        {
            return _renewalDataService.GetRenewalDataBefore1stJan2020();
        }

        [HttpPut]
        public void UpdateRenewalData(RenewalData renewalData)
        {
            _renewalDataService.UpdateRenewalData(renewalData);
        }

        [HttpDelete("{id}")]
        public void DeleteRenewalData(int id)
        {
            _renewalDataService.DeleteRenewalData(id);
        }
    }
}