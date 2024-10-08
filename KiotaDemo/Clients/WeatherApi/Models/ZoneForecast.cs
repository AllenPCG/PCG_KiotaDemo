// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace KiotaDemo.Clients.WeatherApi.Models
{
    /// <summary>
    /// An object representing a zone area forecast.
    /// </summary>
    public class ZoneForecast : IParsable
    {
        /// <summary>The Context property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Context { get; set; }
#nullable restore
#else
        public UntypedNode Context { get; set; }
#endif
        /// <summary>A geometry represented in Well-Known Text (WKT) format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Geometry { get; set; }
#nullable restore
#else
        public string Geometry { get; set; }
#endif
        /// <summary>An array of forecast periods.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KiotaDemo.Clients.WeatherApi.Models.ZoneForecast_periods>? Periods { get; set; }
#nullable restore
#else
        public List<KiotaDemo.Clients.WeatherApi.Models.ZoneForecast_periods> Periods { get; set; }
#endif
        /// <summary>The time this zone forecast product was published.</summary>
        public DateTimeOffset? Updated { get; set; }
        /// <summary>An API link to the zone this forecast is for.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Zone { get; set; }
#nullable restore
#else
        public string Zone { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="KiotaDemo.Clients.WeatherApi.Models.ZoneForecast"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static KiotaDemo.Clients.WeatherApi.Models.ZoneForecast CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KiotaDemo.Clients.WeatherApi.Models.ZoneForecast();
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
                { "geometry", n => { Geometry = n.GetStringValue(); } },
                { "periods", n => { Periods = n.GetCollectionOfObjectValues<KiotaDemo.Clients.WeatherApi.Models.ZoneForecast_periods>(KiotaDemo.Clients.WeatherApi.Models.ZoneForecast_periods.CreateFromDiscriminatorValue)?.ToList(); } },
                { "updated", n => { Updated = n.GetDateTimeOffsetValue(); } },
                { "zone", n => { Zone = n.GetStringValue(); } },
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
            writer.WriteStringValue("geometry", Geometry);
            writer.WriteCollectionOfObjectValues<KiotaDemo.Clients.WeatherApi.Models.ZoneForecast_periods>("periods", Periods);
            writer.WriteDateTimeOffsetValue("updated", Updated);
            writer.WriteStringValue("zone", Zone);
        }
    }
}
