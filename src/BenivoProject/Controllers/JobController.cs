using Benivo.Infrastructure.Business;
using Benivo.Services.Interfaces;
using BenivoProject.Domain.Core;
using BenivoProject.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BenivoProject.Controllers
{
    public class JobController : Controller
    {
        private readonly IJobeService jobeService;
        private readonly IUserService userService;
        private readonly IFilterService optionsService;
        public JobController(IJobeService jobeService, IUserService userService, IFilterService optionsService)
        {
            this.jobeService = jobeService;
            this.userService = userService;
            this.optionsService = optionsService;
        }

        public IActionResult Index()
        {
            ViewBag.Categories = optionsService.GetCategories();
            ViewBag.EmploymentType = optionsService.GetEmploymentTypes();
            ViewBag.Locations = optionsService.GetLocations();

            List<JobViewModel> jobs = jobeService.GetJobs().Select(x => new JobViewModel
            {
                Id = x.Id,
                CategoriId = x.CategoriId,
                EmploymentType = x.EmploymentType.Name,
                Image = x.Image,
                Location = x.Location.FullAddress,
                Title = x.Title,
                Bookmarked = x.Bukmarks.Any(x => x.User.UserName == User.Identity.Name)
            }).ToList();
            return View(jobs);
        }

        [HttpPost]
        public IActionResult FilteredIndex([FromBody] List<FilterModel> filters)
        {
            ViewBag.Categories = optionsService.GetCategories();
            ViewBag.EmploymentType = optionsService.GetEmploymentTypes();
            ViewBag.Locations = optionsService.GetLocations();

            Expression<Func<Job, bool>> filter = CreateFilter(filters);
            List<JobViewModel> jobs = jobeService.GetJobs(filter).Select(x => new JobViewModel
            {
                Id = x.Id,
                CategoriId = x.CategoriId,
                EmploymentType = x.EmploymentType.Name,
                Image = x.Image,
                Location = x.Location.FullAddress,
                Title = x.Title,
                Bookmarked = x.Bukmarks.Any(x => x.User.UserName == User.Identity.Name)
            }).ToList();
            return Json(JsonConvert.SerializeObject(jobs, Formatting.None, new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore }));
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            Job job = jobeService.GetJobDetail(id);
            JobViewModel model = new JobViewModel
            {
                Company = job.Company,
                Details = job.Details,
                Category = job.Category.Name,
                EmploymentType = job.EmploymentType.Name,
                Image = job.Image,
                Location = job.Location.FullAddress,
                Title = job.Title,
                Bookmarked = job.Bukmarks.Any(x => x.User.UserName == User.Identity.Name)
            };
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Bookmark(int Id)
        {
            User user = userService.GetUsers(x => x.UserName == User.Identity.Name).FirstOrDefault();
            if (user != null)
            {
                await jobeService.BookmarkJob(user.Id, Id);
            }
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> UnBookmark(int Id)
        {
            User user = userService.GetUsers(x => x.UserName == User.Identity.Name).FirstOrDefault();
            if (user != null)
            {
                await jobeService.UnBookmarkJob(user.Id, Id);
            }
            return Ok();
        }

        [NonAction]
        protected Expression<Func<Job, bool>> CreateFilter(List<FilterModel> filters)
        {
            List<int> categoryIds = filters.Where(x => x.FilterType == "category").Select(x => x.Id).ToList();
            List<int> typeIds = filters.Where(x => x.FilterType == "type").Select(x => x.Id).ToList();
            List<int> locationIds = filters.Where(x => x.FilterType == "location").Select(x => x.Id).ToList();

            Expression<Func<Job, bool>> filter = d => true;
            if (categoryIds.Any())
            {
                filter = filter.And(x => categoryIds.Contains(x.CategoriId));
            }
            if (typeIds.Any())
            {
                filter = filter.And(x => typeIds.Contains(x.EmploymentTypeId));
            }
            if (locationIds.Any())
            {
                filter = filter.And(x => locationIds.Contains(x.LocationId));
            }
            if (filters.Any(x => x.FilterType == "title"))
            {
                string searchText = filters.Where(x => x.FilterType == "title").Select(x => x.Title).FirstOrDefault();
                filter = filter.And(x => x.Title.ToLower().Contains(searchText.ToLower()));
            }
            return filter;
        }
    }
}
