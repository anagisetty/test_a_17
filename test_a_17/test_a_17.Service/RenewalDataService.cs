namespace Test_a_17
{
    public class RenewalDataService
    {
        private readonly RenewalDataRepository _renewalDataRepository;

        public RenewalDataService(RenewalDataRepository renewalDataRepository)
        {
            _renewalDataRepository = renewalDataRepository;
        }

        public void CreateRenewalData(RenewalData renewalData)
        {
            if(renewalData.RenewalDate >= DateTime.Now)
            {
                _renewalDataRepository.CreateRenewalData(renewalData);
            }
        }

        public RenewalData GetRenewalData(int id)
        {
            return _renewalDataRepository.GetRenewalData(id);
        }

        public List<RenewalData> GetRenewalDataBefore1stJan2020()
        {
            return _renewalDataRepository.GetRenewalDataBefore1stJan2020();
        }

        public void UpdateRenewalData(RenewalData renewalData)
        {
            _renewalDataRepository.UpdateRenewalData(renewalData);
        }

        public void DeleteRenewalData(int id)
        {
            _renewalDataRepository.DeleteRenewalData(id);
        }
    }
}