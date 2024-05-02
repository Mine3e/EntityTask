using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Services.Abstracts
{
    public interface IStudentService
    {
        void DeleteStudent(int id);
        void AddStudent(Student student);
        void UpdateStudent(int id,Student student);
    }
}
