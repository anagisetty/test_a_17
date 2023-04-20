namespace Test_A_17
{
    public class RenewalData
    {
        public DateTime ReceiveDate {get;set;}
        public DateTime ExpireDate {get;set;}

        public bool IsBefore1stJan2020()
        {
            return ReceiveDate < new DateTime(2020,1,1);
        }
    }
}