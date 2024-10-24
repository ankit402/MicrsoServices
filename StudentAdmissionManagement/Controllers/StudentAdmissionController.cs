using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAdmissionManagement.Model;
using System.Globalization;

namespace StudentAdmissionManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAdmissionController : ControllerBase
    {
        //GET
        public IEnumerable<StudentAdmissionModel> Get()
        {
            StudentAdmissionModel studentadmissionemodel1 = new StudentAdmissionModel();
            StudentAdmissionModel studentadmissionemodel2 = new StudentAdmissionModel();

            studentadmissionemodel1.StudentId = 1;
            studentadmissionemodel1.StudentName = "Ankit";
            studentadmissionemodel1.StudentClass = "B.tech";
            studentadmissionemodel1.DateofJoining = DateTime.Now;

            studentadmissionemodel2.StudentId = 2;
            studentadmissionemodel2.StudentName = "Rohan";
            studentadmissionemodel2.StudentClass = "B.Ed";
            studentadmissionemodel2.DateofJoining = DateTime.Now;

            List<StudentAdmissionModel> studentAttendanceModelslist = new List<StudentAdmissionModel> { studentadmissionemodel1, studentadmissionemodel2 };

            return studentAttendanceModelslist;
        }
    }
}
