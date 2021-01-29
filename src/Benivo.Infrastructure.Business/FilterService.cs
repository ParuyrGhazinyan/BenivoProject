using Benivo.Services.Interfaces;
using BenivoProject.Domain.Core;
using BenivoProject.Domain.Interfaces;
using Microsoft.Extensions.Caching.Memory;
using System.Collections.Generic;
using System.Linq;

namespace Benivo.Infrastructure.Business
{
    public class FilterService : IFilterService
    {
        private readonly IBaseRepository<Category> categoryRepository;
        private readonly IBaseRepository<EmploymentType> employmentRepositori;
        private readonly IBaseRepository<Location> locationRepositori;
        private readonly IMemoryCache memoryCache;

        public FilterService(IBaseRepository<Category> categoryRepository,
                            IBaseRepository<EmploymentType> employmentRepositori,
                            IBaseRepository<Location> locationRepositori,
                            IMemoryCache memoryCache)
        {
            this.categoryRepository = categoryRepository;
            this.employmentRepositori = employmentRepositori;
            this.locationRepositori = locationRepositori;
            this.memoryCache = memoryCache;
        }
        public IEnumerable<Category> GetCategories()
        {
            if (!memoryCache.TryGetValue("Categories", out List<Category> categories))
            {
                categories = categoryRepository.GetAllNoTracking().ToList();
                memoryCache.Set("Categories", categories);
            }
            return categories;
        }

        public IEnumerable<EmploymentType> GetEmploymentTypes()
        {
            if (!memoryCache.TryGetValue("EmploymentTypes", out List<EmploymentType> employmentTypes))
            {
                employmentTypes = employmentRepositori.GetAllNoTracking().ToList();
                memoryCache.Set("EmploymentTypes", employmentTypes);
            }
            return employmentTypes;
        }

        public IEnumerable<Location> GetLocations()
        {
            if (!memoryCache.TryGetValue("Locations", out List<Location> locations))
            {
                locations = locationRepositori.GetAllNoTracking().ToList();
                memoryCache.Set("Locations", locations);
            }
            return locations;
        }
    }
}
