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
    public interface IClubsApi
    {
        /// <summary>
        /// List Club Activities Retrieve recent activities from members of a specific club. The authenticated athlete must belong to the requested club in order to hit this endpoint. Pagination is supported. Athlete profile visibility is respected for all activities.
        /// </summary>
        /// <param name="id">The identifier of the club.</param>
        /// <param name="page">Page number.</param>
        /// <param name="perPage">Number of items per page. Defaults to 30.</param>
        /// <returns>List&lt;SummaryActivity&gt;</returns>
        List<SummaryActivity> GetClubActivitiesById (int? id, int? page, int? perPage);
        /// <summary>
        /// List Club Administrators. Returns a list of the administrators of a given club.
        /// </summary>
        /// <param name="id">The identifier of the club.</param>
        /// <param name="page">Page number.</param>
        /// <param name="perPage">Number of items per page. Defaults to 30.</param>
        /// <returns>List&lt;SummaryAthlete&gt;</returns>
        List<SummaryAthlete> GetClubAdminsById (int? id, int? page, int? perPage);
        /// <summary>
        /// Get Club Returns a given club using its identifier.
        /// </summary>
        /// <param name="id">The identifier of the club.</param>
        /// <returns>DetailedClub</returns>
        DetailedClub GetClubById (int? id);
        /// <summary>
        /// List Club Members Returns a list of the athletes who are members of a given club.
        /// </summary>
        /// <param name="id">The identifier of the club.</param>
        /// <param name="page">Page number.</param>
        /// <param name="perPage">Number of items per page. Defaults to 30.</param>
        /// <returns>List&lt;SummaryAthlete&gt;</returns>
        List<SummaryAthlete> GetClubMembersById (int? id, int? page, int? perPage);
        /// <summary>
        /// List Athlete Clubs Returns a list of the clubs whose membership includes the authenticated athlete.
        /// </summary>
        /// <param name="page">Page number.</param>
        /// <param name="perPage">Number of items per page. Defaults to 30.</param>
        /// <returns>List&lt;SummaryClub&gt;</returns>
        List<SummaryClub> GetLoggedInAthleteClubs (int? page, int? perPage);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ClubsApi : IClubsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClubsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ClubsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ClubsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ClubsApi(String basePath)
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
        /// List Club Activities Retrieve recent activities from members of a specific club. The authenticated athlete must belong to the requested club in order to hit this endpoint. Pagination is supported. Athlete profile visibility is respected for all activities.
        /// </summary>
        /// <param name="id">The identifier of the club.</param> 
        /// <param name="page">Page number.</param> 
        /// <param name="perPage">Number of items per page. Defaults to 30.</param> 
        /// <returns>List&lt;SummaryActivity&gt;</returns>            
        public List<SummaryActivity> GetClubActivitiesById (int? id, int? page, int? perPage)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClubActivitiesById");
            
    
            var path = "/clubs/{id}/activities";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClubActivitiesById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClubActivitiesById: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<SummaryActivity>) ApiClient.Deserialize(response.Content, typeof(List<SummaryActivity>), response.Headers);
        }
    
        /// <summary>
        /// List Club Administrators. Returns a list of the administrators of a given club.
        /// </summary>
        /// <param name="id">The identifier of the club.</param> 
        /// <param name="page">Page number.</param> 
        /// <param name="perPage">Number of items per page. Defaults to 30.</param> 
        /// <returns>List&lt;SummaryAthlete&gt;</returns>            
        public List<SummaryAthlete> GetClubAdminsById (int? id, int? page, int? perPage)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClubAdminsById");
            
    
            var path = "/clubs/{id}/admins";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClubAdminsById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClubAdminsById: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<SummaryAthlete>) ApiClient.Deserialize(response.Content, typeof(List<SummaryAthlete>), response.Headers);
        }
    
        /// <summary>
        /// Get Club Returns a given club using its identifier.
        /// </summary>
        /// <param name="id">The identifier of the club.</param> 
        /// <returns>DetailedClub</returns>            
        public DetailedClub GetClubById (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClubById");
            
    
            var path = "/clubs/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClubById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClubById: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DetailedClub) ApiClient.Deserialize(response.Content, typeof(DetailedClub), response.Headers);
        }
    
        /// <summary>
        /// List Club Members Returns a list of the athletes who are members of a given club.
        /// </summary>
        /// <param name="id">The identifier of the club.</param> 
        /// <param name="page">Page number.</param> 
        /// <param name="perPage">Number of items per page. Defaults to 30.</param> 
        /// <returns>List&lt;SummaryAthlete&gt;</returns>            
        public List<SummaryAthlete> GetClubMembersById (int? id, int? page, int? perPage)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClubMembersById");
            
    
            var path = "/clubs/{id}/members";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClubMembersById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClubMembersById: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<SummaryAthlete>) ApiClient.Deserialize(response.Content, typeof(List<SummaryAthlete>), response.Headers);
        }
    
        /// <summary>
        /// List Athlete Clubs Returns a list of the clubs whose membership includes the authenticated athlete.
        /// </summary>
        /// <param name="page">Page number.</param> 
        /// <param name="perPage">Number of items per page. Defaults to 30.</param> 
        /// <returns>List&lt;SummaryClub&gt;</returns>            
        public List<SummaryClub> GetLoggedInAthleteClubs (int? page, int? perPage)
        {
            
    
            var path = "/athlete/clubs";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetLoggedInAthleteClubs: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetLoggedInAthleteClubs: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<SummaryClub>) ApiClient.Deserialize(response.Content, typeof(List<SummaryClub>), response.Headers);
        }
    
    }
}
