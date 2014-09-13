using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogiclayer
{
    class Dongle3g:Items
    {
        string dongleID;
        Dongle3g(string did)
        {
            dongleID = did;
        }

        public string DongleID
        {
            get { return dongleID; }
          
        }

       
    }


}
