using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course.Basics.Static
{
    public class CountryMaster
    {
        public string CountryCode { get; set; }
        public string CountryName { get; set; }

        private string ComputerName
        {
            get
            {
                return CommonTask.ComputerName;
            }
        }
        public void Insert()
        {
            if (!CommonTask.IsEmpty(CountryCode) && !CommonTask.IsEmpty(CountryName))
            {
                //Logic to Insert the Country Details into the Database
                //ComputerName property tells from which computer the Record is being Inserted
            }
        }
    }
}
