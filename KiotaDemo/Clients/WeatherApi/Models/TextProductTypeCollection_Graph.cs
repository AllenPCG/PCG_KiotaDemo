// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace KiotaDemo.Clients.WeatherApi.Models
{
    #pragma warning disable CS1591
    public class TextProductTypeCollection_Graph : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The productCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductCode { get; set; }
#nullable restore
#else
        public string ProductCode { get; set; }
#endif
        /// <summary>The productName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductName { get; set; }
#nullable restore
#else
        public string ProductName { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="KiotaDemo.Clients.WeatherApi.Models.TextProductTypeCollection_Graph"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static KiotaDemo.Clients.WeatherApi.Models.TextProductTypeCollection_Graph CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KiotaDemo.Clients.WeatherApi.Models.TextProductTypeCollection_Graph();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "productCode", n => { ProductCode = n.GetStringValue(); } },
                { "productName", n => { ProductName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("productCode", ProductCode);
            writer.WriteStringValue("productName", ProductName);
        }
    }
}
