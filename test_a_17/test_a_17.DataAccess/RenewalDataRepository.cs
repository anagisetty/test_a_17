namespace Test_A_17
{
    public class RenewalDataRepository
    {
        private readonly List<RenewalData> _renewalDataList;

        public RenewalDataRepository()
        {
            _renewalDataList = new List<RenewalData>();
        }

        public IEnumerable<RenewalData> GetRenewalDataBeforeJan1st()
        {
            return _renewalDataList.Where(data => data.IsBeforeJan1st);
        }

        public void AddRenewalData(RenewalData renewalData)
        {
            _renewalDataList.Add(renewalData);
        }
    }
}