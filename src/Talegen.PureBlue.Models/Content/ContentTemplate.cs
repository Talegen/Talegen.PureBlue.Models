using System;
using System.Collections.Generic;
using System.Text;

namespace Talegen.PureBlue.Models.Content
{
    /// <summary>
    /// This class represents a content template within the application
    /// </summary>
    public class ContentTemplate
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the tenant identifier.
        /// </summary>
        /// <value>The tenant identifier.</value>
        public Guid TenantId { get; set; }

        /// <summary>
        /// Gets or sets the channel types.
        /// </summary>
        /// <value>The channel types.</value>
        public List<ChannelType> ChannelTypes { get; set; } = new List<ChannelType>();

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the template content.
        /// </summary>
        /// <value>The content.</value>
        public string Content { get; set; }
    }
}