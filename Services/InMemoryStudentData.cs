using System.Collections.Generic;
using System.Linq;
using contohaspcore.Models;

namespace contohaspcore.Services {
    public class InMemoryStudentData : IStudentData {
        private List<Student> _student;
        public InMemoryStudentData()
        {
            _student = new List<Student> {
                new Student {
                Nim = "112233",
                Nama = "Erick",
                Alamat = "Lempongsari Raya",
                Telp = "08156778894"
                },
                new Student {
                Nim = "112244",
                Nama = "Budi",
                Alamat = "Gowongan Lor",
                Telp = "0815677999"
                },
                new Student {
                Nim = "112255",
                Nama = "Bambang",
                Alamat = "Jl Kaliurang km 6",
                Telp = "08156774433"
                }
            };

        }
        public IEnumerable<Student> GetAll () {
            return _student.OrderBy(s=>s.Nama);
        }
    }
}