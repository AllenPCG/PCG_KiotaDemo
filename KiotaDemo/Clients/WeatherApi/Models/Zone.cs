// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace KiotaDemo.Clients.WeatherApi.Models
{
    #pragma warning disable CS1591
    public class Zone : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The awipsLocationIdentifier property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AwipsLocationIdentifier { get; set; }
#nullable restore
#else
        public string AwipsLocationIdentifier { get; set; }
#endif
        /// <summary>The Context property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Context { get; set; }
#nullable restore
#else
        public UntypedNode Context { get; set; }
#endif
        /// <summary>The cwa property</summary>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KiotaDemo.Clients.WeatherApi.Models.NWSForecastOfficeId?>? Cwa { get; set; }
#nullable restore
#else
        public List<KiotaDemo.Clients.WeatherApi.Models.NWSForecastOfficeId?> Cwa { get; set; }
#endif
        /// <summary>The effectiveDate property</summary>
        public DateTimeOffset? EffectiveDate { get; set; }
        /// <summary>The expirationDate property</summary>
        public DateTimeOffset? ExpirationDate { get; set; }
        /// <summary>The forecastOffice property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ForecastOffice { get; set; }
#nullable restore
#else
        public string ForecastOffice { get; set; }
#endif
        /// <summary>The forecastOffices property</summary>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ForecastOffices { get; set; }
#nullable restore
#else
        public List<string> ForecastOffices { get; set; }
#endif
        /// <summary>A geometry represented in Well-Known Text (WKT) format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Geometry { get; set; }
#nullable restore
#else
        public string Geometry { get; set; }
#endif
        /// <summary>The gridIdentifier property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GridIdentifier { get; set; }
#nullable restore
#else
        public string GridIdentifier { get; set; }
#endif
        /// <summary>The Id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The observationStations property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ObservationStations { get; set; }
#nullable restore
#else
        public List<string> ObservationStations { get; set; }
#endif
        /// <summary>The radarStation property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RadarStation { get; set; }
#nullable restore
#else
        public string RadarStation { get; set; }
#endif
        /// <summary>The state property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KiotaDemo.Clients.WeatherApi.Models.Zone.Zone_state? State { get; set; }
#nullable restore
#else
        public KiotaDemo.Clients.WeatherApi.Models.Zone.Zone_state State { get; set; }
#endif
        /// <summary>The timeZone property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? TimeZone { get; set; }
#nullable restore
#else
        public List<string> TimeZone { get; set; }
#endif
        /// <summary>The Type property</summary>
        public KiotaDemo.Clients.WeatherApi.Models.Zone_Type? Type { get; set; }
        /// <summary>UGC identifier for a NWS forecast zone or county.The first two letters will correspond to either a state code or marine area code (see #/components/schemas/StateTerritoryCode and #/components/schemas/MarineAreaCode for lists of valid letter combinations).The third letter will be Z for public/fire zone or C for county.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ZoneId { get; set; }
#nullable restore
#else
        public string ZoneId { get; set; }
#endif
        /// <summary>The type property</summary>
        public KiotaDemo.Clients.WeatherApi.Models.NWSZoneType? ZoneType { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="KiotaDemo.Clients.WeatherApi.Models.Zone"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static KiotaDemo.Clients.WeatherApi.Models.Zone CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KiotaDemo.Clients.WeatherApi.Models.Zone();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "awipsLocationIdentifier", n => { AwipsLocationIdentifier = n.GetStringValue(); } },
                { "@context", n => { Context = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "cwa", n => { Cwa = n.GetCollectionOfEnumValues<KiotaDemo.Clients.WeatherApi.Models.NWSForecastOfficeId>()?.ToList(); } },
                { "effectiveDate", n => { EffectiveDate = n.GetDateTimeOffsetValue(); } },
                { "expirationDate", n => { ExpirationDate = n.GetDateTimeOffsetValue(); } },
                { "forecastOffice", n => { ForecastOffice = n.GetStringValue(); } },
                { "forecastOffices", n => { ForecastOffices = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "geometry", n => { Geometry = n.GetStringValue(); } },
                { "gridIdentifier", n => { GridIdentifier = n.GetStringValue(); } },
                { "@id", n => { Id = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "observationStations", n => { ObservationStations = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "radarStation", n => { RadarStation = n.GetStringValue(); } },
                { "state", n => { State = n.GetObjectValue<KiotaDemo.Clients.WeatherApi.Models.Zone.Zone_state>(KiotaDemo.Clients.WeatherApi.Models.Zone.Zone_state.CreateFromDiscriminatorValue); } },
                { "timeZone", n => { TimeZone = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "@type", n => { Type = n.GetEnumValue<KiotaDemo.Clients.WeatherApi.Models.Zone_Type>(); } },
                { "id", n => { ZoneId = n.GetStringValue(); } },
                { "type", n => { ZoneType = n.GetEnumValue<KiotaDemo.Clients.WeatherApi.Models.NWSZoneType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("awipsLocationIdentifier", AwipsLocationIdentifier);
            writer.WriteObjectValue<UntypedNode>("@context", Context);
            writer.WriteCollectionOfEnumValues<KiotaDemo.Clients.WeatherApi.Models.NWSForecastOfficeId>("cwa", Cwa);
            writer.WriteDateTimeOffsetValue("effectiveDate", EffectiveDate);
            writer.WriteDateTimeOffsetValue("expirationDate", ExpirationDate);
            writer.WriteStringValue("forecastOffice", ForecastOffice);
            writer.WriteCollectionOfPrimitiveValues<string>("forecastOffices", ForecastOffices);
            writer.WriteStringValue("geometry", Geometry);
            writer.WriteStringValue("gridIdentifier", GridIdentifier);
            writer.WriteStringValue("@id", Id);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfPrimitiveValues<string>("observationStations", ObservationStations);
            writer.WriteStringValue("radarStation", RadarStation);
            writer.WriteObjectValue<KiotaDemo.Clients.WeatherApi.Models.Zone.Zone_state>("state", State);
            writer.WriteCollectionOfPrimitiveValues<string>("timeZone", TimeZone);
            writer.WriteEnumValue<KiotaDemo.Clients.WeatherApi.Models.Zone_Type>("@type", Type);
            writer.WriteStringValue("id", ZoneId);
            writer.WriteEnumValue<KiotaDemo.Clients.WeatherApi.Models.NWSZoneType>("type", ZoneType);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="KiotaDemo.Clients.WeatherApi.Models.StateTerritoryCode"/>, <see cref="string"/>
        /// </summary>
        public class Zone_state : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="KiotaDemo.Clients.WeatherApi.Models.StateTerritoryCode"/></summary>
            public KiotaDemo.Clients.WeatherApi.Models.StateTerritoryCode? StateTerritoryCode { get; set; }
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
            /// <returns>A <see cref="KiotaDemo.Clients.WeatherApi.Models.Zone.Zone_state"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static KiotaDemo.Clients.WeatherApi.Models.Zone.Zone_state CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new KiotaDemo.Clients.WeatherApi.Models.Zone.Zone_state();
                if(parseNode.GetEnumValue<KiotaDemo.Clients.WeatherApi.Models.StateTerritoryCode>() is KiotaDemo.Clients.WeatherApi.Models.StateTerritoryCode stateTerritoryCodeValue)
                {
                    result.StateTerritoryCode = stateTerritoryCodeValue;
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
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer)
            {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(StateTerritoryCode != null)
                {
                    writer.WriteEnumValue<KiotaDemo.Clients.WeatherApi.Models.StateTerritoryCode>(null, StateTerritoryCode);
                }
                else if(String != null)
                {
                    writer.WriteStringValue(null, String);
                }
            }
        }
    }
}
