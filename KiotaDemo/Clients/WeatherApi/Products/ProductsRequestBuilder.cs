// <auto-generated/>
using KiotaDemo.Clients.WeatherApi.Models;
using KiotaDemo.Clients.WeatherApi.Products.Item;
using KiotaDemo.Clients.WeatherApi.Products.Locations;
using KiotaDemo.Clients.WeatherApi.Products.Types;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace KiotaDemo.Clients.WeatherApi.Products
{
    /// <summary>
    /// Builds and executes requests for operations under \products
    /// </summary>
    public class ProductsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The locations property</summary>
        public KiotaDemo.Clients.WeatherApi.Products.Locations.LocationsRequestBuilder Locations
        {
            get => new KiotaDemo.Clients.WeatherApi.Products.Locations.LocationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The types property</summary>
        public KiotaDemo.Clients.WeatherApi.Products.Types.TypesRequestBuilder Types
        {
            get => new KiotaDemo.Clients.WeatherApi.Products.Types.TypesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the KiotaDemo.Clients.WeatherApi.products.item collection</summary>
        /// <param name="position">.</param>
        /// <returns>A <see cref="KiotaDemo.Clients.WeatherApi.Products.Item.WithProductItemRequestBuilder"/></returns>
        public KiotaDemo.Clients.WeatherApi.Products.Item.WithProductItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("productId", position);
                return new KiotaDemo.Clients.WeatherApi.Products.Item.WithProductItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="KiotaDemo.Clients.WeatherApi.Products.ProductsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ProductsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/products{?end*,limit*,location,office,start*,type,wmoid}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="KiotaDemo.Clients.WeatherApi.Products.ProductsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ProductsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/products{?end*,limit*,location,office,start*,type,wmoid}", rawUrl)
        {
        }
        /// <summary>
        /// Returns a list of text products
        /// </summary>
        /// <returns>A <see cref="KiotaDemo.Clients.WeatherApi.Models.TextProductCollection"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="KiotaDemo.Clients.WeatherApi.Models.ProblemDetail">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<KiotaDemo.Clients.WeatherApi.Models.TextProductCollection?> GetAsync(Action<RequestConfiguration<KiotaDemo.Clients.WeatherApi.Products.ProductsRequestBuilder.ProductsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<KiotaDemo.Clients.WeatherApi.Models.TextProductCollection> GetAsync(Action<RequestConfiguration<KiotaDemo.Clients.WeatherApi.Products.ProductsRequestBuilder.ProductsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", KiotaDemo.Clients.WeatherApi.Models.ProblemDetail.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<KiotaDemo.Clients.WeatherApi.Models.TextProductCollection>(requestInfo, KiotaDemo.Clients.WeatherApi.Models.TextProductCollection.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns a list of text products
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KiotaDemo.Clients.WeatherApi.Products.ProductsRequestBuilder.ProductsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KiotaDemo.Clients.WeatherApi.Products.ProductsRequestBuilder.ProductsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="KiotaDemo.Clients.WeatherApi.Products.ProductsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public KiotaDemo.Clients.WeatherApi.Products.ProductsRequestBuilder WithUrl(string rawUrl)
        {
            return new KiotaDemo.Clients.WeatherApi.Products.ProductsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns a list of text products
        /// </summary>
        public class ProductsRequestBuilderGetQueryParameters 
        {
            /// <summary>End time</summary>
            [QueryParameter("end")]
            public DateTimeOffset? End { get; set; }
            /// <summary>Limit</summary>
            [QueryParameter("limit")]
            public int? Limit { get; set; }
            /// <summary>Location id</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("location")]
            public string[]? Location { get; set; }
#nullable restore
#else
            [QueryParameter("location")]
            public string[] Location { get; set; }
#endif
            /// <summary>Issuing office</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("office")]
            public string[]? Office { get; set; }
#nullable restore
#else
            [QueryParameter("office")]
            public string[] Office { get; set; }
#endif
            /// <summary>Start time</summary>
            [QueryParameter("start")]
            public DateTimeOffset? Start { get; set; }
            /// <summary>Product code</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("type")]
            public string[]? Type { get; set; }
#nullable restore
#else
            [QueryParameter("type")]
            public string[] Type { get; set; }
#endif
            /// <summary>WMO id code</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("wmoid")]
            public string[]? Wmoid { get; set; }
#nullable restore
#else
            [QueryParameter("wmoid")]
            public string[] Wmoid { get; set; }
#endif
        }
    }
}
