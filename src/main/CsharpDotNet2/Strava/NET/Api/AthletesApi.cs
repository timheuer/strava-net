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
    public interface IAthletesApi
    {
        /// <summary>
        /// Get Authenticated Athlete Returns the currently authenticated athlete. Tokens with profile:read_all scope will receive a detailed athlete representation; all others will receive a summary representation.
        /// </summary>
        /// <returns>DetailedAthlete</returns>
        DetailedAthlete GetLoggedInAthlete ();
        /// <summary>
        /// Get Zones Returns the the authenticated athlete&#39;s heart rate and power zones. Requires profile:read_all.
        /// </summary>
        /// <returns>Zones</returns>
        Zones GetLoggedInAthleteZones ();
        /// <summary>
        /// Get Athlete Stats Returns the activity stats of an athlete.
        /// </summary>
        /// <param name="id">The identifier of the athlete. Must match the authenticated athlete.</param>
        /// <param name="page">Page number.</param>
        /// <param name="perPage">Number of items per page. Defaults to 30.</param>
        /// <returns>ActivityStats</returns>
        ActivityStats GetStats (int? id, int? page, int? perPage);
        /// <summary>
        /// Update Athlete Update the currently authenticated athlete. Requires profile:write scope.
        /// </summary>
        /// <param name="weight">The weight of the athlete in kilograms.</param>
        /// <returns>DetailedAthlete</returns>
        DetailedAthlete UpdateLoggedInAthlete (float? weight);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AthletesApi : IAthletesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AthletesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AthletesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AthletesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AthletesApi(String basePath)
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
        /// Get Authenticated Athlete Returns the currently authenticated athlete. Tokens with profile:read_all scope will receive a detailed athlete representation; all others will receive a summary representation.
        /// </summary>
        /// <returns>DetailedAthlete</returns>            
        public DetailedAthlete GetLoggedInAthlete ()
        {
            
    
            var path = "/athlete";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetLoggedInAthlete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetLoggedInAthlete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DetailedAthlete) ApiClient.Deserialize(response.Content, typeof(DetailedAthlete), response.Headers);
        }
    
        /// <summary>
        /// Get Zones Returns the the authenticated athlete&#39;s heart rate and power zones. Requires profile:read_all.
        /// </summary>
        /// <returns>Zones</returns>            
        public Zones GetLoggedInAthleteZones ()
        {
            
    
            var path = "/athlete/zones";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetLoggedInAthleteZones: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetLoggedInAthleteZones: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Zones) ApiClient.Deserialize(response.Content, typeof(Zones), response.Headers);
        }
    
        /// <summary>
        /// Get Athlete Stats Returns the activity stats of an athlete.
        /// </summary>
        /// <param name="id">The identifier of the athlete. Must match the authenticated athlete.</param> 
        /// <param name="page">Page number.</param> 
        /// <param name="perPage">Number of items per page. Defaults to 30.</param> 
        /// <returns>ActivityStats</returns>            
        public ActivityStats GetStats (int? id, int? page, int? perPage)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetStats");
            
    
            var path = "/athletes/{id}/stats";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetStats: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetStats: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ActivityStats) ApiClient.Deserialize(response.Content, typeof(ActivityStats), response.Headers);
        }
    
        /// <summary>
        /// Update Athlete Update the currently authenticated athlete. Requires profile:write scope.
        /// </summary>
        /// <param name="weight">The weight of the athlete in kilograms.</param> 
        /// <returns>DetailedAthlete</returns>            
        public DetailedAthlete UpdateLoggedInAthlete (float? weight)
        {
            
            // verify the required parameter 'weight' is set
            if (weight == null) throw new ApiException(400, "Missing required parameter 'weight' when calling UpdateLoggedInAthlete");
            
    
            var path = "/athlete";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "weight" + "}", ApiClient.ParameterToString(weight));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "strava_oauth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateLoggedInAthlete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateLoggedInAthlete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DetailedAthlete) ApiClient.Deserialize(response.Content, typeof(DetailedAthlete), response.Headers);
        }
    
    }
}
