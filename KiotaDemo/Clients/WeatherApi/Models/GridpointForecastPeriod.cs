// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace KiotaDemo.Clients.WeatherApi.Models
{
    /// <summary>
    /// An object containing forecast information for a specific time period (generally 12-hour or 1-hour).
    /// </summary>
    public class GridpointForecastPeriod : IParsable
    {
        /// <summary>A detailed textual forecast for the period.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DetailedForecast { get; set; }
#nullable restore
#else
        public string DetailedForecast { get; set; }
#endif
        /// <summary>A structured value representing a measurement and its unit of measure. This object is a slighly modified version of the schema.org definition at https://schema.org/QuantitativeValue</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KiotaDemo.Clients.WeatherApi.Models.QuantitativeValue? Dewpoint { get; set; }
#nullable restore
#else
        public KiotaDemo.Clients.WeatherApi.Models.QuantitativeValue Dewpoint { get; set; }
#endif
        /// <summary>The ending time that this forecast period is valid for.</summary>
        public DateTimeOffset? EndTime { get; set; }
        /// <summary>A link to an icon representing the forecast summary.</summary>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Icon { get; set; }
#nullable restore
#else
        public string Icon { get; set; }
#endif
        /// <summary>Indicates whether this period is daytime or nighttime.</summary>
        public bool? IsDaytime { get; set; }
        /// <summary>A textual identifier for the period. This value will not be present for hourly forecasts.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Sequential period number.</summary>
        public int? Number { get; set; }
        /// <summary>A structured value representing a measurement and its unit of measure. This object is a slighly modified version of the schema.org definition at https://schema.org/QuantitativeValue</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KiotaDemo.Clients.WeatherApi.Models.QuantitativeValue? ProbabilityOfPrecipitation { get; set; }
#nullable restore
#else
        public KiotaDemo.Clients.WeatherApi.Models.QuantitativeValue ProbabilityOfPrecipitation { get; set; }
#endif
        /// <summary>A structured value representing a measurement and its unit of measure. This object is a slighly modified version of the schema.org definition at https://schema.org/QuantitativeValue</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KiotaDemo.Clients.WeatherApi.Models.QuantitativeValue? RelativeHumidity { get; set; }
#nullable restore
#else
        public KiotaDemo.Clients.WeatherApi.Models.QuantitativeValue RelativeHumidity { get; set; }
#endif
        /// <summary>A brief textual forecast summary for the period.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ShortForecast { get; set; }
#nullable restore
#else
        public string ShortForecast { get; set; }
#endif
        /// <summary>The starting time that this forecast period is valid for.</summary>
        public DateTimeOffset? StartTime { get; set; }
        /// <summary>High/low temperature for the period, depending on whether the period is day or night.This property as an integer value is deprecated. Future versions will express this value as a quantitative value object. To make use of the future standard format now, set the &quot;forecast_temperature_qv&quot; feature flag on the request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KiotaDemo.Clients.WeatherApi.Models.GridpointForecastPeriod.GridpointForecastPeriod_temperature? Temperature { get; set; }
#nullable restore
#else
        public KiotaDemo.Clients.WeatherApi.Models.GridpointForecastPeriod.GridpointForecastPeriod_temperature Temperature { get; set; }
#endif
        /// <summary>If not null, indicates a non-diurnal temperature trend for the period (either rising temperature overnight, or falling temperature during the day)</summary>
        public KiotaDemo.Clients.WeatherApi.Models.GridpointForecastPeriod_temperatureTrend? TemperatureTrend { get; set; }
        /// <summary>The unit of the temperature value (Fahrenheit or Celsius).This property is deprecated. Future versions will indicate the unit within the quantitative value object for the temperature property. To make use of the future standard format now, set the &quot;forecast_temperature_qv&quot; feature flag on the request.</summary>
        [Obsolete("")]
        public KiotaDemo.Clients.WeatherApi.Models.GridpointForecastPeriod_temperatureUnit? TemperatureUnit { get; set; }
        /// <summary>The prevailing direction of the wind for the period, using a 16-point compass.</summary>
        public KiotaDemo.Clients.WeatherApi.Models.GridpointForecastPeriod_windDirection? WindDirection { get; set; }
        /// <summary>Peak wind gust for the period.This property as an string value is deprecated. Future versions will express this value as a quantitative value object. To make use of the future standard format now, set the &quot;forecast_wind_speed_qv&quot; feature flag on the request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KiotaDemo.Clients.WeatherApi.Models.GridpointForecastPeriod.GridpointForecastPeriod_windGust? WindGust { get; set; }
#nullable restore
#else
        public KiotaDemo.Clients.WeatherApi.Models.GridpointForecastPeriod.GridpointForecastPeriod_windGust WindGust { get; set; }
#endif
        /// <summary>Wind speed for the period.This property as an string value is deprecated. Future versions will express this value as a quantitative value object. To make use of the future standard format now, set the &quot;forecast_wind_speed_qv&quot; feature flag on the request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KiotaDemo.Clients.WeatherApi.Models.GridpointForecastPeriod.GridpointForecastPeriod_windSpeed? WindSpeed { get; set; }
#nullable restore
#else
        public KiotaDemo.Clients.WeatherApi.Models.GridpointForecastPeriod.GridpointForecastPeriod_windSpeed WindSpeed { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="KiotaDemo.Clients.WeatherApi.Models.GridpointForecastPeriod"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static KiotaDemo.Clients.WeatherApi.Models.GridpointForecastPeriod CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KiotaDemo.Clients.WeatherApi.Models.GridpointForecastPeriod();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "detailedForecast", n => { DetailedForecast = n.GetStringValue(); } },
                { "dewpoint", n => { Dewpoint = n.GetObjectValue<KiotaDemo.Clients.WeatherApi.Models.QuantitativeValue>(KiotaDemo.Clients.WeatherApi.Models.QuantitativeValue.CreateFromDiscriminatorValue); } },
                { "endTime", n => { EndTime = n.GetDateTimeOffsetValue(); } },
                { "icon", n => { Icon = n.GetStringValue(); } },
                { "isDaytime", n => { IsDaytime = n.GetBoolValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "number", n => { Number = n.GetIntValue(); } },
                { "probabilityOfPrecipitation", n => { ProbabilityOfPrecipitation = n.GetObjectValue<KiotaDemo.Clients.WeatherApi.Models.QuantitativeValue>(KiotaDemo.Clients.WeatherApi.Models.QuantitativeValue.CreateFromDiscriminatorValue); } },
                { "relativeHumidity", n => { RelativeHumidity = n.GetObjectValue<KiotaDemo.Clients.WeatherApi.Models.QuantitativeValue>(KiotaDemo.Clients.WeatherApi.Models.QuantitativeValue.CreateFromDiscriminatorValue); } },
                { "shortForecast", n => { ShortForecast = n.GetStringValue(); } },
                { "startTime", n => { StartTime = n.GetDateTimeOffsetValue(); } },
                { "temperature", n => { Temperature = n.GetObjectValue<KiotaDemo.Clients.WeatherApi.Models.GridpointForecastPeriod.GridpointForecastPeriod_temperature>(KiotaDemo.Clients.WeatherApi.Models.GridpointForecastPeriod.GridpointForecastPeriod_temperature.CreateFromDiscriminatorValue); } },
                { "temperatureTrend", n => { TemperatureTrend = n.GetEnumValue<KiotaDemo.Clients.WeatherApi.Models.GridpointForecastPeriod_temperatureTrend>(); } },
                { "temperatureUnit", n => { TemperatureUnit = n.GetEnumValue<KiotaDemo.Clients.WeatherApi.Models.GridpointForecastPeriod_temperatureUnit>(); } },
                { "windDirection", n => { WindDirection = n.GetEnumValue<KiotaDemo.Clients.WeatherApi.Models.GridpointForecastPeriod_windDirection>(); } },
                { "windGust", n => { WindGust = n.GetObjectValue<KiotaDemo.Clients.WeatherApi.Models.GridpointForecastPeriod.GridpointForecastPeriod_windGust>(KiotaDemo.Clients.WeatherApi.Models.GridpointForecastPeriod.GridpointForecastPeriod_windGust.CreateFromDiscriminatorValue); } },
                { "windSpeed", n => { WindSpeed = n.GetObjectValue<KiotaDemo.Clients.WeatherApi.Models.GridpointForecastPeriod.GridpointForecastPeriod_windSpeed>(KiotaDemo.Clients.WeatherApi.Models.GridpointForecastPeriod.GridpointForecastPeriod_windSpeed.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("detailedForecast", DetailedForecast);
            writer.WriteObjectValue<KiotaDemo.Clients.WeatherApi.Models.QuantitativeValue>("dewpoint", Dewpoint);
            writer.WriteDateTimeOffsetValue("endTime", EndTime);
            writer.WriteStringValue("icon", Icon);
            writer.WriteBoolValue("isDaytime", IsDaytime);
            writer.WriteStringValue("name", Name);
            writer.WriteIntValue("number", Number);
            writer.WriteObjectValue<KiotaDemo.Clients.WeatherApi.Models.QuantitativeValue>("probabilityOfPrecipitation", ProbabilityOfPrecipitation);
            writer.WriteObjectValue<KiotaDemo.Clients.WeatherApi.Models.QuantitativeValue>("relativeHumidity", RelativeHumidity);
            writer.WriteStringValue("shortForecast", ShortForecast);
            writer.WriteDateTimeOffsetValue("startTime", StartTime);
            writer.WriteObjectValue<KiotaDemo.Clients.WeatherApi.Models.GridpointForecastPeriod.GridpointForecastPeriod_temperature>("temperature", Temperature);
            writer.WriteEnumValue<KiotaDemo.Clients.WeatherApi.Models.GridpointForecastPeriod_temperatureTrend>("temperatureTrend", TemperatureTrend);
            writer.WriteEnumValue<KiotaDemo.Clients.WeatherApi.Models.GridpointForecastPeriod_temperatureUnit>("temperatureUnit", TemperatureUnit);
            writer.WriteEnumValue<KiotaDemo.Clients.WeatherApi.Models.GridpointForecastPeriod_windDirection>("windDirection", WindDirection);
            writer.WriteObjectValue<KiotaDemo.Clients.WeatherApi.Models.GridpointForecastPeriod.GridpointForecastPeriod_windGust>("windGust", WindGust);
            writer.WriteObjectValue<KiotaDemo.Clients.WeatherApi.Models.GridpointForecastPeriod.GridpointForecastPeriod_windSpeed>("windSpeed", WindSpeed);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="int"/>, <see cref="KiotaDemo.Clients.WeatherApi.Models.QuantitativeValue"/>
        /// </summary>
        public class GridpointForecastPeriod_temperature : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="int"/></summary>
            public int? Integer { get; set; }
            /// <summary>Composed type representation for type <see cref="KiotaDemo.Clients.WeatherApi.Models.QuantitativeValue"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public KiotaDemo.Clients.WeatherApi.Models.QuantitativeValue? QuantitativeValue { get; set; }
#nullable restore
#else
            public KiotaDemo.Clients.WeatherApi.Models.QuantitativeValue QuantitativeValue { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="KiotaDemo.Clients.WeatherApi.Models.GridpointForecastPeriod.GridpointForecastPeriod_temperature"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static KiotaDemo.Clients.WeatherApi.Models.GridpointForecastPeriod.GridpointForecastPeriod_temperature CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new KiotaDemo.Clients.WeatherApi.Models.GridpointForecastPeriod.GridpointForecastPeriod_temperature();
                if("QuantitativeValue".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.QuantitativeValue = new KiotaDemo.Clients.WeatherApi.Models.QuantitativeValue();
                }
                else if(parseNode.GetIntValue() is int integerValue)
                {
                    result.Integer = integerValue;
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(QuantitativeValue != null)
                {
                    return QuantitativeValue.GetFieldDeserializers();
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer)
            {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(QuantitativeValue != null)
                {
                    writer.WriteObjectValue<KiotaDemo.Clients.WeatherApi.Models.QuantitativeValue>(null, QuantitativeValue);
                }
                else if(Integer != null)
                {
                    writer.WriteIntValue(null, Integer);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="KiotaDemo.Clients.WeatherApi.Models.QuantitativeValue"/>, <see cref="string"/>
        /// </summary>
        public class GridpointForecastPeriod_windGust : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="KiotaDemo.Clients.WeatherApi.Models.QuantitativeValue"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public KiotaDemo.Clients.WeatherApi.Models.QuantitativeValue? QuantitativeValue { get; set; }
#nullable restore
#else
            public KiotaDemo.Clients.WeatherApi.Models.QuantitativeValue QuantitativeValue { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="string"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? String { get; set; }
#nullable restore
#else
            public string String { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="KiotaDemo.Clients.WeatherApi.Models.GridpointForecastPeriod.GridpointForecastPeriod_windGust"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static KiotaDemo.Clients.WeatherApi.Models.GridpointForecastPeriod.GridpointForecastPeriod_windGust CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new KiotaDemo.Clients.WeatherApi.Models.GridpointForecastPeriod.GridpointForecastPeriod_windGust();
                if("QuantitativeValue".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.QuantitativeValue = new KiotaDemo.Clients.WeatherApi.Models.QuantitativeValue();
                }
                else if(parseNode.GetStringValue() is string stringValue)
                {
                    result.String = stringValue;
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(QuantitativeValue != null)
                {
                    return QuantitativeValue.GetFieldDeserializers();
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer)
            {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(QuantitativeValue != null)
                {
                    writer.WriteObjectValue<KiotaDemo.Clients.WeatherApi.Models.QuantitativeValue>(null, QuantitativeValue);
                }
                else if(String != null)
                {
                    writer.WriteStringValue(null, String);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="KiotaDemo.Clients.WeatherApi.Models.QuantitativeValue"/>, <see cref="string"/>
        /// </summary>
        public class GridpointForecastPeriod_windSpeed : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="KiotaDemo.Clients.WeatherApi.Models.QuantitativeValue"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public KiotaDemo.Clients.WeatherApi.Models.QuantitativeValue? QuantitativeValue { get; set; }
#nullable restore
#else
            public KiotaDemo.Clients.WeatherApi.Models.QuantitativeValue QuantitativeValue { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="string"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? String { get; set; }
#nullable restore
#else
            public string String { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="KiotaDemo.Clients.WeatherApi.Models.GridpointForecastPeriod.GridpointForecastPeriod_windSpeed"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static KiotaDemo.Clients.WeatherApi.Models.GridpointForecastPeriod.GridpointForecastPeriod_windSpeed CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new KiotaDemo.Clients.WeatherApi.Models.GridpointForecastPeriod.GridpointForecastPeriod_windSpeed();
                if("QuantitativeValue".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.QuantitativeValue = new KiotaDemo.Clients.WeatherApi.Models.QuantitativeValue();
                }
                else if(parseNode.GetStringValue() is string stringValue)
                {
                    result.String = stringValue;
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(QuantitativeValue != null)
                {
                    return QuantitativeValue.GetFieldDeserializers();
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer)
            {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(QuantitativeValue != null)
                {
                    writer.WriteObjectValue<KiotaDemo.Clients.WeatherApi.Models.QuantitativeValue>(null, QuantitativeValue);
                }
                else if(String != null)
                {
                    writer.WriteStringValue(null, String);
                }
            }
        }
    }
}
