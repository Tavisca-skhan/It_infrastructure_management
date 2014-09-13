using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogiclayer
{
    public abstract class Items
    {
        string brand;
        bool isssigned;

        public bool Isssigned
        {
            get { return isssigned; }
            set { isssigned = value; }
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        DateTime creation_date;

        public DateTime Creation_date
        {
            get { return creation_date; }
            set { creation_date = value; }
        }

        DateTime actual_expiry_date;

        public DateTime Actual_expiry_date
        {
            get { return actual_expiry_date; }
            set { actual_expiry_date = value; }
        }
        bool Warranty_exists;

        public bool Warranty_exists1
        {
            get { return Warranty_exists; }
            set { Warranty_exists = value; }
        }
        DateTime WarrantyExpiration;

        public DateTime WarrantyExpiration1
        {
            get { return WarrantyExpiration; }
            set { WarrantyExpiration = value; }
        } 


    }

}
