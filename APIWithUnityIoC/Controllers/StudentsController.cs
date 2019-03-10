using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Services.interfaces;
using Models;
using System.Threading.Tasks;

namespace APIWithUnityIoC.Controllers
{
   [RoutePrefix("api/students")]
    public class StudentsController : ApiController
    {
        readonly IStudents _students;
        public StudentsController(IStudents students)
        {
            this._students = students;
        }
        [HttpGet]
        [Route("greetings")]
        public async Task<HttpResponseMessage> Greetings()
        {
            string mess = await _students.GetStudentList();
            var message = Request.CreateResponse(HttpStatusCode.OK, mess);
            return message;
        }

        [HttpGet]
        [Route("list")]
        public async Task<HttpResponseMessage> studentList()
        {
            List<Students> studlst = await _students.StudentList();
            var message = Request.CreateResponse(HttpStatusCode.OK, studlst);
            return message;
        }
    }
}
