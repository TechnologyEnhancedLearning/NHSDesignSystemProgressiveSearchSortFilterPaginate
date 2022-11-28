using DigitalLearningSolutions.Data.Models;

namespace DigitalLearningSolutions.Data.Helpers
{
    public static class FrameworkSortByOptions
    {
        public static readonly (string DisplayText, string PropertyName) FrameworkName =
            ("Framework Name", nameof(BaseFramework.FrameworkName));

        public static readonly (string DisplayText, string PropertyName) FrameworkOwner =
            ("Owner", nameof(BaseFramework.Owner));

        public static readonly (string DisplayText, string PropertyName) FrameworkCreatedDate =
            ("Created Date", nameof(BaseFramework.CreatedDate));

        public static readonly (string DisplayText, string PropertyName) FrameworkPublishStatus =
            ("Publish Status", nameof(BaseFramework.PublishStatusID));

        public static readonly (string DisplayText, string PropertyName) FrameworkBrand =
            ("Brand", nameof(BrandedFramework.Brand));

        public static readonly (string DisplayText, string PropertyName) FrameworkCategory =
            ("Category", nameof(BrandedFramework.Category));

        public static readonly (string DisplayText, string PropertyName) FrameworkTopic =
            ("Topic", nameof(BrandedFramework.Topic));
    }
}
