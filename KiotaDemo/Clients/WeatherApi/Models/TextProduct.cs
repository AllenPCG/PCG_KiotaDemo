// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace KiotaDemo.Clients.WeatherApi.Models
{
    #pragma warning disable CS1591
    public class TextProduct : IParsable
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
        /// <summary>The Id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The issuanceTime property</summary>
        public DateTimeOffset? IssuanceTime { get; set; }
        /// <summary>The issuingOffice property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IssuingOffice { get; set; }
#nullable restore
#else
        public string IssuingOffice { get; set; }
#endif
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
        /// <summary>The productText property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductText { get; set; }
#nullable restore
#else
        public string ProductText { get; set; }
#endif
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TextProductId { get; set; }
#nullable restore
#else
        public string TextProductId { get; set; }
#endif
        /// <summary>The wmoCollectiveId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WmoCollectiveId { get; set; }
#nullable restore
#else
        public string WmoCollectiveId { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="KiotaDemo.Clients.WeatherApi.Models.TextProduct"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static KiotaDemo.Clients.WeatherApi.Models.TextProduct CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KiotaDemo.Clients.WeatherApi.Models.TextProduct();
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
                { "@id", n => { Id = n.GetStringValue(); } },
                { "issuanceTime", n => { IssuanceTime = n.GetDateTimeOffsetValue(); } },
                { "issuingOffice", n => { IssuingOffice = n.GetStringValue(); } },
                { "productCode", n => { ProductCode = n.GetStringValue(); } },
                { "productName", n => { ProductName = n.GetStringValue(); } },
                { "productText", n => { ProductText = n.GetStringValue(); } },
                { "id", n => { TextProductId = n.GetStringValue(); } },
                { "wmoCollectiveId", n => { WmoCollectiveId = n.GetStringValue(); } },
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
            writer.WriteStringValue("@id", Id);
            writer.WriteDateTimeOffsetValue("issuanceTime", IssuanceTime);
            writer.WriteStringValue("issuingOffice", IssuingOffice);
            writer.WriteStringValue("productCode", ProductCode);
            writer.WriteStringValue("productName", ProductName);
            writer.WriteStringValue("productText", ProductText);
            writer.WriteStringValue("id", TextProductId);
            writer.WriteStringValue("wmoCollectiveId", WmoCollectiveId);
        }
    }
}
