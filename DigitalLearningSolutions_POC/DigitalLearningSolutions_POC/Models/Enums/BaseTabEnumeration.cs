using DigitalLearningSolutions.Data.Enums;
using System.Collections.Generic;

namespace DigitalLearningSolutions.Models.Enums
{
    public abstract class BaseTabEnumeration : Enumeration
    {
        private protected BaseTabEnumeration(
            int id,
            string name,
            string controller,
            string action,
            string linkText,
            Dictionary<string, string>? staticRouteData = null
        ) : base(id, name)
        {
            Controller = controller;
            Action = action;
            LinkText = linkText;
            StaticRouteData = staticRouteData;
        }

        public string Controller { get; set; }

        public string Action { get; set; }

        public string LinkText { get; set; }

        public Dictionary<string, string>? StaticRouteData { get; set; }

        public abstract IEnumerable<BaseTabEnumeration> GetAllTabs();
    }
}
