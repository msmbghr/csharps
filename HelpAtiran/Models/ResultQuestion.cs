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
        public IEnumerable<Question> question { get; set; }

        public ResultQuestion(IEnumerable<Question> question)
        {
            this.question = question;
        }
    }
}
