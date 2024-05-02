using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Services.Abstracts
{
    public interface IGroupService
    {
        void DeleteGroup(int id);
        void AddGroup(Group group);
    }
}
