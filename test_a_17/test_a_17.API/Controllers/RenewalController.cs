using System;
using System.Web.Http;

namespace test_a_17
{
    public class RenewalController : ApiController
    {
        private RenewalService _renewalService;

        public RenewalController(RenewalService renewalService)
        {
            _renewalService = renewalService;
        }

        [HttpGet]
        public RenewalData GetRenewalData()
        {
            return _renewalService.GetRenewalData();
        }

        [HttpPost]
        public void CreateRenewalData(RenewalData renewalData)
        {
            if (renewalData.RenewalDate < new DateTime(2020, 1, 1))
            {
                _renewalService.CreateRenewalData(renewalData);
            }
            else
            {
                throw new Exception("Cannot create renewal data after 1st Jan 2020");
            }
        }

        [HttpPut]
        public void UpdateRenewalData(RenewalData renewalData)
        {
            if (renewalData.RenewalDate < new DateTime(2020, 1, 1))
            {
                _renewalService.UpdateRenewalData(renewalData);
            }
            else
            {
                throw new Exception("Cannot update renewal data after 1st Jan 2020");
            }
        }

        [HttpDelete]
        public void DeleteRenewalData(RenewalData renewalData)
        {
            if (renewalData.RenewalDate < new DateTime(2020, 1, 1))
            {
                _renewalService.DeleteRenewalData(renewalData);
            }
            else
            {
                throw new Exception("Cannot delete renewal data after 1st Jan 2020");
            }
        }
    }
}