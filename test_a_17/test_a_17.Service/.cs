namespace Test_A_17
{
    public class RenewalData
    {
        public DateTime RenewalDate { get; set; }
        public string Description { get; set; }
        public bool IsBeforeJan1st { get; set; }
    }

    public class RenewalDataService
    {
        public bool CheckIfRenewalDataIsBeforeJan1st(RenewalData renewalData)
        {
            if (renewalData.RenewalDate < DateTime.Parse("1/1/2020"))
            {
                renewalData.IsBeforeJan1st = true;
                return true;
            }
            else
            {
                renewalData.IsBeforeJan1st = false;
                return false;
            }
        }
    }

    public class RenewalDataRepository
    {
        public void SaveRenewalData(RenewalData renewalData)
        {
            //Save renewal data to the database
        }
    }
}