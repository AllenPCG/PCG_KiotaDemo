// <auto-generated/>
using KiotaDemo.Clients.WeatherApi.Alerts;
using KiotaDemo.Clients.WeatherApi.Aviation;
using KiotaDemo.Clients.WeatherApi.Glossary;
using KiotaDemo.Clients.WeatherApi.Gridpoints;
using KiotaDemo.Clients.WeatherApi.Icons;
using KiotaDemo.Clients.WeatherApi.Offices;
using KiotaDemo.Clients.WeatherApi.Points;
using KiotaDemo.Clients.WeatherApi.Products;
using KiotaDemo.Clients.WeatherApi.Radar;
using KiotaDemo.Clients.WeatherApi.Stations;
using KiotaDemo.Clients.WeatherApi.Thumbnails;
using KiotaDemo.Clients.WeatherApi.Zones;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Serialization.Form;
using Microsoft.Kiota.Serialization.Json;
using Microsoft.Kiota.Serialization.Multipart;
using Microsoft.Kiota.Serialization.Text;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace KiotaDemo.Clients.WeatherApi
{
    /// <summary>
    /// The main entry point of the SDK, exposes the configuration and the fluent API.
    /// </summary>
    public class WeatherApiClient : BaseRequestBuilder
    {
        /// <summary>The alerts property</summary>
        public KiotaDemo.Clients.WeatherApi.Alerts.AlertsRequestBuilder Alerts
        {
            get => new KiotaDemo.Clients.WeatherApi.Alerts.AlertsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The aviation property</summary>
        public KiotaDemo.Clients.WeatherApi.Aviation.AviationRequestBuilder Aviation
        {
            get => new KiotaDemo.Clients.WeatherApi.Aviation.AviationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The glossary property</summary>
        public KiotaDemo.Clients.WeatherApi.Glossary.GlossaryRequestBuilder Glossary
        {
            get => new KiotaDemo.Clients.WeatherApi.Glossary.GlossaryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The gridpoints property</summary>
        public KiotaDemo.Clients.WeatherApi.Gridpoints.GridpointsRequestBuilder Gridpoints
        {
            get => new KiotaDemo.Clients.WeatherApi.Gridpoints.GridpointsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The icons property</summary>
        public KiotaDemo.Clients.WeatherApi.Icons.IconsRequestBuilder Icons
        {
            get => new KiotaDemo.Clients.WeatherApi.Icons.IconsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The offices property</summary>
        public KiotaDemo.Clients.WeatherApi.Offices.OfficesRequestBuilder Offices
        {
            get => new KiotaDemo.Clients.WeatherApi.Offices.OfficesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The points property</summary>
        public KiotaDemo.Clients.WeatherApi.Points.PointsRequestBuilder Points
        {
            get => new KiotaDemo.Clients.WeatherApi.Points.PointsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The products property</summary>
        public KiotaDemo.Clients.WeatherApi.Products.ProductsRequestBuilder Products
        {
            get => new KiotaDemo.Clients.WeatherApi.Products.ProductsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The radar property</summary>
        public KiotaDemo.Clients.WeatherApi.Radar.RadarRequestBuilder Radar
        {
            get => new KiotaDemo.Clients.WeatherApi.Radar.RadarRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The stations property</summary>
        public KiotaDemo.Clients.WeatherApi.Stations.StationsRequestBuilder Stations
        {
            get => new KiotaDemo.Clients.WeatherApi.Stations.StationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The thumbnails property</summary>
        public KiotaDemo.Clients.WeatherApi.Thumbnails.ThumbnailsRequestBuilder Thumbnails
        {
            get => new KiotaDemo.Clients.WeatherApi.Thumbnails.ThumbnailsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The zones property</summary>
        public KiotaDemo.Clients.WeatherApi.Zones.ZonesRequestBuilder Zones
        {
            get => new KiotaDemo.Clients.WeatherApi.Zones.ZonesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="KiotaDemo.Clients.WeatherApi.WeatherApiClient"/> and sets the default values.
        /// </summary>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WeatherApiClient(IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}", new Dictionary<string, object>())
        {
            ApiClientBuilder.RegisterDefaultSerializer<JsonSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<TextSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<FormSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<MultipartSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<JsonParseNodeFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<TextParseNodeFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<FormParseNodeFactory>();
            if (string.IsNullOrEmpty(RequestAdapter.BaseUrl))
            {
                RequestAdapter.BaseUrl = "https://api.weather.gov";
            }
            PathParameters.TryAdd("baseurl", RequestAdapter.BaseUrl);
        }
    }
}
