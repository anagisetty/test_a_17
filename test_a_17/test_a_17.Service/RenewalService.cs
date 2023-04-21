using System;

namespace test_a_17
{
    public class RenewalService
    {
        private RenewalRepository _renewalRepository;

        public RenewalService(RenewalRepository renewalRepository)
        {
            _renewalRepository = renewalRepository;
        }

        public RenewalData GetRenewalData()
        {
            return _renewalRepository.GetRenewalData();
        }

        public void CreateRenewalData(RenewalData renewalData)
        {
            if (renewalData.RenewalDate < new DateTime(2020, 1, 1))
            {
                _renewalRepository.CreateRenewalData(renewalData);
            }
            else
            {
                throw new Exception("Cannot create renewal data after 1st Jan 2020");
            }
        }

        public void UpdateRenewalData(RenewalData renewalData)
        {
            if (renewalData.RenewalDate < new DateTime(2020, 1, 1))
            {
                _renewalRepository.UpdateRenewalData(renewalData);
            }
            else
            {
                throw new Exception("Cannot update renewal data after 1st Jan 2020");
            }
        }

        public void DeleteRenewalData(RenewalData renewalData)
        {
            if (renewalData.RenewalDate < new DateTime(2020, 1, 1))
            {
                _renewalRepository.DeleteRenewalData(renewalData);
            }
            else
            {
                throw new Exception("Cannot delete renewal data after 1st Jan 2020");
            }
        }
    }
}