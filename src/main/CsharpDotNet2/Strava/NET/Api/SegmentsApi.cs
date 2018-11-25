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
    public interface ISegmentsApi
    {
        /// <summary>
        /// Explore segments Returns the top 10 segments matching a specified query.
        /// </summary>
        /// <param name="bounds">The latitude and longitude for two points describing a rectangular boundary for the search: [southwest corner latitutde, southwest corner longitude, northeast corner latitude, northeast corner longitude]</param>
        /// <param name="activityType">Desired activity type.</param>
        /// <param name="minCat">The minimum climbing category.</param>
        /// <param name="maxCat">The maximum climbing category.</param>
        /// <returns>ExplorerResponse</returns>
        ExplorerResponse ExploreSegments (List<float?> bounds, string activityType, int? minCat, int? maxCat);
        /// <summary>
        /// Get Segment Leaderboard Returns the specified segment leaderboard.
        /// </summary>
        /// <param name="id">The identifier of the segment leaderboard.</param>
        /// <param name="gender">Filter by gender.</param>
        /// <param name="ageGroup">Summit Feature. Filter by age group.</param>
        /// <param name="weightClass">Summit Feature. Filter by weight class.</param>
        /// <param name="following">Filter by friends of the authenticated athlete.</param>
        /// <param name="clubId">Filter by club.</param>
        /// <param name="dateRange">Filter by date range.</param>
        /// <param name="contextEntries"></param>
        /// <param name="page">Page number.</param>
        /// <param name="perPage">Number of items per page. Defaults to 30.</param>
        /// <returns>SegmentLeaderboard</returns>
        SegmentLeaderboard GetLeaderboardBySegmentId (long? id, string gender, string ageGroup, string weightClass, bool? following, long? clubId, string dateRange, int? contextEntries, int? page, int? perPage);
        /// <summary>
        /// List Starred Segments List of the authenticated athlete&#39;s starred segments. Private segments are filtered out unless requested by a token with read_all scope.
        /// </summary>
        /// <param name="page">Page number.</param>
        /// <param name="perPage">Number of items per page. Defaults to 30.</param>
        /// <returns>List&lt;SummarySegment&gt;</returns>
        List<SummarySegment> GetLoggedInAthleteStarredSegments (int? page, int? perPage);
        /// <summary>
        /// Get Segment Returns the specified segment. read_all scope required in order to retrieve athlete-specific segment information, or to retrieve private segments.
        /// </summary>
        /// <param name="id">The identifier of the segment.</param>
        /// <returns>DetailedSegment</returns>
        DetailedSegment GetSegmentById (long? id);
        /// <summary>
        /// Star Segment Stars/Unstars the given segment for the authenticated athlete. Requires profile:write scope.
        /// </summary>
        /// <param name="id">The identifier of the segment to star.</param>
        /// <param name="starred">If true, star the segment; if false, unstar the segment.</param>
        /// <returns>DetailedSegment</returns>
        DetailedSegment StarSegment (long? id, bool? starred);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SegmentsApi : ISegmentsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SegmentsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SegmentsApi(String basePath)
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
        /// Explore segments Returns the top 10 segments matching a specified query.
        /// </summary>
        /// <param name="bounds">The latitude and longitude for two points describing a rectangular boundary for the search: [southwest corner latitutde, southwest corner longitude, northeast corner latitude, northeast corner longitude]</param> 
        /// <param name="activityType">Desired activity type.</param> 
        /// <param name="minCat">The minimum climbing category.</param> 
        /// <param name="maxCat">The maximum climbing category.</param> 
        /// <returns>ExplorerResponse</returns>            
        public ExplorerResponse ExploreSegments (List<float?> bounds, string activityType, int? minCat, int? maxCat)
        {
            
            // verify the required parameter 'bounds' is set
            if (bounds == null) throw new ApiException(400, "Missing required parameter 'bounds' when calling ExploreSegments");
            
    
            var path = "/segments/explore";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (bounds != null) queryParams.Add("bounds", ApiClient.ParameterToString(bounds)); // query parameter
 if (activityType != null) queryParams.Add("activity_type", ApiClient.ParameterToString(activityType)); // query parameter
 if (minCat != null) queryParams.Add("min_cat", ApiClient.ParameterToString(minCat)); // query parameter
 if (maxCat != null) queryParams.Add("max_cat", ApiClient.ParameterToString(maxCat)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "strava_oauth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ExploreSegments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ExploreSegments: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ExplorerResponse) ApiClient.Deserialize(response.Content, typeof(ExplorerResponse), response.Headers);
        }
    
        /// <summary>
        /// Get Segment Leaderboard Returns the specified segment leaderboard.
        /// </summary>
        /// <param name="id">The identifier of the segment leaderboard.</param> 
        /// <param name="gender">Filter by gender.</param> 
        /// <param name="ageGroup">Summit Feature. Filter by age group.</param> 
        /// <param name="weightClass">Summit Feature. Filter by weight class.</param> 
        /// <param name="following">Filter by friends of the authenticated athlete.</param> 
        /// <param name="clubId">Filter by club.</param> 
        /// <param name="dateRange">Filter by date range.</param> 
        /// <param name="contextEntries"></param> 
        /// <param name="page">Page number.</param> 
        /// <param name="perPage">Number of items per page. Defaults to 30.</param> 
        /// <returns>SegmentLeaderboard</returns>            
        public SegmentLeaderboard GetLeaderboardBySegmentId (long? id, string gender, string ageGroup, string weightClass, bool? following, long? clubId, string dateRange, int? contextEntries, int? page, int? perPage)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetLeaderboardBySegmentId");
            
    
            var path = "/segments/{id}/leaderboard";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (gender != null) queryParams.Add("gender", ApiClient.ParameterToString(gender)); // query parameter
 if (ageGroup != null) queryParams.Add("age_group", ApiClient.ParameterToString(ageGroup)); // query parameter
 if (weightClass != null) queryParams.Add("weight_class", ApiClient.ParameterToString(weightClass)); // query parameter
 if (following != null) queryParams.Add("following", ApiClient.ParameterToString(following)); // query parameter
 if (clubId != null) queryParams.Add("club_id", ApiClient.ParameterToString(clubId)); // query parameter
 if (dateRange != null) queryParams.Add("date_range", ApiClient.ParameterToString(dateRange)); // query parameter
 if (contextEntries != null) queryParams.Add("context_entries", ApiClient.ParameterToString(contextEntries)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "strava_oauth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetLeaderboardBySegmentId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetLeaderboardBySegmentId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SegmentLeaderboard) ApiClient.Deserialize(response.Content, typeof(SegmentLeaderboard), response.Headers);
        }
    
        /// <summary>
        /// List Starred Segments List of the authenticated athlete&#39;s starred segments. Private segments are filtered out unless requested by a token with read_all scope.
        /// </summary>
        /// <param name="page">Page number.</param> 
        /// <param name="perPage">Number of items per page. Defaults to 30.</param> 
        /// <returns>List&lt;SummarySegment&gt;</returns>            
        public List<SummarySegment> GetLoggedInAthleteStarredSegments (int? page, int? perPage)
        {
            
    
            var path = "/segments/starred";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetLoggedInAthleteStarredSegments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetLoggedInAthleteStarredSegments: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<SummarySegment>) ApiClient.Deserialize(response.Content, typeof(List<SummarySegment>), response.Headers);
        }
    
        /// <summary>
        /// Get Segment Returns the specified segment. read_all scope required in order to retrieve athlete-specific segment information, or to retrieve private segments.
        /// </summary>
        /// <param name="id">The identifier of the segment.</param> 
        /// <returns>DetailedSegment</returns>            
        public DetailedSegment GetSegmentById (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetSegmentById");
            
    
            var path = "/segments/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetSegmentById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSegmentById: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DetailedSegment) ApiClient.Deserialize(response.Content, typeof(DetailedSegment), response.Headers);
        }
    
        /// <summary>
        /// Star Segment Stars/Unstars the given segment for the authenticated athlete. Requires profile:write scope.
        /// </summary>
        /// <param name="id">The identifier of the segment to star.</param> 
        /// <param name="starred">If true, star the segment; if false, unstar the segment.</param> 
        /// <returns>DetailedSegment</returns>            
        public DetailedSegment StarSegment (long? id, bool? starred)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling StarSegment");
            
            // verify the required parameter 'starred' is set
            if (starred == null) throw new ApiException(400, "Missing required parameter 'starred' when calling StarSegment");
            
    
            var path = "/segments/{id}/starred";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (starred != null) formParams.Add("starred", ApiClient.ParameterToString(starred)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] { "strava_oauth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling StarSegment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StarSegment: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DetailedSegment) ApiClient.Deserialize(response.Content, typeof(DetailedSegment), response.Headers);
        }
    
    }
}
