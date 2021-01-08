using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using School_Management.Models;

namespace School_Management.Controllers
{
    public class TeacherController : Controller
    {
        // get current assignments
        public ActionResult Index()
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
                    Deadline = "1/8/2021"
                });
            }

            return View(assignments);
        }

        //upload assignments
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
                    Deadline = "1/8/2021"
                });
            }

            return View(assignments);
        }

        // POST: Post assignment
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Assignment(IFormCollection collection)
        {
            try
            {
                return RedirectToAction("CreateAssignment", "Teacher");
            }
            catch
            {
                return View();
            }
        }

        //Retrive uploaded assignments
        public ActionResult Submissions(int id)
        {
            List<AssignmentSubmissions> submissions = new List<AssignmentSubmissions>();
            for (int i = 0; i < 12; i++)
            {
                submissions.Add(new AssignmentSubmissions
                {
                    Id = i,
                    StudentId = i++,
                    StudentName = "Alisa Jackson",
                    UploadDate = "1 / 8 / 2021",
                    Grade = i + 50,
                    Comments = "Lorem Ipsum"
                });
            }

            return View(submissions);
        }

        public ActionResult Attendance()
        {
            //load students
            List<StudentModel> student = new List<StudentModel>();
            student.Add(new StudentModel
            {
                StudentID = 5,
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

            //load lecturer subjects
            List<SubjectModel> subject = new List<SubjectModel>();
            subject.Add(new SubjectModel
            {
                Id = 5,
                Title = "Math",
                Grade = $"G-{2}"
            });

            //load grade
            List<GradeModel> grade = new List<GradeModel>();
            grade.Add(new GradeModel
            {
                Id = 5,
                Title = "Math"
            });


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
                Grades = grade.Select(a => new SelectListItem
                {
                    Text = a.Title,
                    Value = a.Id.ToString()
                })

            };

            return View(attendance);
        }


    }
}
