// <auto-generated/>
using KiotaDemo.Clients.WeatherApi.Models;
using KiotaDemo.Clients.WeatherApi.Products.Types.Item;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace KiotaDemo.Clients.WeatherApi.Products.Types
{
    /// <summary>
    /// Builds and executes requests for operations under \products\types
    /// </summary>
    public class TypesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the KiotaDemo.Clients.WeatherApi.products.types.item collection</summary>
        /// <param name="position">.</param>
        /// <returns>A <see cref="KiotaDemo.Clients.WeatherApi.Products.Types.Item.WithTypeItemRequestBuilder"/></returns>
        public KiotaDemo.Clients.WeatherApi.Products.Types.Item.WithTypeItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("typeId", position);
                return new KiotaDemo.Clients.WeatherApi.Products.Types.Item.WithTypeItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="KiotaDemo.Clients.WeatherApi.Products.Types.TypesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TypesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/products/types", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="KiotaDemo.Clients.WeatherApi.Products.Types.TypesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TypesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/products/types", rawUrl)
        {
        }
        /// <summary>
        /// Returns a list of valid text product types and codes
        /// </summary>
        /// <returns>A <see cref="KiotaDemo.Clients.WeatherApi.Models.TextProductTypeCollection"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="KiotaDemo.Clients.WeatherApi.Models.ProblemDetail">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<KiotaDemo.Clients.WeatherApi.Models.TextProductTypeCollection?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<KiotaDemo.Clients.WeatherApi.Models.TextProductTypeCollection> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", KiotaDemo.Clients.WeatherApi.Models.ProblemDetail.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<KiotaDemo.Clients.WeatherApi.Models.TextProductTypeCollection>(requestInfo, KiotaDemo.Clients.WeatherApi.Models.TextProductTypeCollection.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns a list of valid text product types and codes
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="KiotaDemo.Clients.WeatherApi.Products.Types.TypesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public KiotaDemo.Clients.WeatherApi.Products.Types.TypesRequestBuilder WithUrl(string rawUrl)
        {
            return new KiotaDemo.Clients.WeatherApi.Products.Types.TypesRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
