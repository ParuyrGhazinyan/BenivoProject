using BenivoProject.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Benivo.Services.Interfaces
{
    public interface IJobeService
    {
        List<Job> GetJobs(Expression<Func<Job, bool>> predicate=null);
        Job GetJobDetail(int id);
        Task BookmarkJob(int userId, int jobId);
        Task UnBookmarkJob(int userId, int jobId);
    }
}
