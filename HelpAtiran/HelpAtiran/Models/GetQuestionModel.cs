using ClassModels;
using HelpModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Web.Http;

namespace HelpAtiran.Models
{
    [DataContract]
    public class GetQuestionModel
    {
        [DataMember]
        public UsersManagements authenticationUser { get; set; }

        [DataMember]
        public Question question { get; set; }
    }
}
