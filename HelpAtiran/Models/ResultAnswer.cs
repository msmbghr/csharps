using ClassModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ResultAnswer
    {
        public MessageModel message { get; set; }

        public IEnumerable<Answer> answer { get; set; }


        public ResultAnswer(MessageModel message,IEnumerable<Answer> answer)
        {
            this.message = message;
            this.answer = answer;
        }
    }
}
