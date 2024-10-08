// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace KiotaDemo.Clients.WeatherApi.Models
{
    /// <summary>
    /// Lists of codes for NWS public zones and counties affected by the alert.
    /// </summary>
    public class Alert_geocode : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A list of SAME (Specific Area Message Encoding) codes for affected counties.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SAME { get; set; }
#nullable restore
#else
        public List<string> SAME { get; set; }
#endif
        /// <summary>A list of NWS public zone or county identifiers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? UGC { get; set; }
#nullable restore
#else
        public List<string> UGC { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="KiotaDemo.Clients.WeatherApi.Models.Alert_geocode"/> and sets the default values.
        /// </summary>
        public Alert_geocode()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="KiotaDemo.Clients.WeatherApi.Models.Alert_geocode"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static KiotaDemo.Clients.WeatherApi.Models.Alert_geocode CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KiotaDemo.Clients.WeatherApi.Models.Alert_geocode();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "SAME", n => { SAME = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "UGC", n => { UGC = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("SAME", SAME);
            writer.WriteCollectionOfPrimitiveValues<string>("UGC", UGC);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
