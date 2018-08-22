using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpAtiran.Models
{
  public  class ClassMessages
    {
        public int ResposeMessage { get; set; }

        public string username { get; set; }
        public string password { get; set; }
        public Nullable<int> status { get; set; }
        public string DeviceId { get; set; }
        public int userpermition { get; set; }

        public ClassMessages(int ResposeMessage)
        {
            this.ResposeMessage = ResposeMessage;
           
        }
    }
}
