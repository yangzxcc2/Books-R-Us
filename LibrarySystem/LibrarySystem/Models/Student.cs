using System;
namespace LibrarySystem.Models
{
    public class Student
    {
        public string StudentId { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public string StudentFaculty { get; set; }

        //public Student(int studentId,string studentFirstName, string studentLastName, string studentFaculty)
        //{
        //    this.studentId = studentId;
        //    this.studentFirstName = studentFirstName;
        //    this.studentLastName = studentLastName;
        //    this.studentFaculty = studentFaculty;
        //}
    }
}
