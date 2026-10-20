using Microsoft.AspNetCore.Mvc;

namespace Bai2.Controllers
{
    public class HelloController : Controller
    {
        public String Greeting()
        {
            return "Welcome to dead zone :)))";
        }
        public String Welcome(int id1, string name)
        {
            return $"Hi, chao bannn {id1} - {name}";
        }
        //IactionResult
        public IActionResult Welcome1(int id1, string name)
        {
           // ViewData["Message"] = $"Xin chao {id1} - {name}, chuc ban hoc tot";

            ViewBag.Id1 = id1;
            ViewData["Name"] = name;
            return View();
        }
    }
}
// note, khi run dujw ans ta se thay localhost:port/Hello/Index se tra ve "Hy guyyyyy"