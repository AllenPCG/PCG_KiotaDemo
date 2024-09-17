// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace KiotaDemo.Clients.WeatherApi.Models
{
    #pragma warning disable CS1591
    public class Gridpoint_weather_values : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>A time interval in ISO 8601 format. This can be one of:    1. Start and end time    2. Start time and duration    3. Duration and end timeThe string &quot;NOW&quot; can also be used in place of a start/end time.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KiotaDemo.Clients.WeatherApi.Models.ISO8601Interval? ValidTime { get; set; }
#nullable restore
#else
        public KiotaDemo.Clients.WeatherApi.Models.ISO8601Interval ValidTime { get; set; }
#endif
        /// <summary>The value property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KiotaDemo.Clients.WeatherApi.Models.Gridpoint_weather_values_value>? Value { get; set; }
#nullable restore
#else
        public List<KiotaDemo.Clients.WeatherApi.Models.Gridpoint_weather_values_value> Value { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="KiotaDemo.Clients.WeatherApi.Models.Gridpoint_weather_values"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static KiotaDemo.Clients.WeatherApi.Models.Gridpoint_weather_values CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KiotaDemo.Clients.WeatherApi.Models.Gridpoint_weather_values();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "validTime", n => { ValidTime = n.GetObjectValue<KiotaDemo.Clients.WeatherApi.Models.ISO8601Interval>(KiotaDemo.Clients.WeatherApi.Models.ISO8601Interval.CreateFromDiscriminatorValue); } },
                { "value", n => { Value = n.GetCollectionOfObjectValues<KiotaDemo.Clients.WeatherApi.Models.Gridpoint_weather_values_value>(KiotaDemo.Clients.WeatherApi.Models.Gridpoint_weather_values_value.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<KiotaDemo.Clients.WeatherApi.Models.ISO8601Interval>("validTime", ValidTime);
            writer.WriteCollectionOfObjectValues<KiotaDemo.Clients.WeatherApi.Models.Gridpoint_weather_values_value>("value", Value);
        }
    }
}
