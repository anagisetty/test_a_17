namespace Test_A_17
{
    public class RenewalDataService
    {
        private RenewalDataRepository _renewalDataRepository;

        public RenewalDataService()
        {
            _renewalDataRepository = new RenewalDataRepository();
        }

        public void ReceiveRenewalDataBefore1stJan2020(RenewalData renewalData)
        {
            if (renewalData.IsBefore1stJan2020())
            {
                _renewalDataRepository.AddRenewalData(renewalData);
            }
        }

        public List<RenewalData> GetAllRenewalData()
        {
            return _renewalDataRepository.GetAllRenewalData();
        }

        public void UpdateRenewalDataBefore1stJan2020(RenewalData renewalData)
        {
            if (renewalData.IsBefore1stJan2020())
            {
                _renewalDataRepository.UpdateRenewalData(renewalData);
            }
        }

        public void DeleteRenewalDataBefore1stJan2020(RenewalData renewalData)
        {
            if (renewalData.IsBefore1stJan2020())
            {
                _renewalDataRepository.DeleteRenewalData(renewalData);
            }
        }
    }
}