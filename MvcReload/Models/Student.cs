using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcReload.Models
{
    public enum Grade
    {
        preparatory,
        Licence1,
        Licence2,
        Licence3,
        Master1,
        Master2,
    }

    public class Student
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public Grade? Grade { get; set; }
    }
}
