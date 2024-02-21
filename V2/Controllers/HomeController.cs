using Microsoft.AspNetCore.Mvc;
using V2.Models;
using V2.ViewModels;

namespace V2.Controllers
{
    public class HomeController : Controller
    {
       
        Group _group = new Group(1,"e11",new List<int>() { 1,2,3});
        Student _student_1 = new Student(1,"Ivan",1);
        Student _student_2 = new Student(2,"Jon",1);
        Student _student_3 = new Student(3,"Piter",1);

        public IActionResult Index()
        {
            IndexViewModel _indexViewModel = new IndexViewModel(
                _group, 
                _student_1
                );
            ViewBag.name = "Ivan";
            ViewData["name"] = "Ivan";
            return View(_indexViewModel); 
        }
        public IActionResult Short()
        {
            ViewBag.name = "Jon";
            ViewData["name"] = "Jon";
            return View();
        }
    }
}
