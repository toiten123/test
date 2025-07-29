using Microsoft.AspNetCore.Mvc;

namespace Bai2.Controllers
{
    // Ánh xạ controller vào đường dẫn "Student"
    [Route("Student")]
    public class StudentController : Controller
    {
        // Định nghĩa route cho action "Index" là /Student/Index
        [Route("Index")]
        public string Index()
        {
            return "Index() Action Method of StudentController";
        }

        // Định nghĩa route cho action "Details" với tham số id là /Student/Details/{id}
        [Route("Details/{id}")]
        public string Details(string id)
        {
            return $"Details() Action Method of StudentController and {id}";
        }
    }
}
