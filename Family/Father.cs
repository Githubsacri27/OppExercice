using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family
{
    public class Father : Grandfather
    {
        public string Job { get; set; }
        protected string Country { get; set; }
        private string Address { get; set; }

        public Father(string name, int age, string favoriteColor, string job, string country, string address)
            : base(name, age, favoriteColor) 
        {
            Job = job;
            Country = country;
            Address = address;
        }

        public string GetAddress() => Address;
        public void SetAddres(string value) => Address = value;
    }
}
