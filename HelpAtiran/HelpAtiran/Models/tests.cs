using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace HelpAtiran.Models
{
    [DataContract]
    public class tests
    {
        [DataMember]
        public string strmsg { get; set; }
        public tests(string strmsg)
        {
            this.strmsg = strmsg;
        }
    }
}