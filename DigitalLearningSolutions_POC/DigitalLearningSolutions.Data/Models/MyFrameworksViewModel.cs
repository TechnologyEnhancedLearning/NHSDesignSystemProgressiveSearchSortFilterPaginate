using DigitalLearningSolutions.Data.Helpers;
using DLSPaginationSearchSort.Models.SearchSortFilterPaginate;
using DLSPaginationSearchSort.ViewModels.Common.SearchablePage;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DigitalLearningSolutions.Data.Models
{
    public class MyFrameworksViewModel : BaseSearchablePageViewModel<BrandedFramework>
    {
        public readonly IEnumerable<BrandedFramework> BrandedFrameworks;
        public readonly bool IsFrameworkDeveloper;

        public MyFrameworksViewModel(
            SearchSortFilterPaginationResult<BrandedFramework> result,
            bool isFrameworkDeveloper
        ) : base(result, false)
        {
            BrandedFrameworks = result.ItemsToDisplay;
            IsFrameworkDeveloper = isFrameworkDeveloper;
        }

        public override IEnumerable<(string, string)> SortOptions { get; } = new[]
        {
            FrameworkSortByOptions.FrameworkName,
            FrameworkSortByOptions.FrameworkOwner,
            FrameworkSortByOptions.FrameworkCreatedDate,
            FrameworkSortByOptions.FrameworkPublishStatus
        };

        public override bool NoDataFound => !BrandedFrameworks.Any() && NoSearchOrFilter;
    }
}
