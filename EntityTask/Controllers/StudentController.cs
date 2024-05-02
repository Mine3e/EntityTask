using Bussiness.Services.Abstracts;
using Bussiness.Services.Concretes;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTask.Controllers
{
    public class StudentController
    {
        IStudentService _studentService = new StudentService();
        IGroupService _groupService = new GroupService();
        public void AddStudent()
        {
            Console.WriteLine("Name daxil edin:");
            string name=Console.ReadLine();
            Console.WriteLine("Surname daxil edin:");
            string surname=Console.ReadLine();
            string ageStr = "";
            int age;
            do
            {
                Console.WriteLine("Age daxil edin:");
                ageStr = Console.ReadLine();
            }while(int.TryParse(ageStr, out age));
            Student student = new Student
            {
                Name = name,
                Surname = surname,
                Age = age
            };
            _studentService.AddStudent(student);
        }
        public void DeleteStudent()
        {
            string idStr = "";
            int id;
            do
            {
                Console.WriteLine("Id daxil edin:");
                idStr = Console.ReadLine();
            }while(int.TryParse(idStr, out id));
            _studentService.DeleteStudent(id);
        }
        public void UpdateStudent()
        {
            string idStr = "";
            int id;
            do
            {
                Console.WriteLine("ID daxil edin:");
                idStr = Console.ReadLine();
            }while(int.TryParse(idStr,out id));

            Console.WriteLine("Name daxil edin:");
            string name= Console.ReadLine();
            Console.WriteLine("Surname daxil edin:");
            string surname=Console.ReadLine();
            string ageStr = "";
            int age;
            do
            {
                Console.WriteLine("Age daxil edin:");
                ageStr = Console.ReadLine();
            } while (int.TryParse(ageStr, out age));

            string gidStr = "";
            int gid;
            do
            {
                Console.WriteLine("ID daxil edin:");
                gidStr = Console.ReadLine();
            } while (int.TryParse(gidStr, out gid));
            Student student = new Student
            {
                Name = name,
                Age = age,
                Surname = surname,
                GroupId = gid
            };
            _studentService.UpdateStudent(id, student);

        }
    }
}
