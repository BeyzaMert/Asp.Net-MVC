using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class UserType
    {
        public int UserTypeID { get; set; }
        public string UserTypeName { get; set; }
        public bool IsActive { get; set; }

        public List<User> Users { get; set; }
    }
}
