using MvcReload.Models;
using MvcReload.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcReload.Services
{
    public interface ICudServices
    {
        

        IEnumerable<Student> GetStudents();

        bool AddStudent(StudentViewModel student);

        Student GetStudent(int? id);

        bool UpdateStudent(StudentViewModel student);

        bool DeleteStudent(StudentViewModel student);
    }
}
