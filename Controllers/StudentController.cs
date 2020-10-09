using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace contohaspcore.Controllers
{
    //[Route("versi1/[controller]/[action]")]
    //[Route("mahasiswa")]
    public class StudentController : Controller
    {
        
        public IActionResult Index(){
            List<string> lstNama = new List<string>{"erick","budi","bambang"};
            return new JsonResult(lstNama);
        }

        //[Route("alamat")]
        public IActionResult Address(){
            return Content("Student Address");
        }
    }
}