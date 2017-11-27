using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoingOutCalendar.Model
{
   public  class Host
    {
        public string Cpr { get; set; }
        public string Name { get; set; }

        public string TelephoneNumber { get; set; }



        public Host(string cpr, string name, string telephoneNumber)
        {
            Cpr = cpr;
            Name = name;
            TelephoneNumber = telephoneNumber;

        }

        public Host()
        {

        }

        public override string ToString()
        {
            return Name + Cpr + TelephoneNumber;
        }
    }
}

