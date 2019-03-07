using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class resulttest
    {
        public MessageModel message { get; set; }
        public string result { get; set; }
        public resulttest(MessageModel message, string result)
        {
            this.message = message;
            this.result = result;
        }
    }
}
