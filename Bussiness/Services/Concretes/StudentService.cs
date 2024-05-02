using Bussiness.Services.Abstracts;
using Core.Models;
using Core.RepositoryAbstracts;
using Data.DAL;
using Data.RepositoryConcretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Services.Concretes
{
    public class StudentService : IStudentService
    {
        AppDbContext _appDbContext=new AppDbContext();
        IStudentRepository _studentRepository=new StudentRepository();
        public void AddStudent(Student student)
        {
            _studentRepository.Add(student);
            _studentRepository.Commit();
        }

        public void DeleteStudent(int id)
        {
            var student = _studentRepository.Get(x=>x.Id == id);
            if (student == null) throw new NullReferenceException();

            _studentRepository.Delete(student);
            _studentRepository.Commit();
        }
        public void UpdateStudent(int id, Student student)
        {
            var existStudent = _studentRepository.Get(x => x.Id == id);
            if (existStudent == null) throw new NullReferenceException();

            existStudent.Name = student.Name == "" ? existStudent.Name : student.Name;
            existStudent.Surname = student.Surname;
            existStudent.Age = student.Age;

            _studentRepository.Commit();
        }
    }
}
