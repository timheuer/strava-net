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
    public interface IRunningRacesApi
    {
        /// <summary>
        /// Get Running Race Returns a running race for a given identifier.
        /// </summary>
        /// <param name="id">The identifier of the running race.</param>
        /// <returns>RunningRace</returns>
        RunningRace GetRunningRaceById (int? id);
        /// <summary>
        /// List Running Races Returns a list running races based on a set of search criteria.
        /// </summary>
        /// <param name="year">Filters the list by a given year.</param>
        /// <returns>List&lt;RunningRace&gt;</returns>
        List<RunningRace> GetRunningRaces (int? year);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RunningRacesApi : IRunningRacesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RunningRacesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public RunningRacesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RunningRacesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RunningRacesApi(String basePath)
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
        /// Get Running Race Returns a running race for a given identifier.
        /// </summary>
        /// <param name="id">The identifier of the running race.</param> 
        /// <returns>RunningRace</returns>            
        public RunningRace GetRunningRaceById (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetRunningRaceById");
            
    
            var path = "/running_races/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetRunningRaceById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRunningRaceById: " + response.ErrorMessage, response.ErrorMessage);
    
            return (RunningRace) ApiClient.Deserialize(response.Content, typeof(RunningRace), response.Headers);
        }
    
        /// <summary>
        /// List Running Races Returns a list running races based on a set of search criteria.
        /// </summary>
        /// <param name="year">Filters the list by a given year.</param> 
        /// <returns>List&lt;RunningRace&gt;</returns>            
        public List<RunningRace> GetRunningRaces (int? year)
        {
            
    
            var path = "/running_races";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (year != null) queryParams.Add("year", ApiClient.ParameterToString(year)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "strava_oauth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRunningRaces: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRunningRaces: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RunningRace>) ApiClient.Deserialize(response.Content, typeof(List<RunningRace>), response.Headers);
        }
    
    }
}
