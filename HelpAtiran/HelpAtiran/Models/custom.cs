using HelpModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelpAtiran.Models
{
    public class custom
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public Nullable<int> status { get; set; }
        public string DeviceId { get; set; }
        public int? userpermition { get; set; }

    }
}