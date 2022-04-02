using Microsoft.AspNetCore.Mvc;
using PracticeGuru.Data;

namespace PracticeGuru.Controllers
{
    public class TeacherController : Controller
    {
        private ApplicationDbContexts _db;
        public TeacherController(ApplicationDbContexts db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
                IEnumerable<TeacherDb> obj = _db.TeacherInfo.ToList();
                return View(obj);
          
        }
    }
}
