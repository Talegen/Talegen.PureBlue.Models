namespace Talegen.PureBlue.Models.Marketing
{
    using System;
    using System.Collections.Generic;
    using Talegen.PureBlue.Models.Content;
    using Talegen.PureBlue.Models.Properties;

    /// <summary>
    /// This class contains helper functions for creating default lists.
    /// </summary>
    public static class Defaults
    {
        /// <summary>
        /// The color red
        /// </summary>
        public static string ColorRed = "FF0000";

        /// <summary>
        /// The color green
        /// </summary>
        public static string ColorGreen = "00FF00";

        /// <summary>
        /// The color blue
        /// </summary>
        public static string ColorBlue = "0000FF";

        /// <summary>
        /// The color purple
        /// </summary>
        public static string ColorPurple = "7F00FF";

        /// <summary>
        /// Contents the categories.
        /// </summary>
        /// <param name="tenantId">The tenant identifier.</param>
        /// <returns>Returns a list of <see cref="ContentCategory" /> objects.</returns>
        public static List<ContentCategory> ContentCategories(Guid tenantId)
        {
            return new List<ContentCategory>
            {
                new ContentCategory
                {
                    Id = Guid.NewGuid(),
                    TenantId = tenantId,
                    Title = Resources.BusinessText
                },
                new ContentCategory
                {
                    Id = Guid.NewGuid(),
                    TenantId = tenantId,
                    Title = Resources.FoodText
                },
                new ContentCategory
                {
                    Id = Guid.NewGuid(),
                    TenantId = tenantId,
                    Title = Resources.InspirationText
                },
                new ContentCategory
                {
                    Id = Guid.NewGuid(),
                    TenantId = tenantId,
                    Title = Resources.ProductsText
                }
            };
        }

        /// <summary>
        /// Contents the types.
        /// </summary>
        /// <param name="tenantId">The tenant identifier.</param>
        /// <returns>Returns a list of <see cref="ContentType" /> objects.</returns>
        public static List<ContentType> ContentTypes(Guid tenantId)
        {
            return new List<ContentType>
            {
                new ContentType
                {
                    Id = Guid.NewGuid(),
                    TenantId = tenantId,
                    Title = Resources.OriginalText,
                    Color = ColorRed
                },
                new ContentType
                {
                    Id = Guid.NewGuid(),
                    TenantId = tenantId,
                    Title = Resources.CuratedText,
                    Color = ColorBlue
                },
                new ContentType
                {
                    Id = Guid.NewGuid(),
                    TenantId = tenantId,
                    Title = Resources.PromotionalText,
                    Color = ColorGreen
                },
                new ContentType
                {
                    Id = Guid.NewGuid(),
                    TenantId = tenantId,
                    Title = Resources.EngagementText,
                    Color = ColorPurple
                }
            };
        }
    }
}