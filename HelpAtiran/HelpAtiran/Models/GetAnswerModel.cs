using ClassModels;
using HelpModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace HelpAtiran.Models
{
    [DataContract]
    public class GetAnswerModel
    {
        [DataMember]
        public UsersManagements authenticationUser { get; set; }

        [DataMember]
        public Answer answer { get; set; }

        public GetAnswerModel()
        {

        }
    }
}