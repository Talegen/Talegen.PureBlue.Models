namespace Talegen.PureBlue.Models.Content
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This class represents a content type.
    /// </summary>
    public class ContentType
    {
        /// <summary>
        /// Gets or sets the identifier of the type.
        /// </summary>
        /// <value>The identifier.</value>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the tenant identifier.
        /// </summary>
        /// <value>The tenant identifier.</value>
        public Guid TenantId { get; set; }

        /// <summary>
        /// Gets or sets the title of the type.
        /// </summary>
        /// <value>The title of the type.</value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the color code of the type.
        /// </summary>
        /// <value>The color in hexedecimal web format RRGGBB.</value>
        public string Color { get; set; }
    }
}