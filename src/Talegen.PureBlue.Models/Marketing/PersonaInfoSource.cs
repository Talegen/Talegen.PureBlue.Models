namespace Talegen.PureBlue.Models.Marketing
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Contains a set of person information sources for a given persona
    /// </summary>
    public class PersonaInfoSource
    {
        /// <summary>
        /// Gets or sets the information sources.
        /// </summary>
        /// <value>The information sources.</value>
        public List<string> Conferences { get; set; }

        /// <summary>
        /// Gets or sets the blogs.
        /// </summary>
        /// <value>The blogs.</value>
        public List<string> Blogs { get; set; }

        /// <summary>
        /// Gets or sets the experts.
        /// </summary>
        /// <value>The experts.</value>
        public List<string> Experts { get; set; }

        /// <summary>
        /// Gets or sets the magazines.
        /// </summary>
        /// <value>The magazines.</value>
        public List<string> Magazines { get; set; }

        /// <summary>
        /// Gets or sets the websites.
        /// </summary>
        /// <value>The websites.</value>
        public List<string> Websites { get; set; }
    }
}