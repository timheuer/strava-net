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
    public interface IActivitiesApi
    {
        /// <summary>
        /// Create an Activity Creates a manual activity for an athlete, requires activity:write scope.
        /// </summary>
        /// <param name="name">The name of the activity.</param>
        /// <param name="type">Type of activity. For example - Run, Ride etc.</param>
        /// <param name="startDateLocal">ISO 8601 formatted date time.</param>
        /// <param name="elapsedTime">In seconds.</param>
        /// <param name="description">Description of the activity.</param>
        /// <param name="distance">In meters.</param>
        /// <param name="trainer">Set to 1 to mark as a trainer activity.</param>
        /// <param name="photoIds">List of native photo ids to attach to the activity.</param>
        /// <param name="commute">Set to 1 to mark as commute.</param>
        /// <returns>DetailedActivity</returns>
        DetailedActivity CreateActivity (string name, string type, string startDateLocal, int? elapsedTime, string description, float? distance, int? trainer, string photoIds, int? commute);
        /// <summary>
        /// Get Activity Returns the given activity that is owned by the authenticated athlete. Requires activity:read for Everyone and Followers activities. Requires activity:read_all for Only Me activities.
        /// </summary>
        /// <param name="id">The identifier of the activity.</param>
        /// <param name="includeAllEfforts">To include all segments efforts.</param>
        /// <returns>DetailedActivity</returns>
        DetailedActivity GetActivityById (long? id, bool? includeAllEfforts);
        /// <summary>
        /// List Activity Comments Returns the comments on the given activity. Requires activity:read for Everyone and Followers activities. Requires activity:read_all for Only Me activities.
        /// </summary>
        /// <param name="id">The identifier of the activity.</param>
        /// <param name="page">Page number.</param>
        /// <param name="perPage">Number of items per page. Defaults to 30.</param>
        /// <returns>List&lt;Comment&gt;</returns>
        List<Comment> GetCommentsByActivityId (long? id, int? page, int? perPage);
        /// <summary>
        /// List Activity Kudoers Returns the athletes who kudoed an activity identified by an identifier. Requires activity:read for Everyone and Followers activities. Requires activity:read_all for Only Me activities.
        /// </summary>
        /// <param name="id">The identifier of the activity.</param>
        /// <param name="page">Page number.</param>
        /// <param name="perPage">Number of items per page. Defaults to 30.</param>
        /// <returns>List&lt;SummaryAthlete&gt;</returns>
        List<SummaryAthlete> GetKudoersByActivityId (int? id, int? page, int? perPage);
        /// <summary>
        /// List Activity Laps Returns the laps of an activity identified by an identifier. Requires activity:read for Everyone and Followers activities. Requires activity:read_all for Only Me activities.
        /// </summary>
        /// <param name="id">The identifier of the activity.</param>
        /// <returns>List&lt;Lap&gt;</returns>
        List<Lap> GetLapsByActivityId (long? id);
        /// <summary>
        /// List Athlete Activities Returns the activities of an athlete for a specific identifier. Requires activity:read. Only Me activities will be filtered out unless requested by a token with activity:read_all.
        /// </summary>
        /// <param name="before">An epoch timestamp to use for filtering activities that have taken place before a certain time.</param>
        /// <param name="after">An epoch timestamp to use for filtering activities that have taken place after a certain time.</param>
        /// <param name="page">Page number.</param>
        /// <param name="perPage">Number of items per page. Defaults to 30.</param>
        /// <returns>List&lt;SummaryActivity&gt;</returns>
        List<SummaryActivity> GetLoggedInAthleteActivities (int? before, int? after, int? page, int? perPage);
        /// <summary>
        /// Get Activity Zones Summit Feature. Returns the zones of a given activity. Requires activity:read for Everyone and Followers activities. Requires activity:read_all for Only Me activities.
        /// </summary>
        /// <param name="id">The identifier of the activity.</param>
        /// <returns>List&lt;ActivityZone&gt;</returns>
        List<ActivityZone> GetZonesByActivityId (int? id);
        /// <summary>
        /// Update Activity Updates the given activity that is owned by the authenticated athlete. Requires activity:write. Also requires activity:read_all in order to update Only Me activities
        /// </summary>
        /// <param name="id">The identifier of the activity.</param>
        /// <param name="body"></param>
        /// <returns>DetailedActivity</returns>
        DetailedActivity UpdateActivityById (long? id, UpdatableActivity body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ActivitiesApi : IActivitiesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivitiesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ActivitiesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivitiesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ActivitiesApi(String basePath)
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
        /// Create an Activity Creates a manual activity for an athlete, requires activity:write scope.
        /// </summary>
        /// <param name="name">The name of the activity.</param> 
        /// <param name="type">Type of activity. For example - Run, Ride etc.</param> 
        /// <param name="startDateLocal">ISO 8601 formatted date time.</param> 
        /// <param name="elapsedTime">In seconds.</param> 
        /// <param name="description">Description of the activity.</param> 
        /// <param name="distance">In meters.</param> 
        /// <param name="trainer">Set to 1 to mark as a trainer activity.</param> 
        /// <param name="photoIds">List of native photo ids to attach to the activity.</param> 
        /// <param name="commute">Set to 1 to mark as commute.</param> 
        /// <returns>DetailedActivity</returns>            
        public DetailedActivity CreateActivity (string name, string type, string startDateLocal, int? elapsedTime, string description, float? distance, int? trainer, string photoIds, int? commute)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling CreateActivity");
            
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling CreateActivity");
            
            // verify the required parameter 'startDateLocal' is set
            if (startDateLocal == null) throw new ApiException(400, "Missing required parameter 'startDateLocal' when calling CreateActivity");
            
            // verify the required parameter 'elapsedTime' is set
            if (elapsedTime == null) throw new ApiException(400, "Missing required parameter 'elapsedTime' when calling CreateActivity");
            
    
            var path = "/activities";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (name != null) formParams.Add("name", ApiClient.ParameterToString(name)); // form parameter
if (type != null) formParams.Add("type", ApiClient.ParameterToString(type)); // form parameter
if (startDateLocal != null) formParams.Add("start_date_local", ApiClient.ParameterToString(startDateLocal)); // form parameter
if (elapsedTime != null) formParams.Add("elapsed_time", ApiClient.ParameterToString(elapsedTime)); // form parameter
if (description != null) formParams.Add("description", ApiClient.ParameterToString(description)); // form parameter
if (distance != null) formParams.Add("distance", ApiClient.ParameterToString(distance)); // form parameter
if (trainer != null) formParams.Add("trainer", ApiClient.ParameterToString(trainer)); // form parameter
if (photoIds != null) formParams.Add("photo_ids", ApiClient.ParameterToString(photoIds)); // form parameter
if (commute != null) formParams.Add("commute", ApiClient.ParameterToString(commute)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] { "strava_oauth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateActivity: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateActivity: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DetailedActivity) ApiClient.Deserialize(response.Content, typeof(DetailedActivity), response.Headers);
        }
    
        /// <summary>
        /// Get Activity Returns the given activity that is owned by the authenticated athlete. Requires activity:read for Everyone and Followers activities. Requires activity:read_all for Only Me activities.
        /// </summary>
        /// <param name="id">The identifier of the activity.</param> 
        /// <param name="includeAllEfforts">To include all segments efforts.</param> 
        /// <returns>DetailedActivity</returns>            
        public DetailedActivity GetActivityById (long? id, bool? includeAllEfforts)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetActivityById");
            
    
            var path = "/activities/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (includeAllEfforts != null) queryParams.Add("include_all_efforts", ApiClient.ParameterToString(includeAllEfforts)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "strava_oauth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetActivityById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetActivityById: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DetailedActivity) ApiClient.Deserialize(response.Content, typeof(DetailedActivity), response.Headers);
        }
    
        /// <summary>
        /// List Activity Comments Returns the comments on the given activity. Requires activity:read for Everyone and Followers activities. Requires activity:read_all for Only Me activities.
        /// </summary>
        /// <param name="id">The identifier of the activity.</param> 
        /// <param name="page">Page number.</param> 
        /// <param name="perPage">Number of items per page. Defaults to 30.</param> 
        /// <returns>List&lt;Comment&gt;</returns>            
        public List<Comment> GetCommentsByActivityId (long? id, int? page, int? perPage)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetCommentsByActivityId");
            
    
            var path = "/activities/{id}/comments";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCommentsByActivityId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCommentsByActivityId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Comment>) ApiClient.Deserialize(response.Content, typeof(List<Comment>), response.Headers);
        }
    
        /// <summary>
        /// List Activity Kudoers Returns the athletes who kudoed an activity identified by an identifier. Requires activity:read for Everyone and Followers activities. Requires activity:read_all for Only Me activities.
        /// </summary>
        /// <param name="id">The identifier of the activity.</param> 
        /// <param name="page">Page number.</param> 
        /// <param name="perPage">Number of items per page. Defaults to 30.</param> 
        /// <returns>List&lt;SummaryAthlete&gt;</returns>            
        public List<SummaryAthlete> GetKudoersByActivityId (int? id, int? page, int? perPage)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetKudoersByActivityId");
            
    
            var path = "/activities/{id}/kudos";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetKudoersByActivityId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetKudoersByActivityId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<SummaryAthlete>) ApiClient.Deserialize(response.Content, typeof(List<SummaryAthlete>), response.Headers);
        }
    
        /// <summary>
        /// List Activity Laps Returns the laps of an activity identified by an identifier. Requires activity:read for Everyone and Followers activities. Requires activity:read_all for Only Me activities.
        /// </summary>
        /// <param name="id">The identifier of the activity.</param> 
        /// <returns>List&lt;Lap&gt;</returns>            
        public List<Lap> GetLapsByActivityId (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetLapsByActivityId");
            
    
            var path = "/activities/{id}/laps";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetLapsByActivityId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetLapsByActivityId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Lap>) ApiClient.Deserialize(response.Content, typeof(List<Lap>), response.Headers);
        }
    
        /// <summary>
        /// List Athlete Activities Returns the activities of an athlete for a specific identifier. Requires activity:read. Only Me activities will be filtered out unless requested by a token with activity:read_all.
        /// </summary>
        /// <param name="before">An epoch timestamp to use for filtering activities that have taken place before a certain time.</param> 
        /// <param name="after">An epoch timestamp to use for filtering activities that have taken place after a certain time.</param> 
        /// <param name="page">Page number.</param> 
        /// <param name="perPage">Number of items per page. Defaults to 30.</param> 
        /// <returns>List&lt;SummaryActivity&gt;</returns>            
        public List<SummaryActivity> GetLoggedInAthleteActivities (int? before, int? after, int? page, int? perPage)
        {
            
    
            var path = "/athlete/activities";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (before != null) queryParams.Add("before", ApiClient.ParameterToString(before)); // query parameter
 if (after != null) queryParams.Add("after", ApiClient.ParameterToString(after)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "strava_oauth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetLoggedInAthleteActivities: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetLoggedInAthleteActivities: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<SummaryActivity>) ApiClient.Deserialize(response.Content, typeof(List<SummaryActivity>), response.Headers);
        }
    
        /// <summary>
        /// Get Activity Zones Summit Feature. Returns the zones of a given activity. Requires activity:read for Everyone and Followers activities. Requires activity:read_all for Only Me activities.
        /// </summary>
        /// <param name="id">The identifier of the activity.</param> 
        /// <returns>List&lt;ActivityZone&gt;</returns>            
        public List<ActivityZone> GetZonesByActivityId (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetZonesByActivityId");
            
    
            var path = "/activities/{id}/zones";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetZonesByActivityId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetZonesByActivityId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ActivityZone>) ApiClient.Deserialize(response.Content, typeof(List<ActivityZone>), response.Headers);
        }
    
        /// <summary>
        /// Update Activity Updates the given activity that is owned by the authenticated athlete. Requires activity:write. Also requires activity:read_all in order to update Only Me activities
        /// </summary>
        /// <param name="id">The identifier of the activity.</param> 
        /// <param name="body"></param> 
        /// <returns>DetailedActivity</returns>            
        public DetailedActivity UpdateActivityById (long? id, UpdatableActivity body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateActivityById");
            
    
            var path = "/activities/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "strava_oauth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateActivityById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateActivityById: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DetailedActivity) ApiClient.Deserialize(response.Content, typeof(DetailedActivity), response.Headers);
        }
    
    }
}
