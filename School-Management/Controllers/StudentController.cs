using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using School_Management.Models;

namespace School_Management.Controllers
{
    public class StudentController : Controller
    {
        //load current assignments 
        public IActionResult Index()
        {
            List<AssignmentModel> assignments = new List<AssignmentModel>();
            for (int i = 0; i < 12; i++)
            {
                assignments.Add(new AssignmentModel
                {
                    Id = i,
                    Title = "Economics Exam",
                    Grade = $"G-{i}",
                    File = "{FilePath}.pdf",
                    Deadline = $"{i}/8/2021",
                    Teacher = "Mr J.K Rolling",
                    Subject = "science"
                });
            }
            return View(assignments);
        }

        public ActionResult Assignment()
        {
            List<AssignmentModel> assignments = new List<AssignmentModel>();
            for (int i = 0; i < 12; i++)
            {
                assignments.Add(new AssignmentModel
                {
                    Id = i,
                    Title = "Economics Exam",
                    Grade = $"G-{i}",
                    File = "{FilePath}.pdf",
                    Deadline = "1/8/2021",
                    Teacher = "Mr J.K Rolling",
                    Subject = "science"
                });
            }
            return View(assignments);
        }

        public ActionResult AssignmentGrade(int Id, int StudentId)
        {
            AssignmentSubmissions submissions = new AssignmentSubmissions();
            submissions.Id = 9;
            submissions.StudentId = 54;
            submissions.StudentName = "Alisa Jackson";
            submissions.UploadDate = "1 / 8 / 2021";
            submissions.Grade =  50;
            submissions.Comments = "Lorem IpsumLorem ipsum, or lipsum as it is sometimes known, is dummy text used" +
            " in laying out print, graphic or web designs. The passage is attributed to an unknown typesetter in " +
            "the 15th century who is thought to have scrambled parts of Cicero's De Finibus Bonorum et Malorum for use in a type specimen book.";

            return View(submissions);
        }

        public ActionResult Attendance()
        {
            //load students
            List<StudentModel> student = new List<StudentModel>();
            for (int i = 0; i < 15; i++)
            {
                student.Add(new StudentModel
                {
                    StudentID = i,
                    FirstName = "Anita Jones",
                    LastName = "Daka",
                    PhoneNumber = "555-1212",
                    Email = "Anitajones2077@hotmail.com",
                    Gender = "Female",
                    Address = "Woodlands chalala #25780",
                    Grade = "12-A",
                    AcademkicYear = "July-November 2021",
                    Password = ""
                });
            }

            //load lecturer subjects
            List<SubjectModel> subject = new List<SubjectModel>();
            for (int i = 0; i < 12; i++)
            {
                subject.Add(new SubjectModel
                {
                    Id = i,
                    Title = "Math",
                    Grade = $"G-{2}"
                });
            }
            List<TeacherModel> teacher = new List<TeacherModel>();

            for (int i = 0; i < 50; i++)
            {
                teacher.Add(new TeacherModel
                {
                    Id = i,
                    Names = "Edgla Allan Poal"
                });
            }


            AttendanceModel attendance = new AttendanceModel
            {
                Id = 5,
                Student = student.Select(a => new SelectListItem
                {
                    Text = a.FirstName,
                    Value = a.StudentID.ToString()
                }),
                Subject = subject.Select(a => new SelectListItem
                {
                    Text = a.Title,
                    Value = a.Id.ToString()
                }),
                Teacher = teacher.Select(a => new SelectListItem
                {
                    Text = a.Names,
                    Value = a.Id.ToString()
                }),
                State = "Present"
            };


            return View(attendance);
        }

    }
}
