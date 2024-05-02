using Bussiness.Services.Abstracts;
using Core.Models;
using Core.RepositoryAbstracts;
using Data.RepositoryConcretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Services.Concretes
{
    public class GroupService : IGroupService
    {
        IGroupRepository _repository = new GroupRepository();
        public void AddGroup(Group group)
        {
            if (!_repository.GetAll(null).Any(x => x.Name == group.Name))
            {
                _repository.Add(group);
                _repository.Commit();
            }
        }

        public void DeleteGroup(int id)
        {
            var group = _repository.Get(x => x.Id == id);
            if (group == null) throw new NullReferenceException();

            _repository.Delete(group);
            _repository.Commit();
        }
    }
}
