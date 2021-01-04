namespace Talegen.PureBlue.Models.Channels.Facebook
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Talegen.PureBlue.Models.Types;

    /// <summary>
    /// This class implements the channel interface class to support a Twitter channel.
    /// </summary>
    /// <seealso cref="Talegen.PureBlue.Models.IChannel" />
    public class TwitterChannel : IChannel
    {
        #region Private Fields

        /// <summary>
        /// The disposed value
        /// </summary>
        private bool disposedValue;

        #endregion

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TwitterChannel" /> class.
        /// </summary>
        public TwitterChannel()
            : this(Guid.Empty)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TwitterChannel" /> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="description">The description.</param>
        public TwitterChannel(Guid id, string name = "", string description = "")
        {
            this.Id = id;
            this.Type = ChannelType.Twitter;
            this.Name = name;
            this.Description = description;
            this.Properties = new ChannelProperties
            {
                MaxLength = 280,
                MaxPerDay = 1000
            };

            this.BestPractice = new ChannelBestPractice
            {
                MinEmojiCount = 1,
                MaxEmojiCount = 1,
                MinTags = 3,
                MaxTags = 3,
                IncludeLink = false,
                IncludeMedia = true,
                MinMessageLegnth = 70,
                MaxMessageLegnth = 100,
                MaxPostsPerDay = 20,
                MediaDimensions = new Dictionary<string, System.Drawing.Rectangle>()
                {
                    {"Image_16:9", new System.Drawing.Rectangle { Width = 1200, Height = 675 }},
                    {"Image_SharedLink", new System.Drawing.Rectangle { Width = 1200, Height = 628 }}
                },
                PostDateTimes = new List<BestPostDayTime>
                {
                    new BestPostDayTime
                    {
                        DayOfWeek = BestPostDayTime.AllDays,
                        TimeRanges = new List<DateTimeRange> { new DateTimeRange { Start = DateTime.Parse("8:00 AM"), End = DateTime.Parse("11:00 PM") } }
                    }
                }
            };
        }

        #endregion

        #region Public Properties

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
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the channel type.
        /// </summary>
        /// <value>The channel type.</value>
        public ChannelType Type { get; set; }

        /// <summary>
        /// Gets or sets the properties.
        /// </summary>
        /// <value>The properties.</value>
        public ChannelProperties Properties { get; set; }

        /// <summary>
        /// Gets or sets the best practice.
        /// </summary>
        /// <value>The best practice.</value>
        public ChannelBestPractice BestPractice { get; set; }

        #endregion

        #region Protected Dispose Method

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                this.disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources ~FacebookPageChannel() { // Do not change this
        // code. Put cleanup code in 'Dispose(bool disposing)' method Dispose(disposing: false); }

        #endregion

        #region Public Dispose Method

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            this.Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}