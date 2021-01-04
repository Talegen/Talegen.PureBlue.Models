namespace Talegen.PureBlue.Models.Content
{
    /// <summary>
    /// This class represents a hash tag associated with a specific channel and used with tags specific to a channel.
    /// </summary>
    /// <seealso cref="Talegen.PureBlue.Models.Content.Tag" />
    public class ContentTag : Tag
    {
        /// <summary>
        /// Gets or sets the type of the channel.
        /// </summary>
        /// <value>The type of the channel.</value>
        public ChannelType ChannelType { get; set; }
    }
}