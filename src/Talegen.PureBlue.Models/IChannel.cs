namespace Talegen.PureBlue.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Contains an enumerated list of available channel types.
    /// </summary>
    public enum ChannelType
    {
        /// <summary>
        /// A Facebook group channel
        /// </summary>
        FacebookGroup,

        /// <summary>
        /// A Facebook page channel
        /// </summary>
        FacebookPage,

        /// <summary>
        /// An instagram channel
        /// </summary>
        Instagram,

        /// <summary>
        /// Line Channel
        /// </summary>
        Line,

        /// <summary>
        /// LinkedIn Channel
        /// </summary>
        LinkedIn,

        /// <summary>
        /// Pinterest Channel
        /// </summary>
        Pinterest,

        /// <summary>
        /// Tumblr Channel
        /// </summary>
        Tumblr,

        /// <summary>
        /// Twitter Channel
        /// </summary>
        Twitter,

        /// <summary>
        /// Reddit Channel
        /// </summary>
        Reddit,

        /// <summary>
        /// Snapchat Channel
        /// </summary>
        Snapchat,

        /// <summary>
        /// YouTube Channel
        /// </summary>
        YouTube
    }

    /// <summary>
    /// This class represents a minimal implementation of a channel.
    /// </summary>
    public interface IChannel : IDisposable
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the tenant identifier.
        /// </summary>
        /// <value>The tenant identifier.</value>
        Guid TenantId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        string Description { get; set; }

        /// <summary>
        /// Gets or sets the channel type.
        /// </summary>
        /// <value>The channel type.</value>
        ChannelType Type { get; set; }

        /// <summary>
        /// Gets or sets the properties.
        /// </summary>
        /// <value>The properties.</value>
        ChannelProperties Properties { get; set; }

        /// <summary>
        /// Gets or sets the best practice.
        /// </summary>
        /// <value>The best practice.</value>
        ChannelBestPractice BestPractice { get; set; }
    }
}