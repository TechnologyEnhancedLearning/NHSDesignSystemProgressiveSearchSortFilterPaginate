using DigitalLearningSolutions.Data.Helpers;
using DigitalLearningSolutions.Data.Models;
using DigitalLearningSolutions.Data.Services;
using DigitalLearningSolutions.Models;
using DLSPaginationSearchSort.Helpers;
using DLSPaginationSearchSort.Services;
using DLSPaginationSearchSort.Models.SearchSortFilterPaginate;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DigitalLearningSolutions.Models.Enums;
using DigitalLearningSolutions.ViewModel;

namespace DigitalLearningSolutions.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IFrameworkService frameworkService;
        private readonly ISearchSortFilterPaginateService searchSortFilterPaginateService;

        public HomeController(IFrameworkService frameworkService,
 ISearchSortFilterPaginateService searchSortFilterPaginateService, ILogger<HomeController> logger)
        {
            this.searchSortFilterPaginateService = searchSortFilterPaginateService;
            this.frameworkService = frameworkService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [Route("/")]
        [Route("/ViewFrameworks")]
        [Route("/ViewFrameworks/{page=1:int}")]
        public IActionResult ViewFrameworks(string? searchString = null,
          string? sortBy = null,
          string sortDirection = GenericSortingHelper.Ascending,
          int page = 1,
          string tabname = "Mine")
        {
            sortBy ??= FrameworkSortByOptions.FrameworkName.PropertyName;
            var adminId = 1;
            var isFrameworkDeveloper = true;
            var isFrameworkContributor = true;
            IEnumerable<BrandedFramework> frameworks;

            if (tabname == "All") frameworks = frameworkService.GetAllFrameworks(adminId);
            else
            {
                if (!isFrameworkDeveloper && !isFrameworkContributor) return RedirectToAction("ViewFrameworks", "Frameworks", new { tabname = "All" });
                frameworks = frameworkService.GetFrameworksForAdminId(adminId);
            }
            MyFrameworksViewModel myFrameworksViewModel;
            AllFrameworksViewModel allFrameworksViewModel;

            var searchSortPaginateOptions = new SearchSortFilterAndPaginateOptions(
                new SearchOptions(searchString, 60),
                new SortOptions(sortBy, sortDirection),
                null,
                new PaginationOptions(page, 12)
            );

            if (tabname == "All")
            {
                var myFrameworksResult = searchSortFilterPaginateService.SearchFilterSortAndPaginate(
                    new List<BrandedFramework>(),
                    searchSortPaginateOptions
                );
                myFrameworksViewModel = new MyFrameworksViewModel(myFrameworksResult, isFrameworkDeveloper);
                var allFrameworksResult = searchSortFilterPaginateService.SearchFilterSortAndPaginate(
                    frameworks,
                    searchSortPaginateOptions
                );
                allFrameworksViewModel = new AllFrameworksViewModel(allFrameworksResult);
            }
            else
            {
                var myFrameworksResult = searchSortFilterPaginateService.SearchFilterSortAndPaginate(
                    frameworks,
                    searchSortPaginateOptions
                );
                myFrameworksViewModel = new MyFrameworksViewModel(myFrameworksResult, isFrameworkDeveloper);
                var allFrameworksResult = searchSortFilterPaginateService.SearchFilterSortAndPaginate(
                    new List<BrandedFramework>(),
                    searchSortPaginateOptions
                );
                allFrameworksViewModel = new AllFrameworksViewModel(allFrameworksResult);
            }

            var currentTab = FrameworksTab.MyFrameworks;
            var frameworksViewModel = new FrameworksViewModel(
                isFrameworkDeveloper,
                isFrameworkContributor,
                myFrameworksViewModel,
                allFrameworksViewModel,
                currentTab
                );
            return View(frameworksViewModel.MyFrameworksViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
