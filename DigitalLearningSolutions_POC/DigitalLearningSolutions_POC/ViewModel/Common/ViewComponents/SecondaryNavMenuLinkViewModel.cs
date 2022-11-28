using System.Collections.Generic;

namespace DigitalLearningSolutions.ViewModel.Common.ViewComponents
{
    public class SecondaryNavMenuLinkViewModel : LinkViewModel
    {
        public readonly bool IsCurrentPage;

        public SecondaryNavMenuLinkViewModel(
            string aspController,
            string aspAction,
            string linkText,
            bool isCurrentPage,
            Dictionary<string, string>? aspAllRouteData
        ) : base(aspController, aspAction, linkText, aspAllRouteData)
        {
            IsCurrentPage = isCurrentPage;
        }
    }
}
