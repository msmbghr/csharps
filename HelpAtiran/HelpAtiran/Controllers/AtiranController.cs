using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HelpModel;
using HelpAtiran.Models;
using ClassModels;
using Models;
using System.Web.Script.Serialization;

namespace HelpAtiran.Controllers
{
    public class AtiranController : ApiController
    {
        AtiranHelpEntities context = new AtiranHelpEntities();

        public enum MessageCode
        {
            UserNotFind = 0,
            UsernameOrPasswordError = 1,
            ProductIdError = 2,
            OkUser = 3,
            Savedata = 4,
            EntityUser = 5,
            DuplicateData=6

        }
        public MessageModel authenticationUser(UsersManagements management)
        {
            MessageModel message = new MessageModel();
            var query = (from i in context.UsersManagement where i.DeviceId == management.DeviceId && i.status == 1 select i).FirstOrDefault();
            if (query == null)
            {
                message.idMessage = (int)MessageCode.UserNotFind;
                message.contextMessage = "كاربري پيدا نشد";
            }
            else
            {
                if (query.username.ToLower() == management.username.ToLower()
                && query.password.ToLower() == management.password.ToLower()
                && query.status == management.status)
                {
                    message.idMessage = (int)MessageCode.OkUser;
                    message.contextMessage = "كاربر مورد نظر موجود مي باشد";
                }
                else
                {
                    message.idMessage = (int)MessageCode.UsernameOrPasswordError;
                    message.contextMessage = "نام كاربر يا رمز ورود شما اشتباه مي باشد";
                }
            }

            return message;

        }
        public MessageModel authenticationCreateUser(UsersManagements management)
        {
            try
            {
                MessageModel message = new MessageModel();
                var query = (from i in context.UsersManagement
                             where i.username == management.username.ToString().Trim() ||
i.DeviceId == management.DeviceId
                             select i).ToList();
                if (query.Count == 0)
                {
                    message.idMessage = (int)MessageCode.Savedata;
                    message.contextMessage = "كاربر شما ثبت شد";
                }
                else
                {

                    message.idMessage = (int)MessageCode.EntityUser;
                    message.contextMessage = "اين يوز قبلا ثبت شده است";
                }
                return message;

            }
            catch (Exception)
            {
                MessageModel message = new MessageModel();
                message.idMessage = (int)MessageCode.UserNotFind;
                return message;
            }



        }


        #region USERS

        [HttpPost]
        [Route("~/post/createUser")]
        public HttpResponseMessage createUser([FromBody]UsersManagements user)
        {
            try
            {
                MessageModel value = new MessageModel();
                value = authenticationCreateUser(user);
                ClassMessages e = new ClassMessages((int)value.idMessage);
                if (value.idMessage == (int)MessageCode.Savedata)
                {
                    UsersManagement u = new UsersManagement
                    {
                        username = user.username,
                        password = user.password,
                        status = user.status,
                        DeviceId = user.DeviceId
                    };
                    UsePermition up = new UsePermition { permitionId = user.userpermition, UsersManagement = u };
                    context.UsersManagement.Add(u);
                    context.UsePermition.Add(up);
                    context.SaveChanges();
                    var message = Request.CreateResponse(HttpStatusCode.OK, e);
                    return message;

                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, e);

                }

            }
            catch (Exception ex)
            {
                ClassMessages e = new ClassMessages(5);
                return Request.CreateResponse(HttpStatusCode.OK, e);
            }

        }


        [HttpPost]
        [Route("~/post/update/users")]
        public HttpResponseMessage updateUsers(UsersManagements updateUserMode)
        {
            try
            {

                var q = context.UsersManagement.Where(i => i.id == updateUserMode.id).FirstOrDefault();
                var qu = context.UsePermition.Where(i => i.id == updateUserMode.id).FirstOrDefault();

                q.username = updateUserMode.username;
                q.password = updateUserMode.password;
                q.status = updateUserMode.status;
                qu.permitionId = updateUserMode.userpermition;
                context.SaveChanges();
                var message = Request.CreateResponse(HttpStatusCode.OK, (int)MessageCode.Savedata);
                return message;
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.OK, ex);
            }

        }

        [HttpPost]
        [Route("~/get/checkUser")]
        public HttpResponseMessage checkUsers([FromBody]UsersManagements user)
        {
            try
            {
                MessageModel value = new MessageModel();
                value = authenticationUser(user);
                ClassMessages e = new ClassMessages((int)value.idMessage);
                if (value.idMessage == (int)MessageCode.OkUser)
                {
                    var qq = context.UsePermition.Where(p => p.UsersManagement.DeviceId == user.DeviceId).FirstOrDefault();
                    e.username = user.username;
                    e.password = user.password;
                    e.status = user.status;
                    e.DeviceId = user.DeviceId;
                    e.userpermition = qq.permitionId;
                    var message = Request.CreateResponse(HttpStatusCode.OK, e);
                    return message;
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, e);
                }

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.OK, ex);
            }

        }

        #endregion

        #region QUESTIONS

        [HttpPost]
        [Route("~/get/QuestionK1/{startParameter}/{countreturn}")]
        public ResultQuestion getQuestionKind1(int startParameter, int countreturn, [FromBody]UsersManagements user)
        {
            MessageModel value = new MessageModel();
            value = authenticationUser(user);
            if (value.idMessage == (int)MessageCode.OkUser)
            {
                var q = (from i in context.Questions
                         where i.active == "t"
                         where i.kind == 1
                         orderby i.id
                         select new Question
                         {
                             id = i.id,
                             question = i.question
                             ,
                             active = i.active,
                             kind = i.kind
                         }).ToList().Skip(startParameter).Take(countreturn);
                return new ResultQuestion(value, q);
            }
            else
            {
                return new ResultQuestion(value, null);
            }
        }

        [HttpPost]
        [Route("~/get/QuestionK2/{startParameter}/{countreturn}")]
        public ResultQuestion getQuestionKind2(int startParameter, int countreturn, [FromBody]UsersManagements user)
        {
            MessageModel value = new MessageModel();
            value = authenticationUser(user);
            if (value.idMessage == (int)MessageCode.OkUser)
            {
                var q = (from i in context.Questions
                     where i.active == "t"
                     where i.kind == 2
                     orderby i.id
                     select new Question
                     {
                         id = i.id,
                         question = i.question
                         ,
                         active = i.active
                     }).ToList().Skip(startParameter).Take(countreturn);
                return new ResultQuestion(value, q);
            }
            else
            {
                return new ResultQuestion(value, null);
            }
        }
        [HttpPost]
        [Route("~/set/question")]
        public HttpResponseMessage setQuestion(GetQuestionModel getQuestionMode)
        {
            try
            {
                MessageModel value = new MessageModel();
                value = authenticationUser(getQuestionMode.authenticationUser);
                if (value.idMessage == (int)MessageCode.OkUser)
                {
                    Questions q = new Questions();
                    q.question = getQuestionMode.question.question;
                    q.active = "t";
                    context.Questions.Add(q);
                    context.SaveChanges();
                    var message = Request.CreateResponse(HttpStatusCode.OK, (int)MessageCode.Savedata);
                    return message;
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, value.idMessage.ToString());
                }

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.OK, ex);
            }

        }

        [HttpPost]
        [Route("~/update/question")]
        public HttpResponseMessage updateQuestion(GetQuestionModel getquestionMode)
        {
            try
            {
                MessageModel value = new MessageModel();
                value = authenticationUser(getquestionMode.authenticationUser);
                if (value.idMessage == (int)MessageCode.OkUser)
                {
                    var q = context.Questions.Where(i => i.id == getquestionMode.question.id).FirstOrDefault();
                    q.question = getquestionMode.question.question;
                    q.active = getquestionMode.question.active;
                    context.SaveChanges();
                    var message = Request.CreateResponse(HttpStatusCode.OK, (int)MessageCode.Savedata);
                    return message;
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, value.idMessage.ToString());
                }

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.OK, ex);
            }

        }

        [HttpPost]
        [Route("~/get/countQuestion")]
        public HttpResponseMessage getCountQuestion(UsersManagements updateUserMode)
        {
            try
            {
                MessageModel value = new MessageModel();
                value = authenticationUser(updateUserMode);
                ClassCount countQuestion = new ClassCount((int)value.idMessage);
                if (value.idMessage == (int)MessageCode.OkUser)
                {
                    int result = (from i in context.Questions where i.active == "t" select i).Count();
                    countQuestion.ToatalCount = result;
                    return Request.CreateResponse(HttpStatusCode.OK, countQuestion);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, countQuestion);
                }

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.OK, ex);
            }

        }


        #endregion

        #region ANSWERS
        [HttpPost]
        [Route("~/get/answerK1/{startParameter}/{countReturn}")]
        public ResultAnswer getAnswerKind1(int startParameter, int countreturn, [FromBody]UsersManagements user)
        {
            MessageModel value = new MessageModel();
            value = authenticationUser(user);
            if (value.idMessage == (int)MessageCode.OkUser)
            {
                var q = (from i in context.Answers
                         where i.active == "t"
                         where i.kind == 1
                         orderby i.id
                         select new Answer
                         {
                             id = i.id,
                             answer = i.answer,
                             active = i.active,
                             kind = i.kind,
                             idQuestion = i.Questions.id
                         }).ToList().Skip(startParameter).Take(countreturn);
                return new ResultAnswer(value, q);
            }
            else
            {
                return new ResultAnswer(value, null);

            }
        }

        [HttpPost]
        [Route("~/set/answerK1")]
        public GetAnswerModel setAnswerKind1(GetAnswerModel getanswerMode)
        {
            try
            {
                MessageModel value = new MessageModel();
                value = authenticationUser(getanswerMode.authenticationUser);
                if (value.idMessage == (int)MessageCode.OkUser)
                {
                    if ((from i in context.Answers where i.answer == getanswerMode.answer.answer select i).FirstOrDefault()!=null)
                    {
                        var messageduplicate = Request.CreateResponse(HttpStatusCode.OK, (int)MessageCode.DuplicateData);
                        return new GetAnswerModel();
                    }
                    Questions q = context.Questions.Where(c => c.id == getanswerMode.answer.idQuestion).FirstOrDefault();
                    Answers a = new Answers();
                    a.Questions = q;
                    a.answer = getanswerMode.answer.answer;
                    a.active = getanswerMode.answer.active;
                    a.kind = 1;
                    context.Answers.Add(a);
                    context.SaveChanges();
                    ///select Answer id
                    int answerId =( from i in context.Answers where i.answer == a.answer select i.id).FirstOrDefault();
                    
                    
                    var message = Request.CreateResponse(HttpStatusCode.OK, (int)MessageCode.Savedata);
                    return new GetAnswerModel();
                }
                else
                {
                    //return Request.CreateResponse(HttpStatusCode.OK, value.idMessage.ToString());
                    return new GetAnswerModel();

                }

            }
            catch (Exception ex)
            {
                //return Request.CreateResponse(HttpStatusCode.OK, ex);
                return new GetAnswerModel();

            }

        }


        [HttpPost]
        [Route("~/update/answerK1")]
        public HttpResponseMessage updateAnswer(GetAnswerModel getanswerMode)
        {
            try
            {
                MessageModel value = new MessageModel();
                value = authenticationUser(getanswerMode.authenticationUser);
                if (value.idMessage == (int)MessageCode.OkUser)
                {
                    var q = context.Answers.Where(i => i.id == getanswerMode.answer.id).FirstOrDefault();
                    q.answer = getanswerMode.answer.answer;
                    q.active = getanswerMode.answer.active;
                    context.SaveChanges();
                    var message = Request.CreateResponse(HttpStatusCode.OK, (int)MessageCode.Savedata);
                    return message;
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, value.idMessage.ToString());
                }

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.OK, ex);
            }

        }

        [HttpPost]
        [Route("~/get/countAnswerK1")]
        public HttpResponseMessage getCountAnswer(UsersManagements updateUserMode)
        {
            try
            {
                MessageModel value = new MessageModel();
                value = authenticationUser(updateUserMode);
                ClassCount countAnswer = new ClassCount((int)value.idMessage);
                if (value.idMessage == (int)MessageCode.OkUser)
                {
                    int q = (from i in context.Answers where i.active == "t" && i.kind == 1 select i).Count();
                    countAnswer.ToatalCount = q;
                    return Request.CreateResponse(HttpStatusCode.OK, countAnswer);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, countAnswer);
                }

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.OK, ex);
            }

        }


        #endregion

        #region TEST
        [HttpGet]
        [Route("~/get/Users")]
        public tests getUserName()
        {
            return new tests("meysam");
        }

        [HttpPost]
        [Route("~/get/test")]
        public resulttest gettest(UsersManagements updateUserMode)
        {
                MessageModel value = new MessageModel();
                value = authenticationUser(updateUserMode);
                ClassCount countAnswer = new ClassCount((int)value.idMessage);
                if (value.idMessage == (int)MessageCode.OkUser)
                {
                    var s = (from i in context.Answers select i).ToList();

                    resulttest r = new resulttest(value,s);
                    return r;
                }
                else
                {
                    resulttest r = new resulttest(value,"");
                return r;
                }
        }
        #endregion








    }

}


//[FromBody]UsersManagement user
//{
//       "id": 1,
//       "username": "meysam",
//       "password": "gjlkjlkjlm-0",
//       "status": 1,
//       "DeviceId": "1",
//       "userpermition": 1
//   }


//[HttpPost]
//[Route("~/set/answer")]

//{
//    "authenticationUser": {
//        "id": 1,
//        "username": "meysam",
//        "password": "gjlkjlkjlm-0",
//        "status": 1,
//        "DeviceId": "1"
//    },
//    "answer": {
//        "id": 2,
//        "idQuestion": 2,
//        "answer": "درايوي كه فايل هاي ديتابيس داخلش هست پرشده بايد كم كردن حجم ديتابيس رو براشون اجرا كنيم\r\n",
//        "active": "t"
//    }
//}


//[HttpPost]
//[Route("~/set/question")]
//    {
//    "authenticationUser": {
//        "id": 1,
//        "username": "meysam",
//        "password": "gjlkjlkjlm-0",
//        "status": 1,
//        "DeviceId": "1"
//    },
//    "Question": {
//        "question": "درايوي كه فايل هاي ديتابيس داخلش هست پرشده بايد كم كردن حجم ديتابيس روبراشون اجرا كنيم\r\n"
//    }
//}


//[HttpPost]
//[Route("~/get/checkUser")]
//{
//       "id": 1,
//       "username": "meysam",
//       "password": "gjlkjlkjlm-0",
//       "status": 1,
//       "DeviceId": "1",
//       "userpermition": 1
//}

//[HttpPost]
//[Route("~/get/createUser")]

//{
//       "id": 2,
//       "username": "mm",
//       "password": "m",
//       "status": 1,
//       "DeviceId": "2",
//       "userpermition": 1
//}

//[HttpPost]
//[Route("~/get/countQuestion")]
//{
//        "id": 1,
//        "username": "meysam",
//        "password": "gjlkjlkjlm-0",
//        "status": 1,
//        "DeviceId": "1"


//[HttpPost]
//[Route("~/get/countAnswer")]
//{
//        "id": 1,
//        "username": "meysam",
//        "password": "gjlkjlkjlm-0",
//        "status": 1,
//        "DeviceId": "1"
//}

