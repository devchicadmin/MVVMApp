using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    using System.Collections.ObjectModel;

    public class Company
    {
        public Guid Id
        {
            get;
            set;
        }


        public string Name
        {
            get;
            set;
        }

        public string ContactName
        {
            get;
            set;
        }

        public string ContacEmail
        {
            get;
            set;
        }

        public string AddressLine1
        {
            get;
            set;
        }
    }
}
