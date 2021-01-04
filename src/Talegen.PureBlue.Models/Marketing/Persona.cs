namespace Talegen.PureBlue.Models.Marketing
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This class represents a persona within a tenant and campaign
    /// </summary>
    public class Persona
    {
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
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the properties of the persona.
        /// </summary>
        /// <value>The properties.</value>
        public Dictionary<string, string> Properties { get; set; }

        /// <summary>
        /// Gets or sets the information sources.
        /// </summary>
        /// <value>The information sources.</value>
        public PersonaInfoSource InfoSources { get; set; } = new PersonaInfoSource();
    }
}