namespace Talegen.PureBlue.Models
{
    /// <summary>
    /// This class contains properties related to the channel.
    /// </summary>
    public class ChannelProperties
    {
        /// <summary>
        /// Gets or sets the maximum length of the message.
        /// </summary>
        /// <value>The maximum length of the message.</value>
        public int MaxLength { get; set; }

        /// <summary>
        /// Gets or sets the maximum posts per day.
        /// </summary>
        /// <value>The maximum posts per day.</value>
        public int MaxPerDay { get; set; }
    }
}