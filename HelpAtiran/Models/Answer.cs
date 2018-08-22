using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassModels
{
   public partial class Answer
    {
        public int id { get; set; }
        public int idQuestion { get; set; }
        public string answer { get; set; }
        public string active { get; set; }


    }
}
