namespace NHSUKSearchSortFilterPaginate.Extensions
{
    using Microsoft.Extensions.Configuration;

    public static class ConfigurationExtensions
    {
        private const string JavascriptSearchSortFilterPaginateItemLimitKey =
            "JavascriptSearchSortFilterPaginateItemLimit";

        public static int GetJavascriptSearchSortFilterPaginateItemLimit(this IConfiguration config)
        {
            return int.Parse(config[JavascriptSearchSortFilterPaginateItemLimitKey]);
        }
    }
}
