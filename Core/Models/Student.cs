using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; }=null!;
        public int Age { get; set; }

        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}
