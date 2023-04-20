namespace Test_a_17
{
    public class RenewalDataRepository
    {
        public void CreateRenewalData(RenewalData renewalData)
        {
            if(renewalData.RenewalDate >= DateTime.Now)
            {
                //Database code to create renewal data
            }
        }

        public RenewalData GetRenewalData(int id)
        {
            //Database code to get renewal data by id
            return new RenewalData();
        }

        public List<RenewalData> GetRenewalDataBefore1stJan2020()
        {
            var renewalDataList = new List<RenewalData>();

            //Database code to get renewal data before 1st Jan 2020
            return renewalDataList;
        }

        public void UpdateRenewalData(RenewalData renewalData)
        {
            //Database code to update renewal data
        }

        public void DeleteRenewalData(int id)
        {
            //Database code to delete renewal data by id
        }
    }
}