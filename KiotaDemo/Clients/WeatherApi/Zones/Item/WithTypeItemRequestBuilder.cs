// <auto-generated/>
using KiotaDemo.Clients.WeatherApi.Models;
using KiotaDemo.Clients.WeatherApi.Zones.Item.Item;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace KiotaDemo.Clients.WeatherApi.Zones.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \zones\{type}
    /// </summary>
    public class WithTypeItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the KiotaDemo.Clients.WeatherApi.zones.item.item collection</summary>
        /// <param name="position">NWS public zone/county identifier</param>
        /// <returns>A <see cref="KiotaDemo.Clients.WeatherApi.Zones.Item.Item.WithZoneItemRequestBuilder"/></returns>
        public KiotaDemo.Clients.WeatherApi.Zones.Item.Item.WithZoneItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("zoneId", position);
                return new KiotaDemo.Clients.WeatherApi.Zones.Item.Item.WithZoneItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="KiotaDemo.Clients.WeatherApi.Zones.Item.WithTypeItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithTypeItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/zones/{type}{?area,effective*,id,include_geometry*,limit*,point*,region,type}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="KiotaDemo.Clients.WeatherApi.Zones.Item.WithTypeItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithTypeItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/zones/{type}{?area,effective*,id,include_geometry*,limit*,point*,region,type}", rawUrl)
        {
        }
        /// <summary>
        /// Returns a list of zones of a given type
        /// </summary>
        /// <returns>A <see cref="KiotaDemo.Clients.WeatherApi.Models.ZoneCollectionGeoJson"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="KiotaDemo.Clients.WeatherApi.Models.ProblemDetail">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<KiotaDemo.Clients.WeatherApi.Models.ZoneCollectionGeoJson?> GetAsync(Action<RequestConfiguration<KiotaDemo.Clients.WeatherApi.Zones.Item.WithTypeItemRequestBuilder.WithTypeItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<KiotaDemo.Clients.WeatherApi.Models.ZoneCollectionGeoJson> GetAsync(Action<RequestConfiguration<KiotaDemo.Clients.WeatherApi.Zones.Item.WithTypeItemRequestBuilder.WithTypeItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", KiotaDemo.Clients.WeatherApi.Models.ProblemDetail.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<KiotaDemo.Clients.WeatherApi.Models.ZoneCollectionGeoJson>(requestInfo, KiotaDemo.Clients.WeatherApi.Models.ZoneCollectionGeoJson.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns a list of zones of a given type
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KiotaDemo.Clients.WeatherApi.Zones.Item.WithTypeItemRequestBuilder.WithTypeItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KiotaDemo.Clients.WeatherApi.Zones.Item.WithTypeItemRequestBuilder.WithTypeItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/geo+json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="KiotaDemo.Clients.WeatherApi.Zones.Item.WithTypeItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public KiotaDemo.Clients.WeatherApi.Zones.Item.WithTypeItemRequestBuilder WithUrl(string rawUrl)
        {
            return new KiotaDemo.Clients.WeatherApi.Zones.Item.WithTypeItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns a list of zones of a given type
        /// </summary>
        public class WithTypeItemRequestBuilderGetQueryParameters 
        {
            /// <summary>State/marine area code</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("area")]
            public string[]? Area { get; set; }
#nullable restore
#else
            [QueryParameter("area")]
            public string[] Area { get; set; }
#endif
            /// <summary>Effective date/time</summary>
            [QueryParameter("effective")]
            public DateTimeOffset? Effective { get; set; }
            /// <summary>Zone ID (forecast or county)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("id")]
            public string[]? Id { get; set; }
#nullable restore
#else
            [QueryParameter("id")]
            public string[] Id { get; set; }
#endif
            /// <summary>Include geometry in results (true/false)</summary>
            [QueryParameter("include_geometry")]
            public bool? IncludeGeometry { get; set; }
            /// <summary>Limit</summary>
            [QueryParameter("limit")]
            public int? Limit { get; set; }
            /// <summary>Point (latitude,longitude)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("point")]
            public string? Point { get; set; }
#nullable restore
#else
            [QueryParameter("point")]
            public string Point { get; set; }
#endif
            /// <summary>Region code</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("region")]
            public string[]? Region { get; set; }
#nullable restore
#else
            [QueryParameter("region")]
            public string[] Region { get; set; }
#endif
            /// <summary>Zone type</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("type")]
            public KiotaDemo.Clients.WeatherApi.Models.NWSZoneType[]? Type { get; set; }
#nullable restore
#else
            [QueryParameter("type")]
            public KiotaDemo.Clients.WeatherApi.Models.NWSZoneType[] Type { get; set; }
#endif
        }
    }
}
