using System.Collections.Generic;
using System.Linq;
using contohaspcore.Models;
using Microsoft.AspNetCore.Mvc;

namespace contohaspcore.Controllers
{
    //[Route("versi1/[controller]/[action]")]
    //[Route("mahasiswa")]
    public class StudentController : Controller
    {
        public StudentController()
        {
            
        }
    
        public IActionResult Index(){
            /*List<string> lstNama = new List<string>{"erick","budi","bambang"};
            return new JsonResult(lstNama);*/
            return View();
        }

        public IActionResult GetJsonData(){
            return View();
        }

        public IActionResult GetStudents(){
           return View();
        }

        public IActionResult Detail(string id){
            //var model = lstStudent.Where(s=>s.Nim==id).SingleOrDefault();
            
            return View();
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