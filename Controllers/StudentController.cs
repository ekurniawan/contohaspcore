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
        private List<Student> lstStudent = new List<Student>();
        public StudentController()
        {
             Student student1 = new Student {
                Nim = "112233",
                Nama = "Erick",
                Alamat = "Lempongsari Raya",
                Telp = "08156778894"
            };
            Student student2 =new Student{
                Nim = "112244",
                Nama = "Budi",
                Alamat = "Gowongan Lor",
                Telp = "0815677999"
            };
            Student student3 = new Student{
                Nim = "112255",
                Nama = "Bambang",
                Alamat = "Jl Kaliurang km 6",
                Telp = "08156774433"
            };

            lstStudent.Add(student1);
            lstStudent.Add(student2);
            lstStudent.Add(student3);
        }
        
        public IActionResult Index(){
            /*List<string> lstNama = new List<string>{"erick","budi","bambang"};
            return new JsonResult(lstNama);*/
            return View();
        }

        public IActionResult GetStudents(){
            return View(lstStudent);
        }

        public IActionResult Detail(string id){
            //var model = lstStudent.Where(s=>s.Nim==id).SingleOrDefault();
            Student model = (from s in lstStudent
                        where s.Nim==id
                        select s).SingleOrDefault();

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