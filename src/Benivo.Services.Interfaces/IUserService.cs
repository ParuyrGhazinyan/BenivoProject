using BenivoProject.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Benivo.Services.Interfaces
{
    public interface IUserService
    {
        IQueryable<User> GetUsers(Expression<Func<User, Boolean>> predicate);
        Task InsertUser(User user);
    }
}
