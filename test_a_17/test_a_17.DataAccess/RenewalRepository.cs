using System;

namespace test_a_17
{
    public class RenewalRepository
    {
        public RenewalData GetRenewalData()
        {
            return new RenewalData();
        }

        public void CreateRenewalData(RenewalData renewalData)
        {
            if (renewalData.RenewalDate < new DateTime(2020, 1, 1))
            {
                // Create Renewal Data
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
                // Update Renewal Data
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
                // Delete Renewal Data
            }
            else
            {
                throw new Exception("Cannot delete renewal data after 1st Jan 2020");
            }
        }
    }
}