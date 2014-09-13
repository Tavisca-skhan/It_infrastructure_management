using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogiclayer
{
    class Employee
    {
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        int empID;

        public int EmpID
        {
            get { return empID; }
            set { empID = value; }
        }
        string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        string location;

        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        string email_ID;

        public string Email_ID
        {
            get { return email_ID; }
            set { email_ID = value; }
        }
    }
}
