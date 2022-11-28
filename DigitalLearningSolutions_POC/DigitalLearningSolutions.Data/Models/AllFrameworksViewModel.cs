using DigitalLearningSolutions.Data.Helpers;
using DLSPaginationSearchSort.Models.SearchSortFilterPaginate;
using DLSPaginationSearchSort.ViewModels.Common.SearchablePage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigitalLearningSolutions.Data.Models
{
    public class AllFrameworksViewModel : BaseSearchablePageViewModel<BrandedFramework>
    {
        public readonly IEnumerable<BrandedFramework> BrandedFrameworks;

        public AllFrameworksViewModel(
            SearchSortFilterPaginationResult<BrandedFramework> result
        ) : base(result, false)
        {
            BrandedFrameworks = result.ItemsToDisplay;
        }

        public override IEnumerable<(string, string)> SortOptions { get; } = new[]
        {
            FrameworkSortByOptions.FrameworkName,
            FrameworkSortByOptions.FrameworkOwner,
            FrameworkSortByOptions.FrameworkCreatedDate,
            FrameworkSortByOptions.FrameworkPublishStatus,
            FrameworkSortByOptions.FrameworkBrand,
            FrameworkSortByOptions.FrameworkCategory,
            FrameworkSortByOptions.FrameworkTopic,
        };

        public override bool NoDataFound => !BrandedFrameworks.Any() && NoSearchOrFilter;
    }
}
