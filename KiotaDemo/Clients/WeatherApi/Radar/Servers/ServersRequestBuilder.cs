// <auto-generated/>
using KiotaDemo.Clients.WeatherApi.Models;
using KiotaDemo.Clients.WeatherApi.Radar.Servers.Item;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace KiotaDemo.Clients.WeatherApi.Radar.Servers
{
    /// <summary>
    /// Builds and executes requests for operations under \radar\servers
    /// </summary>
    public class ServersRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the KiotaDemo.Clients.WeatherApi.radar.servers.item collection</summary>
        /// <param name="position">Server ID</param>
        /// <returns>A <see cref="KiotaDemo.Clients.WeatherApi.Radar.Servers.Item.ServersItemRequestBuilder"/></returns>
        public KiotaDemo.Clients.WeatherApi.Radar.Servers.Item.ServersItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new KiotaDemo.Clients.WeatherApi.Radar.Servers.Item.ServersItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="KiotaDemo.Clients.WeatherApi.Radar.Servers.ServersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ServersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/radar/servers{?reportingHost*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="KiotaDemo.Clients.WeatherApi.Radar.Servers.ServersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ServersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/radar/servers{?reportingHost*}", rawUrl)
        {
        }
        /// <summary>
        /// Returns a list of radar servers
        /// </summary>
        /// <returns>A <see cref="UntypedNode"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="KiotaDemo.Clients.WeatherApi.Models.ProblemDetail">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<UntypedNode?> GetAsync(Action<RequestConfiguration<KiotaDemo.Clients.WeatherApi.Radar.Servers.ServersRequestBuilder.ServersRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<UntypedNode> GetAsync(Action<RequestConfiguration<KiotaDemo.Clients.WeatherApi.Radar.Servers.ServersRequestBuilder.ServersRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", KiotaDemo.Clients.WeatherApi.Models.ProblemDetail.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<UntypedNode>(requestInfo, UntypedNode.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns a list of radar servers
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KiotaDemo.Clients.WeatherApi.Radar.Servers.ServersRequestBuilder.ServersRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KiotaDemo.Clients.WeatherApi.Radar.Servers.ServersRequestBuilder.ServersRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/ld+json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="KiotaDemo.Clients.WeatherApi.Radar.Servers.ServersRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public KiotaDemo.Clients.WeatherApi.Radar.Servers.ServersRequestBuilder WithUrl(string rawUrl)
        {
            return new KiotaDemo.Clients.WeatherApi.Radar.Servers.ServersRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns a list of radar servers
        /// </summary>
        public class ServersRequestBuilderGetQueryParameters 
        {
            /// <summary>Show records from specific reporting host</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("reportingHost")]
            public string? ReportingHost { get; set; }
#nullable restore
#else
            [QueryParameter("reportingHost")]
            public string ReportingHost { get; set; }
#endif
        }
    }
}
