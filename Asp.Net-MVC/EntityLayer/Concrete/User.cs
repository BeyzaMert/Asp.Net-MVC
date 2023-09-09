using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserMail { get; set; }
        public string Password { get; set; }

        public int UserTypeID { get; set; }
        public UserType UserType { get; set; }
    }
}
