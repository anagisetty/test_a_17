using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using test_a_17;

namespace test_a_17
{
    public class RenewalController : ApiController
    {
        [HttpGet]
        public List<RenewalData> GetRenewalDataBefore1stJan2020()
        {
            List<RenewalData> result = new List<RenewalData>();

            try
            {
                //Get all the renewal records from DB
                var renewalDataList = GetAllRenewalDataFromDB();

                //Filter and get the records before 1st Jan 2020
                result = renewalDataList.Where(x => x.ReceivedDate < new DateTime(2020, 1, 1)).ToList();
            }
            catch(Exception ex)
            {
                //Log exception details
            }

            return result;
        }

        private List<RenewalData> GetAllRenewalDataFromDB()
        {
            //Write logic to get all the renewal data from database
            return new List<RenewalData>();
        }
    }

    public class RenewalData
    {
        public int Id { get; set; }
        public DateTime ReceivedDate { get; set; }
        public DateTime ProcessedDate { get; set; }
    }
}