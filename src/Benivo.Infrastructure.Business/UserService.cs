using Benivo.Services.Interfaces;
using BenivoProject.Domain.Core;
using BenivoProject.Domain.Interfaces;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Benivo.Infostructue.Business
{
    public class UserService : IUserService
    {
        private readonly IBaseRepository<User> userRepository;
        private readonly IBaseRepository<Role> roleRepository;

        public UserService(IBaseRepository<User> userRepository, IBaseRepository<Role> roleRepository)
        {
            this.userRepository = userRepository;
            this.roleRepository = roleRepository;
        }

        public IQueryable<User> GetUsers(Expression<Func<User, Boolean>> predicate)
        {
            return userRepository.GetNoTracking(predicate,"Role");
        }

        public async Task InsertUser(User user)
        {
            Role role=roleRepository.GetAll().Where(x => x.Name == "User").FirstOrDefault();
            user.RoleId = role.Id;
            user.CreationDate = DateTime.Now;
            await userRepository.Insert(user);
            user.Role = role;
        }
    }
}
