using ClassModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ResultQuestion
    {
        public MessageModel message { get; set; }
        public IEnumerable<Question> question { get; set; }

        public ResultQuestion(MessageModel message, IEnumerable<Question> question)
        {
            this.message = message;
            this.question = question;
        }
    }
}
