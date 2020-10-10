using System.Collections.Generic;
using System.Linq;
using contohaspcore.Models;
using contohaspcore.Services;
using Microsoft.AspNetCore.Mvc;

namespace contohaspcore.Controllers
{
    //[Route("versi1/[controller]/[action]")]
    //[Route("mahasiswa")]
    public class StudentController : Controller
    {
        private IStudentData _student;
        public StudentController(IStudentData student)
        {
            _student = student;
        }
    
        public IActionResult Index(){
            return View();
        }

        public IActionResult GetJsonData(){
            return new JsonResult(_student.GetAll());
        }

        public IActionResult GetStudents(){
            var models = _student.GetAll();
           return View(models);
        }

        public IActionResult Detail(string id){
            var model = _student.GetById(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Registration(string nim,string nama,double nilai){
            ViewData["Nim"] = nim;
            ViewData["Nama"] = nama;
            ViewData["Nilai"] = nilai;
            return View(); 
        }

        public IActionResult GetDetail(string id,string nama){
            return Content($"ID : {id} {nama}");
        }

        //[Route("alamat")]
        public IActionResult Address(string address,string city){
            return Content($"Address: {address} {city}");
        }
    }
}