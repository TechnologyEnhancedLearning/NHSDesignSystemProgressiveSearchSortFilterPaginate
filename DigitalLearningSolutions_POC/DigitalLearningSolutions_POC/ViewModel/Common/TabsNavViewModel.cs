using DigitalLearningSolutions.Models.Enums;
using DigitalLearningSolutions.ViewModel.Common.ViewComponents;
using System.Collections.Generic;
using System.Linq;

namespace DigitalLearningSolutions.ViewModel.Common
{
    public class TabsNavViewModel
    {
        public TabsNavViewModel(BaseTabEnumeration currentTab, Dictionary<string, string>? routeData = null)
        {
            var allTabs = currentTab.GetAllTabs();

            TabLinks = allTabs.Select(
                t => new SecondaryNavMenuLinkViewModel(
                    t.Controller,
                    t.Action,
                    t.LinkText,
                    t.Equals(currentTab),
                    GenerateTabRouteData(t.StaticRouteData, routeData)
                )
            );
        }

        public IEnumerable<SecondaryNavMenuLinkViewModel> TabLinks { get; set; }

        private Dictionary<string, string>? GenerateTabRouteData(
            Dictionary<string, string>? staticRouteData,
            Dictionary<string, string>? dynamicRouteData
        )
        {
            if (staticRouteData == null)
            {
                return dynamicRouteData;
            }

            if (dynamicRouteData == null)
            {
                return staticRouteData;
            }

            return staticRouteData.Concat(dynamicRouteData).ToDictionary(x => x.Key, x => x.Value);
        }
    }
}
