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
    public class GroupController
    {
       IGroupService _groupService=new GroupService();
       public void AddGroup()
        {
            Console.WriteLine("Name daxil edin:");
            string name=Console.ReadLine();
            Group group = new Group
            {
                Name = name
            };
            _groupService.AddGroup(group);  
        }
        public void DeleteGroup()
        {
            string idStr = "";
            int id;
            do
            {
                Console.WriteLine("ID daxil edin:");
                idStr = Console.ReadLine();
            }while(int.TryParse(idStr, out id));
            _groupService.DeleteGroup(id);
        }
    }
}
