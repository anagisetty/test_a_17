namespace Test_A_17
{
    public class RenewalDataRepository
    {
        private List<RenewalData> _renewalDataList;

        public RenewalDataRepository()
        {
            _renewalDataList = new List<RenewalData>();
        }

        // Create
        public void AddRenewalData(RenewalData renewalData)
        {
            if (renewalData.IsBefore1stJan2020())
            {
                _renewalDataList.Add(renewalData);
            }
        }

        // Read
        public List<RenewalData> GetAllRenewalData()
        {
            return _renewalDataList;
        }

        // Update
        public void UpdateRenewalData(RenewalData renewalData)
        {
            if (renewalData.IsBefore1stJan2020())
            {
                _renewalDataList.RemoveAll(x => x.ReceiveDate == renewalData.ReceiveDate);
                _renewalDataList.Add(renewalData);
            }
        }

        // Delete
        public void DeleteRenewalData(RenewalData renewalData)
        {
            if (renewalData.IsBefore1stJan2020())
            {
                _renewalDataList.RemoveAll(x => x.ReceiveDate == renewalData.ReceiveDate);
            }
        }
    }
}