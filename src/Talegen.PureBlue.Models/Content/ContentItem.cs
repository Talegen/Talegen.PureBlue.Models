namespace Talegen.PureBlue.Models.Content
{
    using System;
    using System.Collections.Generic;
    using Talegen.PureBlue.Models.Marketing;

    /// <summary>
    /// This class represents a content item within the tenant
    /// </summary>
    public class ContentItem
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
        /// Gets or sets the URL.
        /// </summary>
        /// <value>The URL.</value>
        public Uri Url { get; set; }

        /// <summary>
        /// Gets or sets the channel.
        /// </summary>
        /// <value>The channel.</value>
        public IChannel Channel { get; set; }

        /// <summary>
        /// Gets or sets a list of related media items.
        /// </summary>
        /// <value>The media items.</value>
        public List<MediaItem> MediaItems { get; set; } = new List<MediaItem>();

        /// <summary>
        /// Gets or sets the tags.
        /// </summary>
        /// <value>The tags.</value>
        public List<ContentTag> Tags { get; set; } = new List<ContentTag>();

        /// <summary>
        /// Gets or sets a list of related personas.
        /// </summary>
        /// <value>The personas.</value>
        public List<Persona> Personas { get; set; } = new List<Persona>();

        /// <summary>
        /// Gets or sets the template.
        /// </summary>
        /// <value>The template.</value>
        public ContentTemplate Template { get; set; }
    }
}