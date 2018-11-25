using System;
using System.Collections.Generic;
using RestSharp;
using Strava.NET.Client;
using Strava.NET.Model;

namespace Strava.NET.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRoutesApi
    {
        /// <summary>
        /// Export Route GPX Returns a GPX file of the route. Requires read_all scope for private routes.
        /// </summary>
        /// <param name="id">The identifier of the route.</param>
        /// <returns></returns>
        void GetRouteAsGPX (int? id);
        /// <summary>
        /// Export Route TCX Returns a TCX file of the route. Requires read_all scope for private routes.
        /// </summary>
        /// <param name="id">The identifier of the route.</param>
        /// <returns></returns>
        void GetRouteAsTCX (int? id);
        /// <summary>
        /// Get Route Returns a route using its identifier. Requires read_all scope for private routes.
        /// </summary>
        /// <param name="id">The identifier of the route.</param>
        /// <returns>Route</returns>
        Route GetRouteById (int? id);
        /// <summary>
        /// List Athlete Routes Returns a list of the routes created by the authenticated athlete using their athlete ID. Private routes are filtered out unless requested by a token with read_all scope.
        /// </summary>
        /// <param name="id">The identifier of the athlete.</param>
        /// <param name="page">Page number.</param>
        /// <param name="perPage">Number of items per page. Defaults to 30.</param>
        /// <returns>List&lt;Route&gt;</returns>
        List<Route> GetRoutesByAthleteId (int? id, int? page, int? perPage);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RoutesApi : IRoutesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoutesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public RoutesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RoutesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RoutesApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Export Route GPX Returns a GPX file of the route. Requires read_all scope for private routes.
        /// </summary>
        /// <param name="id">The identifier of the route.</param> 
        /// <returns></returns>            
        public void GetRouteAsGPX (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetRouteAsGPX");
            
    
            var path = "/routes/{id}/export_gpx";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "strava_oauth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRouteAsGPX: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRouteAsGPX: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Export Route TCX Returns a TCX file of the route. Requires read_all scope for private routes.
        /// </summary>
        /// <param name="id">The identifier of the route.</param> 
        /// <returns></returns>            
        public void GetRouteAsTCX (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetRouteAsTCX");
            
    
            var path = "/routes/{id}/export_tcx";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "strava_oauth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRouteAsTCX: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRouteAsTCX: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get Route Returns a route using its identifier. Requires read_all scope for private routes.
        /// </summary>
        /// <param name="id">The identifier of the route.</param> 
        /// <returns>Route</returns>            
        public Route GetRouteById (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetRouteById");
            
    
            var path = "/routes/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "strava_oauth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRouteById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRouteById: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Route) ApiClient.Deserialize(response.Content, typeof(Route), response.Headers);
        }
    
        /// <summary>
        /// List Athlete Routes Returns a list of the routes created by the authenticated athlete using their athlete ID. Private routes are filtered out unless requested by a token with read_all scope.
        /// </summary>
        /// <param name="id">The identifier of the athlete.</param> 
        /// <param name="page">Page number.</param> 
        /// <param name="perPage">Number of items per page. Defaults to 30.</param> 
        /// <returns>List&lt;Route&gt;</returns>            
        public List<Route> GetRoutesByAthleteId (int? id, int? page, int? perPage)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetRoutesByAthleteId");
            
    
            var path = "/athletes/{id}/routes";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "strava_oauth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRoutesByAthleteId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRoutesByAthleteId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Route>) ApiClient.Deserialize(response.Content, typeof(List<Route>), response.Headers);
        }
    
    }
}
