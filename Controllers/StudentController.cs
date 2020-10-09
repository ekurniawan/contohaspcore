using Microsoft.AspNetCore.Mvc;

namespace contohaspcore.Controllers
{
    //[Route("versi1/[controller]/[action]")]
    //[Route("mahasiswa")]
    public class StudentController : Controller
    {
        
        public IActionResult Index(){
            return Content("From Student Controller");
        }

        //[Route("alamat")]
        public IActionResult Address(){
            return Content("Student Address");
        }
    }
}