namespace Talegen.PureBlue.Models.Marketing
{
    using System;
    using System.Collections.Generic;
    using Talegen.PureBlue.Models.Content;

    /// <summary>
    /// This class represents a content campaign for the tenant.
    /// </summary>
    public class Campaign
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
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the type of the content.
        /// </summary>
        /// <value>The type of the content.</value>
        public ContentType ContentType { get; set; }

        /// <summary>
        /// Gets or sets the URL for the campaign.
        /// </summary>
        /// <value>The URL.</value>
        public Uri Url { get; set; }

        /// <summary>
        /// Gets or sets the content items.
        /// </summary>
        /// <value>The content items.</value>
        public List<ContentItem> ContentItems { get; set; } = new List<ContentItem>();

        /// <summary>
        /// Gets or sets the media items.
        /// </summary>
        /// <value>The media items.</value>
        public List<MediaItem> MediaItems { get; set; } = new List<MediaItem>();

        /// <summary>
        /// Gets or sets the content tags.
        /// </summary>
        /// <value>The content tags.</value>
        public List<ContentTag> ContentTags { get; set; } = new List<ContentTag>();

        /// <summary>
        /// Gets or sets a list of related personas.
        /// </summary>
        /// <value>The personas.</value>
        public List<Persona> Personas { get; set; } = new List<Persona>();

        /// <summary>
        /// Gets or sets the templates.
        /// </summary>
        /// <value>The templates.</value>
        public List<ContentTemplate> Templates { get; set; } = new List<ContentTemplate>();
    }
}