using System.Collections.Generic;
using System.Web.Http;

namespace Test_A_17
{
    public class RenewalDataController : ApiController
    {
        private RenewalDataService _renewalDataService;

        public RenewalDataController()
        {
            _renewalDataService = new RenewalDataService();
        }

        [HttpPost]
        public void ReceiveRenewalDataBefore1stJan2020([FromBody] RenewalData renewalData)
        {
            _renewalDataService.ReceiveRenewalDataBefore1stJan2020(renewalData);
        }

        [HttpGet]
        public List<RenewalData> GetAllRenewalData()
        {
            return _renewalDataService.GetAllRenewalData();
        }

        [HttpPut]
        public void UpdateRenewalDataBefore1stJan2020([FromBody] RenewalData renewalData)
        {
            _renewalDataService.UpdateRenewalDataBefore1stJan2020(renewalData);
        }

        [HttpDelete]
        public void DeleteRenewalDataBefore1stJan2020([FromBody] RenewalData renewalData)
        {
            _renewalDataService.DeleteRenewalDataBefore1stJan2020(renewalData);
        }
    }
}