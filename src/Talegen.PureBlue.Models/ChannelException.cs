namespace Talegen.PureBlue.Models
{
    using System;

    /// <summary>
    /// This class represents a base channel exception.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class ChannelException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelException" /> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="ex">The ex.</param>
        /// <param name="errorType">Type of the error.</param>
        /// <param name="errorCode">The error code.</param>
        public ChannelException(string message, Exception ex, string errorType = "", int errorCode = 0)
            : base(message, ex)
        {
            this.ErrorType = errorType;
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelException" /> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="errorType">Type of the error.</param>
        /// <param name="errorCode">The error code.</param>
        public ChannelException(string message, string errorType = "", int errorCode = 0)
            : base(message)
        {
            this.ErrorType = errorType;
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Gets or sets the type of the error.
        /// </summary>
        /// <value>The type of the error.</value>
        public string ErrorType { get; private set; }

        /// <summary>
        /// Gets or sets the code of the error.
        /// </summary>
        /// <value>The code of the error.</value>
        public int ErrorCode { get; private set; }
    }
}