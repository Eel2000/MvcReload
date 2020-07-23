using MvcReload.DataAcces;
using MvcReload.Models;
using MvcReload.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcReload.Services
{
    public class CrudServices : ICudServices
    {
        private readonly ApplicationDbContext _context;

        public CrudServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool AddStudent(StudentViewModel student)
        {
            throw new NotImplementedException();
        }

        public bool DeleteStudent(StudentViewModel student)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetStudents()
        {
            throw new NotImplementedException();
        }

        public Student GetStudent(int? id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateStudent(StudentViewModel student)
        {
            throw new NotImplementedException();
        }
    }
}
