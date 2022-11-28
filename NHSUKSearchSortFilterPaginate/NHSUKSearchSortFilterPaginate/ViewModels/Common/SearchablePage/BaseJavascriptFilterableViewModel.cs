using System.Collections.Generic;

namespace NHSUKSearchSortFilterPaginate.ViewModels.Common.SearchablePage
{
    public abstract class BaseJavaScriptFilterableViewModel
    {
        protected BaseJavaScriptFilterableViewModel()
        {
            Filters = new List<AppliedFilterViewModel>();
        }

        public IEnumerable<AppliedFilterViewModel> Filters { get; set; }
    }
}
