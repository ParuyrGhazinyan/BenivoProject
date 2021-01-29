using Benivo.Services.Interfaces;
using BenivoProject.Domain.Core;
using BenivoProject.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Benivo.Infrastructure.Business
{
    public class JobService : IJobeService
    {
        private readonly IBaseRepository<Job> jobRepository;
        private readonly IBaseRepository<Bookmark> bookmarkRepository;
        public JobService(IBaseRepository<Job> jobRepository, IBaseRepository<Bookmark> bookmarkRepository)
        {
            this.jobRepository = jobRepository;
            this.bookmarkRepository = bookmarkRepository;
        }

        public async Task BookmarkJob(int userId, int jobId)
        {
            Bookmark bookmark = new Bookmark
            {
                UserId = userId,
                Jobid = jobId
            };
            await bookmarkRepository.Insert(bookmark);
        }
        public async Task UnBookmarkJob(int userId, int jobId)
        {
            Bookmark bookmark = bookmarkRepository.GetNoTracking(x => x.UserId == userId && x.Jobid == jobId).FirstOrDefault();
            await bookmarkRepository.Delete(bookmark);
        }

        public List<Job> GetJobs(Expression<Func<Job, bool>> predicate = null)
        {
            return jobRepository.GetNoTracking(predicate, "Location", "Category", "EmploymentType", "Bukmarks.User").ToList();
        }

        public Job GetJobDetail(int id)
        {
            return jobRepository.GetNoTracking(x=>x.Id==id, "Location", "Category", "EmploymentType", "Bukmarks.User").FirstOrDefault();
        }
    }
}
