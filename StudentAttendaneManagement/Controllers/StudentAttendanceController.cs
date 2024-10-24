using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAttendaneManagement.Model;

namespace StudentAttendaneManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAttendanceController : ControllerBase
    {
        //GET
        [HttpGet]
        
        public IEnumerable<StudentAttendanceDetailsModel> Get()
        {
            StudentAttendanceDetailsModel attendanceDetailobj1= new StudentAttendanceDetailsModel();
            StudentAttendanceDetailsModel attendanceDetailobj2 = new StudentAttendanceDetailsModel();

            attendanceDetailobj1.StudentId =1;
            attendanceDetailobj1.StudentName = "Ankit";
            attendanceDetailobj1.AttendancePercentage = 100.00;

            attendanceDetailobj2.StudentId = 2;
            attendanceDetailobj2.StudentName = "Rohan";
            attendanceDetailobj2.AttendancePercentage = 50.00;

            List<StudentAttendanceDetailsModel> objlist =new List<StudentAttendanceDetailsModel> { attendanceDetailobj1,attendanceDetailobj2 };
            return objlist;
        }

    }
}
