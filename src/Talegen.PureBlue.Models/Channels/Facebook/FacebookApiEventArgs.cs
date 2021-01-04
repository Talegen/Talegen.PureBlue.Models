namespace Talegen.PureBlue.Models.Channels.Facebook
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// This class implements facebook API event arguments completed event.
    /// </summary>
    /// <seealso cref="System.ComponentModel.AsyncCompletedEventArgs" />
    public class FacebookApiEventArgs : AsyncCompletedEventArgs
    {
        #region Private Fields

        /// <summary>
        /// The result.
        /// </summary>
        private readonly object result;

        #endregion

        #region Public Contructors

        /// <summary>
        /// Initializes a new instance of the <see cref="FacebookApiEventArgs" /> class.
        /// </summary>
        /// <param name="error">The error.</param>
        /// <param name="cancelled">The cancelled.</param>
        /// <param name="userState">The user state.</param>
        /// <param name="result">The result.</param>
        public FacebookApiEventArgs(Exception error, bool cancelled, object userState, object result)
            : base(error, cancelled, userState)
        {
            this.result = result;
        }

        #endregion

        /// <summary>
        /// Get the json result.
        /// </summary>
        /// <returns>The json result.</returns>
        [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
        public object GetResultData()
        {
            this.RaiseExceptionIfNecessary();
            return this.result;
        }

        /// <summary>
        /// Get the json result.
        /// </summary>
        /// <typeparam name="TResult">The result type.</typeparam>
        /// <returns>The json result.</returns>
        public TResult GetResultData<TResult>()
        {
            this.RaiseExceptionIfNecessary();
            return (TResult)this.result;
        }
    }
}