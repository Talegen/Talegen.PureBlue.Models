namespace Talegen.PureBlue.Models
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text;
    using Talegen.PureBlue.Models.Types;

    /// <summary>
    /// This class represents best practices for a given channel and is used within the channel definition.
    /// </summary>
    public class ChannelBestPractice
    {
        /// <summary>
        /// Gets or sets the minimum message legnth.
        /// </summary>
        /// <value>The message legnth.</value>
        public int MinMessageLegnth { get; set; }

        /// <summary>
        /// Gets or sets the maximum message legnth.
        /// </summary>
        /// <value>The message legnth.</value>
        public int MaxMessageLegnth { get; set; }

        /// <summary>
        /// Gets or sets the maximum posts per day.
        /// </summary>
        /// <value>The maximum posts per day.</value>
        public int MaxPostsPerDay { get; set; }

        /// <summary>
        /// Gets or sets the minimum tags.
        /// </summary>
        /// <value>The minimum tags.</value>
        public int MinTags { get; set; }

        /// <summary>
        /// Gets or sets the maximum tags.
        /// </summary>
        /// <value>The maximum tags.</value>
        public int MaxTags { get; set; }

        /// <summary>
        /// Gets or sets the minimum emoji count.
        /// </summary>
        /// <value>The emoji count.</value>
        public int MinEmojiCount { get; set; }

        /// <summary>
        /// Gets or sets the maximum emoji count.
        /// </summary>
        /// <value>The emoji count.</value>
        public int MaxEmojiCount { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [include link].
        /// </summary>
        /// <value><c>true</c> if [include link]; otherwise, <c>false</c>.</value>
        public bool IncludeLink { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [include media].
        /// </summary>
        /// <value><c>true</c> if [include media]; otherwise, <c>false</c>.</value>
        public bool IncludeMedia { get; set; }

        /// <summary>
        /// Gets or sets the media dimensions.
        /// </summary>
        /// <value>The media dimensions.</value>
        public Dictionary<string, Rectangle> MediaDimensions { get; set; }

        /// <summary>
        /// Gets or sets the post date times.
        /// </summary>
        /// <value>The post date times.</value>
        public List<BestPostDayTime> PostDateTimes { get; set; } = new List<BestPostDayTime>();
    }
}