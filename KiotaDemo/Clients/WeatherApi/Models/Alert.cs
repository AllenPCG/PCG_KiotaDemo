// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace KiotaDemo.Clients.WeatherApi.Models
{
    /// <summary>
    /// An object representing a public alert message.Unless otherwise noted, the fields in this object correspond to the National Weather Service CAP v1.2 specification, which extends the OASIS Common Alerting Protocol (CAP) v1.2 specification and USA Integrated Public Alert and Warning System (IPAWS) Profile v1.0. Refer to this documentation for more complete information.http://docs.oasis-open.org/emergency/cap/v1.2/CAP-v1.2-os.html http://docs.oasis-open.org/emergency/cap/v1.2/ipaws-profile/v1.0/cs01/cap-v1.2-ipaws-profile-cs01.html https://alerts.weather.gov/#technical-notes-v12
    /// </summary>
    public class Alert : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>An array of API links for zones affected by the alert. This is an API-specific extension field and is not part of the CAP specification.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AffectedZones { get; set; }
#nullable restore
#else
        public List<string> AffectedZones { get; set; }
#endif
        /// <summary>A textual description of the area affected by the alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AreaDesc { get; set; }
#nullable restore
#else
        public string AreaDesc { get; set; }
#endif
        /// <summary>The code denoting the category of the subject event of the alert message.</summary>
        public KiotaDemo.Clients.WeatherApi.Models.Alert_category? Category { get; set; }
        /// <summary>The certainty property</summary>
        public KiotaDemo.Clients.WeatherApi.Models.AlertCertainty? Certainty { get; set; }
        /// <summary>The text describing the subject event of the alert message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The effective time of the information of the alert message.</summary>
        public DateTimeOffset? Effective { get; set; }
        /// <summary>The expected end time of the subject event of the alert message.</summary>
        public DateTimeOffset? Ends { get; set; }
        /// <summary>The text denoting the type of the subject event of the alert message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Event { get; set; }
#nullable restore
#else
        public string Event { get; set; }
#endif
        /// <summary>The expiry time of the information of the alert message.</summary>
        public DateTimeOffset? Expires { get; set; }
        /// <summary>Lists of codes for NWS public zones and counties affected by the alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KiotaDemo.Clients.WeatherApi.Models.Alert_geocode? Geocode { get; set; }
#nullable restore
#else
        public KiotaDemo.Clients.WeatherApi.Models.Alert_geocode Geocode { get; set; }
#endif
        /// <summary>The text headline of the alert message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Headline { get; set; }
#nullable restore
#else
        public string Headline { get; set; }
#endif
        /// <summary>The identifier of the alert message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The text describing the recommended action to be taken by recipients of the alert message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Instruction { get; set; }
#nullable restore
#else
        public string Instruction { get; set; }
#endif
        /// <summary>The messageType property</summary>
        public KiotaDemo.Clients.WeatherApi.Models.AlertMessageType? MessageType { get; set; }
        /// <summary>The expected time of the beginning of the subject event of the alert message.</summary>
        public DateTimeOffset? Onset { get; set; }
        /// <summary>System-specific additional parameters associated with the alert message.The keys in this object correspond to parameter definitions in the NWS CAP specification.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KiotaDemo.Clients.WeatherApi.Models.Alert_parameters? Parameters { get; set; }
#nullable restore
#else
        public KiotaDemo.Clients.WeatherApi.Models.Alert_parameters Parameters { get; set; }
#endif
        /// <summary>A list of prior alerts that this alert updates or replaces.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KiotaDemo.Clients.WeatherApi.Models.Alert_references>? References { get; set; }
#nullable restore
#else
        public List<KiotaDemo.Clients.WeatherApi.Models.Alert_references> References { get; set; }
#endif
        /// <summary>The code denoting the type of action recommended for the target audience.This corresponds to responseType in the CAP specification.</summary>
        public KiotaDemo.Clients.WeatherApi.Models.Alert_response? Response { get; set; }
        /// <summary>Email address of the NWS webmaster.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sender { get; set; }
#nullable restore
#else
        public string Sender { get; set; }
#endif
        /// <summary>The text naming the originator of the alert message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SenderName { get; set; }
#nullable restore
#else
        public string SenderName { get; set; }
#endif
        /// <summary>The time of the origination of the alert message.</summary>
        public DateTimeOffset? Sent { get; set; }
        /// <summary>The severity property</summary>
        public KiotaDemo.Clients.WeatherApi.Models.AlertSeverity? Severity { get; set; }
        /// <summary>The status property</summary>
        public KiotaDemo.Clients.WeatherApi.Models.AlertStatus? Status { get; set; }
        /// <summary>The urgency property</summary>
        public KiotaDemo.Clients.WeatherApi.Models.AlertUrgency? Urgency { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="KiotaDemo.Clients.WeatherApi.Models.Alert"/> and sets the default values.
        /// </summary>
        public Alert()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="KiotaDemo.Clients.WeatherApi.Models.Alert"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static KiotaDemo.Clients.WeatherApi.Models.Alert CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KiotaDemo.Clients.WeatherApi.Models.Alert();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "affectedZones", n => { AffectedZones = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "areaDesc", n => { AreaDesc = n.GetStringValue(); } },
                { "category", n => { Category = n.GetEnumValue<KiotaDemo.Clients.WeatherApi.Models.Alert_category>(); } },
                { "certainty", n => { Certainty = n.GetEnumValue<KiotaDemo.Clients.WeatherApi.Models.AlertCertainty>(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "effective", n => { Effective = n.GetDateTimeOffsetValue(); } },
                { "ends", n => { Ends = n.GetDateTimeOffsetValue(); } },
                { "event", n => { Event = n.GetStringValue(); } },
                { "expires", n => { Expires = n.GetDateTimeOffsetValue(); } },
                { "geocode", n => { Geocode = n.GetObjectValue<KiotaDemo.Clients.WeatherApi.Models.Alert_geocode>(KiotaDemo.Clients.WeatherApi.Models.Alert_geocode.CreateFromDiscriminatorValue); } },
                { "headline", n => { Headline = n.GetStringValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "instruction", n => { Instruction = n.GetStringValue(); } },
                { "messageType", n => { MessageType = n.GetEnumValue<KiotaDemo.Clients.WeatherApi.Models.AlertMessageType>(); } },
                { "onset", n => { Onset = n.GetDateTimeOffsetValue(); } },
                { "parameters", n => { Parameters = n.GetObjectValue<KiotaDemo.Clients.WeatherApi.Models.Alert_parameters>(KiotaDemo.Clients.WeatherApi.Models.Alert_parameters.CreateFromDiscriminatorValue); } },
                { "references", n => { References = n.GetCollectionOfObjectValues<KiotaDemo.Clients.WeatherApi.Models.Alert_references>(KiotaDemo.Clients.WeatherApi.Models.Alert_references.CreateFromDiscriminatorValue)?.ToList(); } },
                { "response", n => { Response = n.GetEnumValue<KiotaDemo.Clients.WeatherApi.Models.Alert_response>(); } },
                { "sender", n => { Sender = n.GetStringValue(); } },
                { "senderName", n => { SenderName = n.GetStringValue(); } },
                { "sent", n => { Sent = n.GetDateTimeOffsetValue(); } },
                { "severity", n => { Severity = n.GetEnumValue<KiotaDemo.Clients.WeatherApi.Models.AlertSeverity>(); } },
                { "status", n => { Status = n.GetEnumValue<KiotaDemo.Clients.WeatherApi.Models.AlertStatus>(); } },
                { "urgency", n => { Urgency = n.GetEnumValue<KiotaDemo.Clients.WeatherApi.Models.AlertUrgency>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("affectedZones", AffectedZones);
            writer.WriteStringValue("areaDesc", AreaDesc);
            writer.WriteEnumValue<KiotaDemo.Clients.WeatherApi.Models.Alert_category>("category", Category);
            writer.WriteEnumValue<KiotaDemo.Clients.WeatherApi.Models.AlertCertainty>("certainty", Certainty);
            writer.WriteStringValue("description", Description);
            writer.WriteDateTimeOffsetValue("effective", Effective);
            writer.WriteDateTimeOffsetValue("ends", Ends);
            writer.WriteStringValue("event", Event);
            writer.WriteDateTimeOffsetValue("expires", Expires);
            writer.WriteObjectValue<KiotaDemo.Clients.WeatherApi.Models.Alert_geocode>("geocode", Geocode);
            writer.WriteStringValue("headline", Headline);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("instruction", Instruction);
            writer.WriteEnumValue<KiotaDemo.Clients.WeatherApi.Models.AlertMessageType>("messageType", MessageType);
            writer.WriteDateTimeOffsetValue("onset", Onset);
            writer.WriteObjectValue<KiotaDemo.Clients.WeatherApi.Models.Alert_parameters>("parameters", Parameters);
            writer.WriteCollectionOfObjectValues<KiotaDemo.Clients.WeatherApi.Models.Alert_references>("references", References);
            writer.WriteEnumValue<KiotaDemo.Clients.WeatherApi.Models.Alert_response>("response", Response);
            writer.WriteStringValue("sender", Sender);
            writer.WriteStringValue("senderName", SenderName);
            writer.WriteDateTimeOffsetValue("sent", Sent);
            writer.WriteEnumValue<KiotaDemo.Clients.WeatherApi.Models.AlertSeverity>("severity", Severity);
            writer.WriteEnumValue<KiotaDemo.Clients.WeatherApi.Models.AlertStatus>("status", Status);
            writer.WriteEnumValue<KiotaDemo.Clients.WeatherApi.Models.AlertUrgency>("urgency", Urgency);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
