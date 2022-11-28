using System.Collections.Generic;

namespace DigitalLearningSolutions.ViewModel.Common.ViewComponents
{
    public class LinkViewModel
    {
        public readonly string AspAction;

        public readonly string AspController;

        public readonly string LinkText;

        public readonly Dictionary<string, string>? AspAllRouteData;

        public LinkViewModel(string aspController, string aspAction, string linkText, Dictionary<string, string>? aspAllRouteData)
        {
            AspAction = aspAction;
            AspController = aspController;
            LinkText = linkText;
            AspAllRouteData = aspAllRouteData;
        }
    }
}
