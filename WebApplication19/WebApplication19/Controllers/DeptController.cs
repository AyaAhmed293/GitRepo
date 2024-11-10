using Microsoft.AspNetCore.Mvc;
using WebApplication19.Models;
using WebApplication19.ViewModel;

namespace WebApplication19.Controllers
{
    public class DeptController : Controller
    {
       
        public ActionResult Details()
        {
            classContext context= new classContext();
            var departments = context.Departments.ToList();
            return View("TestEdit",departments);
        }
        public ActionResult Edit(int id)
        {
            classContext context= new classContext();
            Department dept = context.Departments.FirstOrDefault(x=>x.Id==id);
            ViewBag.stu = context.Students;
            return View("dept",dept);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveEdit(int id, [Bind(include:"Name")] Department dept)
        {
            classContext context = new classContext();
            Department department=context.Departments.FirstOrDefault(x=>x.Id==id);
            if (ModelState.IsValid == true)
            {
                department.Name = dept.Name;

                context.SaveChanges();
                return RedirectToAction("Details");
            }
            else
            {
                return View("Details");
            }

        }
        public IActionResult checkName(string name , string address)
        {
            if (address == "Assuit")
            {
                if(name.Contains("ITI"))
                    return Json(true);
            }
                return Json(false);
        }
    }
}
