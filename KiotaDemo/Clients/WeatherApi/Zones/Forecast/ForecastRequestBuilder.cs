// <auto-generated/>
using KiotaDemo.Clients.WeatherApi.Zones.Forecast.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace KiotaDemo.Clients.WeatherApi.Zones.Forecast
{
    /// <summary>
    /// Builds and executes requests for operations under \zones\forecast
    /// </summary>
    public class ForecastRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the KiotaDemo.Clients.WeatherApi.zones.forecast.item collection</summary>
        /// <param name="position">NWS public zone/county identifier</param>
        /// <returns>A <see cref="KiotaDemo.Clients.WeatherApi.Zones.Forecast.Item.WithZoneItemRequestBuilder"/></returns>
        public KiotaDemo.Clients.WeatherApi.Zones.Forecast.Item.WithZoneItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("zoneId", position);
                return new KiotaDemo.Clients.WeatherApi.Zones.Forecast.Item.WithZoneItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="KiotaDemo.Clients.WeatherApi.Zones.Forecast.ForecastRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ForecastRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/zones/forecast", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="KiotaDemo.Clients.WeatherApi.Zones.Forecast.ForecastRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ForecastRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/zones/forecast", rawUrl)
        {
        }
    }
}
