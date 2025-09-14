using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectsMVCApplication.Models
{
    public class DesignPattern
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string CountryValue { get; set; }
        public string HoobiesValue { get; set; }
        public string Gender { get; set; }

        public List<string> Country
        {
            get
            {
                var countryList = new List<string>();
                countryList.Add("India");
                countryList.Add("USA");
                countryList.Add("Pakistan");
                countryList.Add("BAN");
                countryList.Add("Congo");
                return countryList;
            }
        }

        public List<string> Hobbies
        {
            get
            {
                var hobbiesList = new List<string>();
                hobbiesList.Add("Cricket");
                hobbiesList.Add("Hockey");
                hobbiesList.Add("Movies");
                return hobbiesList;
            }
        }

        public void AddEmployee()
        {
            return;
        }
    }

   
}