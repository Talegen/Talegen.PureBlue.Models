namespace Talegen.PureBlue.Models.Channels.Twitter
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This class implements a twitter channel exception.
    /// </summary>
    /// <seealso cref="Talegen.PureBlue.Models.ChannelException" />
    public class TwitterChannelException : ChannelException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TwitterChannelException" /> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="ex">The ex.</param>
        /// <param name="errorType">Type of the error.</param>
        /// <param name="errorCode">The error code.</param>
        public TwitterChannelException(string message, Exception ex, string errorType = "", int errorCode = 0)
            : base(message, ex, errorType, errorCode)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TwitterChannelException" /> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="errorType">Type of the error.</param>
        /// <param name="errorCode">The error code.</param>
        public TwitterChannelException(string message, string errorType = "", int errorCode = 0)
            : base(message, errorType, errorCode)
        {
        }
    }
}