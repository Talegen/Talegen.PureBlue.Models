namespace Talegen.PureBlue.Models.Channels.Facebook
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This class implements a channel exception for Facebook Page Channel Errors.
    /// </summary>
    public class FacebookPageChannelException : ChannelException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FacebookPageChannelException" /> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="ex">The ex.</param>
        /// <param name="errorType">Type of the error.</param>
        /// <param name="errorCode">The error code.</param>
        public FacebookPageChannelException(string message, Exception ex, string errorType = "", int errorCode = 0)
            : base(message, ex, errorType, errorCode)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FacebookPageChannelException" /> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="errorType">Type of the error.</param>
        /// <param name="errorCode">The error code.</param>
        public FacebookPageChannelException(string message, string errorType = "", int errorCode = 0)
            : base(message, errorType, errorCode)
        {
        }

        /// <summary>
        /// Gets or sets the error subcode.
        /// </summary>
        /// <value>The code of the error subcode.</value>
        public int ErrorSubcode { get; set; }

        /// <summary>
        /// Gets or sets the error user title.
        /// </summary>
        public string ErrorUserTitle { get; set; }

        /// <summary>
        /// Gets or sets the error user message.
        /// </summary>
        public string ErrorUserMessage { get; set; }
    }
}