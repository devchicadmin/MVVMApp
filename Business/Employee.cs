using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Employee
    {
        public Guid CompanyId
        {
            get;
            set;
        }


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

        public string Department
        {
            get;
            set;
        }

      
    }
}
