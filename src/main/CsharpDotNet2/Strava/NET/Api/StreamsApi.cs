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
    public interface IStreamsApi
    {
        /// <summary>
        /// Get Activity Streams Returns the given activity&#39;s streams. Requires activity:read scope. Requires activity:read_all scope for Only Me activities.
        /// </summary>
        /// <param name="id">The identifier of the activity.</param>
        /// <param name="keys">Desired stream types.</param>
        /// <param name="keyByType">Must be true.</param>
        /// <returns>StreamSet</returns>
        StreamSet GetActivityStreams (long? id, List<string> keys, bool? keyByType);
        /// <summary>
        /// Get segment effort streams Returns a set of streams for a segment effort completed by the authenticated athlete. Requires read_all scope.
        /// </summary>
        /// <param name="id">The identifier of the segment effort.</param>
        /// <param name="keys">The types of streams to return.</param>
        /// <param name="keyByType">Must be true.</param>
        /// <returns>StreamSet</returns>
        StreamSet GetSegmentEffortStreams (long? id, List<string> keys, bool? keyByType);
        /// <summary>
        /// Get Segment Streams Returns the given segment&#39;s streams. Requires read_all scope for private segments.
        /// </summary>
        /// <param name="id">The identifier of the segment.</param>
        /// <param name="keys">The types of streams to return.</param>
        /// <param name="keyByType">Must be true.</param>
        /// <returns>StreamSet</returns>
        StreamSet GetSegmentStreams (long? id, List<string> keys, bool? keyByType);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class StreamsApi : IStreamsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StreamsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public StreamsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StreamsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StreamsApi(String basePath)
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
        /// Get Activity Streams Returns the given activity&#39;s streams. Requires activity:read scope. Requires activity:read_all scope for Only Me activities.
        /// </summary>
        /// <param name="id">The identifier of the activity.</param> 
        /// <param name="keys">Desired stream types.</param> 
        /// <param name="keyByType">Must be true.</param> 
        /// <returns>StreamSet</returns>            
        public StreamSet GetActivityStreams (long? id, List<string> keys, bool? keyByType)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetActivityStreams");
            
            // verify the required parameter 'keys' is set
            if (keys == null) throw new ApiException(400, "Missing required parameter 'keys' when calling GetActivityStreams");
            
            // verify the required parameter 'keyByType' is set
            if (keyByType == null) throw new ApiException(400, "Missing required parameter 'keyByType' when calling GetActivityStreams");
            
    
            var path = "/activities/{id}/streams";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (keys != null) queryParams.Add("keys", ApiClient.ParameterToString(keys)); // query parameter
 if (keyByType != null) queryParams.Add("key_by_type", ApiClient.ParameterToString(keyByType)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "strava_oauth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetActivityStreams: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetActivityStreams: " + response.ErrorMessage, response.ErrorMessage);
    
            return (StreamSet) ApiClient.Deserialize(response.Content, typeof(StreamSet), response.Headers);
        }
    
        /// <summary>
        /// Get segment effort streams Returns a set of streams for a segment effort completed by the authenticated athlete. Requires read_all scope.
        /// </summary>
        /// <param name="id">The identifier of the segment effort.</param> 
        /// <param name="keys">The types of streams to return.</param> 
        /// <param name="keyByType">Must be true.</param> 
        /// <returns>StreamSet</returns>            
        public StreamSet GetSegmentEffortStreams (long? id, List<string> keys, bool? keyByType)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetSegmentEffortStreams");
            
            // verify the required parameter 'keys' is set
            if (keys == null) throw new ApiException(400, "Missing required parameter 'keys' when calling GetSegmentEffortStreams");
            
            // verify the required parameter 'keyByType' is set
            if (keyByType == null) throw new ApiException(400, "Missing required parameter 'keyByType' when calling GetSegmentEffortStreams");
            
    
            var path = "/segment_efforts/{id}/streams";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (keys != null) queryParams.Add("keys", ApiClient.ParameterToString(keys)); // query parameter
 if (keyByType != null) queryParams.Add("key_by_type", ApiClient.ParameterToString(keyByType)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "strava_oauth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSegmentEffortStreams: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSegmentEffortStreams: " + response.ErrorMessage, response.ErrorMessage);
    
            return (StreamSet) ApiClient.Deserialize(response.Content, typeof(StreamSet), response.Headers);
        }
    
        /// <summary>
        /// Get Segment Streams Returns the given segment&#39;s streams. Requires read_all scope for private segments.
        /// </summary>
        /// <param name="id">The identifier of the segment.</param> 
        /// <param name="keys">The types of streams to return.</param> 
        /// <param name="keyByType">Must be true.</param> 
        /// <returns>StreamSet</returns>            
        public StreamSet GetSegmentStreams (long? id, List<string> keys, bool? keyByType)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetSegmentStreams");
            
            // verify the required parameter 'keys' is set
            if (keys == null) throw new ApiException(400, "Missing required parameter 'keys' when calling GetSegmentStreams");
            
            // verify the required parameter 'keyByType' is set
            if (keyByType == null) throw new ApiException(400, "Missing required parameter 'keyByType' when calling GetSegmentStreams");
            
    
            var path = "/segments/{id}/streams";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (keys != null) queryParams.Add("keys", ApiClient.ParameterToString(keys)); // query parameter
 if (keyByType != null) queryParams.Add("key_by_type", ApiClient.ParameterToString(keyByType)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "strava_oauth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSegmentStreams: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSegmentStreams: " + response.ErrorMessage, response.ErrorMessage);
    
            return (StreamSet) ApiClient.Deserialize(response.Content, typeof(StreamSet), response.Headers);
        }
    
    }
}
