using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoingOutCalendar.Model
{
    public class Member

    {
        public string Email { get; set; }
        public string Password { get; set; }

        public string  Name { get; set; }



        public Member (string email, string password, string name)
        {
            Email = email;
            Name = name;
            Password = password;

        }

        public Member()
        {

        }

        public override string ToString()
        {
            return Name + Email + Password;
        }
    }
}

