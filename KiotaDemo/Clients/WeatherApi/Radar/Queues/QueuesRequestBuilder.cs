// <auto-generated/>
using KiotaDemo.Clients.WeatherApi.Radar.Queues.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace KiotaDemo.Clients.WeatherApi.Radar.Queues
{
    /// <summary>
    /// Builds and executes requests for operations under \radar\queues
    /// </summary>
    public class QueuesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the KiotaDemo.Clients.WeatherApi.radar.queues.item collection</summary>
        /// <param name="position">LDM host</param>
        /// <returns>A <see cref="KiotaDemo.Clients.WeatherApi.Radar.Queues.Item.WithHostItemRequestBuilder"/></returns>
        public KiotaDemo.Clients.WeatherApi.Radar.Queues.Item.WithHostItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("host", position);
                return new KiotaDemo.Clients.WeatherApi.Radar.Queues.Item.WithHostItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="KiotaDemo.Clients.WeatherApi.Radar.Queues.QueuesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public QueuesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/radar/queues", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="KiotaDemo.Clients.WeatherApi.Radar.Queues.QueuesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public QueuesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/radar/queues", rawUrl)
        {
        }
    }
}
