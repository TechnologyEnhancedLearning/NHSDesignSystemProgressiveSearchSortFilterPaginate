
using DigitalLearningSolutions.Data.Models;
using System.Collections.Generic;
using System.Data;
using Dapper;

namespace DigitalLearningSolutions.Data.Services
{
    public interface IFrameworkService
    {
        IEnumerable<BrandedFramework> GetAllFrameworks(int adminId);

        public IEnumerable<BrandedFramework> GetFrameworksForAdminId(int adminId);
    }

    public class FrameworkService : IFrameworkService
    {
        private const string BaseFrameworkFields =
            @"FW.ID,
            FrameworkName,
            OwnerAdminID,
            (SELECT Forename + ' ' + Surname + (CASE WHEN Active = 1 THEN '' ELSE ' (Inactive)' END) AS Expr1 FROM AdminUsers WHERE (AdminID = FW.OwnerAdminID)) AS Owner,
            BrandID,
            CategoryID,
            TopicID,
            CreatedDate,
            PublishStatusID,
            UpdatedByAdminID,
            (SELECT Forename + ' ' + Surname + (CASE WHEN Active = 1 THEN '' ELSE ' (Inactive)' END) AS Expr1 FROM AdminUsers AS AdminUsers_1 WHERE (AdminID = FW.UpdatedByAdminID)) AS UpdatedBy,
            CASE WHEN FW.OwnerAdminID = @adminId THEN 3 WHEN fwc.CanModify = 1 THEN 2 WHEN fwc.CanModify = 0 THEN 1 ELSE 0 END AS UserRole,
            fwr.ID AS FrameworkReviewID";

        private const string BrandedFrameworkFields =
            @",(SELECT BrandName
                                 FROM    Brands
                                 WHERE (BrandID = FW.BrandID)) AS Brand,
                                 (SELECT CategoryName
                                 FROM    CourseCategories
                                 WHERE (CourseCategoryID = FW.CategoryID)) AS Category,
                                 (SELECT CourseTopic
                 FROM    CourseTopics
                                 WHERE (CourseTopicID = FW.TopicID)) AS Topic";

        private const string FrameworkTables =
           @"Frameworks AS FW LEFT OUTER JOIN
             FrameworkCollaborators AS fwc ON fwc.FrameworkID = FW.ID AND fwc.AdminID = @adminId 
            LEFT OUTER JOIN FrameworkReviews AS fwr ON fwc.ID = fwr.FrameworkCollaboratorID AND fwr.Archived IS NULL AND fwr.ReviewComplete IS NULL";

        private readonly IDbConnection connection;

       public FrameworkService(IDbConnection connection)
        {
            this.connection = connection;
        }

        public IEnumerable<BrandedFramework> GetAllFrameworks(int adminId)
        {
            return connection.Query<BrandedFramework>(
                $@"SELECT {BaseFrameworkFields} {BrandedFrameworkFields}
                      FROM {FrameworkTables}",
                new { adminId }
            );
        }

        public IEnumerable<BrandedFramework> GetFrameworksForAdminId(int adminId)
        {
            return connection.Query<BrandedFramework>(
                $@"SELECT {BaseFrameworkFields} {BrandedFrameworkFields}
                      FROM {FrameworkTables}
                      WHERE (OwnerAdminID = @adminId) OR
             (@adminId IN
                 (SELECT AdminID
                 FROM    FrameworkCollaborators
                 WHERE (FrameworkID = FW.ID) AND (IsDeleted=0) ))",
                new { adminId }
            );
        }
    }
}
