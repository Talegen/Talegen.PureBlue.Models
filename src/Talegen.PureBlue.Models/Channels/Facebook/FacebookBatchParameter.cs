namespace Talegen.PureBlue.Models.Channels.Facebook
{
    using System.Net.Http;

    /// <summary>
    /// This class represents a parameter used within a Facebook Batch request.
    /// </summary>
    public class FacebookBatchParameter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FacebookBatchParameter" /> class.
        /// </summary>
        public FacebookBatchParameter()
            : this(string.Empty)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FacebookBatchParameter" /> class.
        /// </summary>
        /// <param name="path">The resource path.</param>
        public FacebookBatchParameter(string path)
            : this(HttpMethod.Get, path)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FacebookBatchParameter" /> class.
        /// </summary>
        /// <param name="httpMethod">The http method.</param>
        /// <param name="path">The resource path.</param>
        public FacebookBatchParameter(HttpMethod httpMethod, string path)
            : this(httpMethod, path, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FacebookBatchParameter" /> class.
        /// </summary>
        /// <param name="path">The resource path.</param>
        /// <param name="parameters">The parameters.</param>
        public FacebookBatchParameter(string path, object parameters)
            : this(HttpMethod.Get, path, parameters)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FacebookBatchParameter" /> class.
        /// </summary>
        /// <param name="httpMethod">The http method.</param>
        /// <param name="path">The resource path.</param>
        /// <param name="parameters">The parameters.</param>
        public FacebookBatchParameter(HttpMethod httpMethod, string path, object parameters)
        {
            this.HttpMethod = httpMethod;
            this.Path = path;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Gets or sets the http method.
        /// </summary>
        public HttpMethod HttpMethod { get; set; }

        /// <summary>
        /// Gets or sets the resource path.
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets the parameters.
        /// </summary>
        public object Parameters { get; set; }

        /// <summary>
        /// Gets or sets the raw data parameter.
        /// </summary>
        public object Data { get; set; }
    }
}