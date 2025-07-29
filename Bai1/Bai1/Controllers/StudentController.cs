namespace Bai1.Controllers
{
    public class StudentController
    {
        public string Index()
        {
            return "Index() Action Method of StudentController";
        }

        public string Details(string id)
        {
            return $"Details() Action Method of StudentController and " + id;
        }
    }
}
