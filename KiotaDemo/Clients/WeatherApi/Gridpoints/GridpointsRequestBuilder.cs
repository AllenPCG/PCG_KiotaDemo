// <auto-generated/>
using KiotaDemo.Clients.WeatherApi.Gridpoints.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace KiotaDemo.Clients.WeatherApi.Gridpoints
{
    /// <summary>
    /// Builds and executes requests for operations under \gridpoints
    /// </summary>
    public class GridpointsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the KiotaDemo.Clients.WeatherApi.gridpoints.item collection</summary>
        /// <param name="position">Forecast office ID</param>
        /// <returns>A <see cref="KiotaDemo.Clients.WeatherApi.Gridpoints.Item.WithWfoItemRequestBuilder"/></returns>
        public KiotaDemo.Clients.WeatherApi.Gridpoints.Item.WithWfoItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("wfo", position);
                return new KiotaDemo.Clients.WeatherApi.Gridpoints.Item.WithWfoItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="KiotaDemo.Clients.WeatherApi.Gridpoints.GridpointsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GridpointsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/gridpoints", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="KiotaDemo.Clients.WeatherApi.Gridpoints.GridpointsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GridpointsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/gridpoints", rawUrl)
        {
        }
    }
}
