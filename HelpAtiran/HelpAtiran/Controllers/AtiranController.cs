using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HelpModel;
using HelpAtiran.Models;
using ClassModels;

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
            EntityUser = 5

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
                if (query.username == management.username
                && query.password == management.password
                && query.status == management.status)
                {
                    message.idMessage = (int)MessageCode.OkUser;
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
            MessageModel message = new MessageModel();
            var query = (from i in context.UsersManagement where i.username == management.username.Trim() || i.DeviceId == management.DeviceId select i).FirstOrDefault();
            if (query == null)
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

        [HttpPost]
        [Route("~/update/users")]
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
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }

        }


        [HttpPost]
        [Route("~/update/answer")]
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
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, value.idMessage.ToString());
                }

            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
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
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, value.idMessage.ToString());
                }

            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }

        }


        [HttpPost]
        [Route("~/get/createUser")]
        public HttpResponseMessage createUser([FromBody]UsersManagements user)
        {
            try
            {
                MessageModel value = new MessageModel();
                value = authenticationCreateUser(user);
                if (value.idMessage == (int)MessageCode.Savedata)
                {
                    UsersManagement u = new UsersManagement
                    {
                        username = user.username,
                        password = user.password
                       ,
                        status = user.status,
                        DeviceId = user.DeviceId
                    };
                    UsePermition up = new UsePermition { permitionId = user.userpermition, UsersManagement = u };
                    context.UsersManagement.Add(u);
                    context.UsePermition.Add(up);
                    context.SaveChanges();
                    var message = Request.CreateResponse(HttpStatusCode.OK, (int)MessageCode.OkUser);
                    return message;

                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, value.idMessage.ToString());

                }

            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }

        }

        [HttpPost]
        [Route("~/get/checkUser")]
        public HttpResponseMessage getcheckUsers([FromBody]UsersManagements user)
        {
            try
            {
                MessageModel value = new MessageModel();
                value = authenticationUser(user);
                if (value.idMessage == (int)MessageCode.OkUser)
                {
                    var message = Request.CreateResponse(HttpStatusCode.OK, (int)MessageCode.OkUser);
                    return message;
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, value.idMessage.ToString());
                }

            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }

        }


        [HttpPost]
        [Route("~/get/question")]
        public HttpResponseMessage getQuestion([FromBody]UsersManagements user)
        {
            try
            {

                MessageModel value = new MessageModel();
                value = authenticationUser(user);
                if (value.idMessage == (int)MessageCode.OkUser)
                {
                    var query = context.Questions.ToList();

                    var message = Request.CreateResponse(HttpStatusCode.OK, query);
                    return message;
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, value.idMessage.ToString());

                }

            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }

        }

        [HttpPost]
        [Route("~/get/answer")]
        public HttpResponseMessage getAnswer([FromBody]UsersManagements user)
        {
            try
            {

                MessageModel value = new MessageModel();
                value = authenticationUser(user);
                if (value.idMessage == (int)MessageCode.OkUser)
                {
                    var query = context.Answers.ToList();

                    var message = Request.CreateResponse(HttpStatusCode.OK, query);
                    return message;
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, value.idMessage.ToString());

                }

            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }

        }

        [HttpPost]
        [Route("~/set/answer")]
        public HttpResponseMessage setAnswer(GetAnswerModel getanswerMode)
        {
            try
            {
                MessageModel value = new MessageModel();
                value = authenticationUser(getanswerMode.authenticationUser);
                if (value.idMessage == (int)MessageCode.OkUser)
                {
                    Questions q = context.Questions.Where(c => c.id == getanswerMode.answer.idQuestion).FirstOrDefault();
                    Answers a = new Answers();
                    a.Questions = q;
                    a.answer = getanswerMode.answer.answer;
                    context.Answers.Add(a);
                    context.SaveChanges();
                    var message = Request.CreateResponse(HttpStatusCode.OK, (int)MessageCode.Savedata);
                    return message;
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, value.idMessage.ToString());
                }

            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
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
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, value.idMessage.ToString());
                }

            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }

        }

        [HttpPost]
        [Route("~/get/Users")]
        public GetAnswerModel getUserName()
        {
            Answer q1 = (from i in context.Answers
                         where (i.id == 2)
                         select new Answer
                         {
                             id = i.id,
                             idQuestion = i.Questions.id,
                             answer = i.answer,
                             active = i.active
                         }).FirstOrDefault();
            UsersManagements q2 = (from i in context.UsersManagement
                                   where (i.id == 1)
                                   select new UsersManagements
                                   {
                                       id = i.id,
                                       DeviceId = i.DeviceId,
                                       password = i.password,
                                       username = i.username,
                                       status = i.status
                                   }).FirstOrDefault();
            GetAnswerModel g = new GetAnswerModel();
            g.answer = q1;
            g.authenticationUser = q2;
            return g;
        }

        [HttpPost]
        [Route("~/get/Qouestion/{startParameter}/{countreturn}")]
        public IEnumerable<Question> getUserName2(int startParameter,int countreturn, [FromBody]UsersManagements user)
        {
            var q = (from i in context.Questions where i.active =="t" orderby i.id
                     select new Question
                     {
                         id =i.id,question=i.question
                     }).ToList().Skip(startParameter).Take(countreturn);
            return q;
        }

        //[Route("~/get/countQuestion/{startParameter}/{countreturn}")]

        [HttpPost]
        [Route("~/get/countQuestion")]
        public HttpResponseMessage getCountQuestion(UsersManagements updateUserMode)
        {
            try
            {
                MessageModel value = new MessageModel();
                value = authenticationUser(updateUserMode);

                if (value.idMessage == (int)MessageCode.OkUser)
                {
                    var q = (from i in context.Questions select i).Count();
                    var message = Request.CreateResponse(HttpStatusCode.OK, q);
                    return message;
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, value.idMessage.ToString());
                }

            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }

        }

        [HttpPost]
        [Route("~/get/countAnswer")]
        public HttpResponseMessage getCountAnswer(UsersManagements updateUserMode)
        {
            try
            {
                MessageModel value = new MessageModel();
                value = authenticationUser(updateUserMode);

                if (value.idMessage == (int)MessageCode.OkUser)
                {
                    var q = (from i in context.Answers select i).Count();
                    var message = Request.CreateResponse(HttpStatusCode.OK, q);
                    return message;
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, value.idMessage.ToString());
                }

            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }

        }



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