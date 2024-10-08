// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace KiotaDemo.Clients.WeatherApi.Models
{
    #pragma warning disable CS1591
    public class TextProductLocationCollection : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The Context property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Context { get; set; }
#nullable restore
#else
        public UntypedNode Context { get; set; }
#endif
        /// <summary>The locations property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KiotaDemo.Clients.WeatherApi.Models.TextProductLocationCollection_locations? Locations { get; set; }
#nullable restore
#else
        public KiotaDemo.Clients.WeatherApi.Models.TextProductLocationCollection_locations Locations { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="KiotaDemo.Clients.WeatherApi.Models.TextProductLocationCollection"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static KiotaDemo.Clients.WeatherApi.Models.TextProductLocationCollection CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KiotaDemo.Clients.WeatherApi.Models.TextProductLocationCollection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "@context", n => { Context = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "locations", n => { Locations = n.GetObjectValue<KiotaDemo.Clients.WeatherApi.Models.TextProductLocationCollection_locations>(KiotaDemo.Clients.WeatherApi.Models.TextProductLocationCollection_locations.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<UntypedNode>("@context", Context);
            writer.WriteObjectValue<KiotaDemo.Clients.WeatherApi.Models.TextProductLocationCollection_locations>("locations", Locations);
        }
    }
}
