// <auto-generated/>
using KiotaDemo.Clients.WeatherApi.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace KiotaDemo.Clients.WeatherApi.Gridpoints.Item.WithXWithY.Forecast.Hourly
{
    /// <summary>
    /// Builds and executes requests for operations under \gridpoints\{wfo}\{x},{y}\forecast\hourly
    /// </summary>
    public class HourlyRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="KiotaDemo.Clients.WeatherApi.Gridpoints.Item.WithXWithY.Forecast.Hourly.HourlyRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public HourlyRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/gridpoints/{wfo}/{x},{y}/forecast/hourly{?units*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="KiotaDemo.Clients.WeatherApi.Gridpoints.Item.WithXWithY.Forecast.Hourly.HourlyRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public HourlyRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/gridpoints/{wfo}/{x},{y}/forecast/hourly{?units*}", rawUrl)
        {
        }
        /// <summary>
        /// Returns a textual hourly forecast for a 2.5km grid area
        /// </summary>
        /// <returns>A <see cref="KiotaDemo.Clients.WeatherApi.Models.GridpointForecastGeoJson"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="KiotaDemo.Clients.WeatherApi.Models.ProblemDetail">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<KiotaDemo.Clients.WeatherApi.Models.GridpointForecastGeoJson?> GetAsync(Action<RequestConfiguration<KiotaDemo.Clients.WeatherApi.Gridpoints.Item.WithXWithY.Forecast.Hourly.HourlyRequestBuilder.HourlyRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<KiotaDemo.Clients.WeatherApi.Models.GridpointForecastGeoJson> GetAsync(Action<RequestConfiguration<KiotaDemo.Clients.WeatherApi.Gridpoints.Item.WithXWithY.Forecast.Hourly.HourlyRequestBuilder.HourlyRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", KiotaDemo.Clients.WeatherApi.Models.ProblemDetail.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<KiotaDemo.Clients.WeatherApi.Models.GridpointForecastGeoJson>(requestInfo, KiotaDemo.Clients.WeatherApi.Models.GridpointForecastGeoJson.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns a textual hourly forecast for a 2.5km grid area
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KiotaDemo.Clients.WeatherApi.Gridpoints.Item.WithXWithY.Forecast.Hourly.HourlyRequestBuilder.HourlyRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KiotaDemo.Clients.WeatherApi.Gridpoints.Item.WithXWithY.Forecast.Hourly.HourlyRequestBuilder.HourlyRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="KiotaDemo.Clients.WeatherApi.Gridpoints.Item.WithXWithY.Forecast.Hourly.HourlyRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public KiotaDemo.Clients.WeatherApi.Gridpoints.Item.WithXWithY.Forecast.Hourly.HourlyRequestBuilder WithUrl(string rawUrl)
        {
            return new KiotaDemo.Clients.WeatherApi.Gridpoints.Item.WithXWithY.Forecast.Hourly.HourlyRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns a textual hourly forecast for a 2.5km grid area
        /// </summary>
        public class HourlyRequestBuilderGetQueryParameters 
        {
            /// <summary>Use US customary or SI (metric) units in textual output</summary>
            [QueryParameter("units")]
            public KiotaDemo.Clients.WeatherApi.Models.GridpointForecastUnits? Units { get; set; }
        }
    }
}
