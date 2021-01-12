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
    public class AdminController : Controller
    {
        // GET: AdminController
        public ActionResult Index()
        {
            return View();
        }

        // get student data
        public ActionResult StudentAccount(int id)
        {
            List<StudentModel> student = new List<StudentModel>();
            student.Add(new StudentModel
            {
                StudentID = id,
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

            return View(student);
        }

        //list all students
        public ActionResult AllStudents()
        {
            List<StudentModel> student = new List<StudentModel>();

            for (int i = 0; i < 50; i++)
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

            return View(student);
        }

        // create student
        public ActionResult CreateStudent()
        {
            return View();
        }

        // POST: Post student
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateStudent(IFormCollection collection)
        {
            try
            {
                return RedirectToAction("StudentAccount", "Admin");
            }
            catch
            {
                return View();
            }
        }

        //create Teacher
        public ActionResult CreateTeacher()
        {
            return View();
        }

        // POST: Post student
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateTeacher(IFormCollection collection)
        {
            try
            {
                return RedirectToAction("TeacherAccount", "Admin");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult TeacherAccount(int id)
        {
            List<SubjectModel> subject = new List<SubjectModel>();
            for (int i = 0; i < 4; i++)
            {
                subject.Add(new SubjectModel
                {
                    Id = i,
                    Title = "Math",
                    Grade = $"G-{i}"
                });
            }

            TeacherModel teacher = new TeacherModel {
                Id = id,
                Names = "Edgla Allan Poal",
                DOB = "5/10/1969",
                Qualification = "{FilePath.php}",
                Email = "Edgar@gmail.com",
                PhoneNumber = "+260 524 225",
                SubjectsTeaching = subject.Select(x => new SelectListItem { Text = x.Title, Value = x.Id.ToString() }).ToList()
            };
            

            return View(teacher);
        }

        //list all students
        public ActionResult AllTeacher()
        {
            List<TeacherModel> teacher = new List<TeacherModel>();

            for (int i = 0; i < 50; i++)
            {
                teacher.Add(new TeacherModel
                {
                    Id = i,
                    Names = "Edgla Allan Poal"
                });
            }

            return View(teacher);
        }

        public ActionResult Subject()
        {
            List<TeacherModel> teacher = new List<TeacherModel>();
            for (int i = 0; i < 5; i++)
            {
                teacher.Add(new TeacherModel
                {
                    Id = i,
                    Names = "Edgla Allan Poal"
                });
            }

            List<SubjectModel> subject = new List<SubjectModel>();
            for (int i = 0; i < 5; i++)
            {
                subject.Add(new SubjectModel
                {
                    Id = i,
                    Title = "Math",
                    Grade = $"G-{i}"
                });

            }

            List<GradeModel> grade = new List<GradeModel>();
            for (int i = 0; i < 5; i++)
            {
                grade.Add(new GradeModel
                {
                    Id = i,
                    Title = $"G-{i}" 
                });

            }

            TeacherSubject ts = new TeacherSubject
            {
                Subjects = subject.Select(x => new SelectListItem { Text = x.Title, Value = x.Id.ToString() }).ToList(),
                Teachers = teacher.Select(x => new SelectListItem { Text = x.Names, Value = x.Id.ToString() }).ToList(),
                Grade = grade.Select(x => new SelectListItem { Text = x.Title, Value = x.Id.ToString() }).ToList()
            };


            return View(ts); 
        }

        // POST: Post student
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction("TeacherAccount", "Admin");
            }
            catch
            {
                return View();
            }
        }



        // GET: AdminController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
