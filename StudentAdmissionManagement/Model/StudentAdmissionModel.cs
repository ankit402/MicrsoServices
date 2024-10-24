using System.Diagnostics.Contracts;

namespace StudentAdmissionManagement.Model
{
    public class StudentAdmissionModel
    {
        // Declaring  the properties of the student Attendance Model
        public int StudentId { get; set; }
        public string?  StudentName { get; set; }
        public string? StudentClass { get; set; }
        public DateTime DateofJoining { get; set; }
    }
}
