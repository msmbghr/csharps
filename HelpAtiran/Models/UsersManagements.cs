using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassModels
{
    public class UsersManagements
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public Nullable<int> status { get; set; }
        public string DeviceId { get; set; }
        public int userpermition { get; set; }

    }
}
