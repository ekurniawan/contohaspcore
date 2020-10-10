using System.Collections.Generic;
using contohaspcore.Models;

namespace contohaspcore.Services
{
    public interface IStudentData
    {
        IEnumerable<Student> GetAll();
        Student GetById(string id);
        void Insert(Student student);
        void Edit(string id,Student student);
    }
}