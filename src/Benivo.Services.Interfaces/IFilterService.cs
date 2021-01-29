using BenivoProject.Domain.Core;
using System.Collections.Generic;

namespace Benivo.Services.Interfaces
{
    public interface IFilterService
    {
        IEnumerable<Category> GetCategories();
        IEnumerable<EmploymentType> GetEmploymentTypes();
        IEnumerable<Location> GetLocations();
    }
}
