﻿using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace RadarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class QualityQuality
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [J("id")] public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [J("name")] public string Name { get; set; }
    }
}
