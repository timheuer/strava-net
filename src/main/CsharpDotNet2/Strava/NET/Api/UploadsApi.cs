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
    public interface IUploadsApi
    {
        /// <summary>
        /// Upload Activity Uploads a new data file to create an activity from. Requires activity:write scope.
        /// </summary>
        /// <param name="file">The uploaded file.</param>
        /// <param name="name">The desired name of the resulting activity.</param>
        /// <param name="description">The desired description of the resulting activity.</param>
        /// <param name="trainer">Whether the resulting activity should be marked as having been performed on a trainer.</param>
        /// <param name="commute">Whether the resulting activity should be tagged as a commute.</param>
        /// <param name="dataType">The format of the uploaded file.</param>
        /// <param name="externalId">The desired external identifier of the resulting activity.</param>
        /// <returns>Upload</returns>
        Upload CreateUpload (System.IO.Stream file, string name, string description, string trainer, string commute, string dataType, string externalId);
        /// <summary>
        /// Get Upload Returns an upload for a given identifier. Requires activity:write scope.
        /// </summary>
        /// <param name="uploadId">The identifier of the upload.</param>
        /// <returns>Upload</returns>
        Upload GetUploadById (long? uploadId);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UploadsApi : IUploadsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UploadsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UploadsApi(String basePath)
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
        /// Upload Activity Uploads a new data file to create an activity from. Requires activity:write scope.
        /// </summary>
        /// <param name="file">The uploaded file.</param> 
        /// <param name="name">The desired name of the resulting activity.</param> 
        /// <param name="description">The desired description of the resulting activity.</param> 
        /// <param name="trainer">Whether the resulting activity should be marked as having been performed on a trainer.</param> 
        /// <param name="commute">Whether the resulting activity should be tagged as a commute.</param> 
        /// <param name="dataType">The format of the uploaded file.</param> 
        /// <param name="externalId">The desired external identifier of the resulting activity.</param> 
        /// <returns>Upload</returns>            
        public Upload CreateUpload (System.IO.Stream file, string name, string description, string trainer, string commute, string dataType, string externalId)
        {
            
    
            var path = "/uploads";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (file != null) fileParams.Add("file", ApiClient.ParameterToFile("file", file));
if (name != null) formParams.Add("name", ApiClient.ParameterToString(name)); // form parameter
if (description != null) formParams.Add("description", ApiClient.ParameterToString(description)); // form parameter
if (trainer != null) formParams.Add("trainer", ApiClient.ParameterToString(trainer)); // form parameter
if (commute != null) formParams.Add("commute", ApiClient.ParameterToString(commute)); // form parameter
if (dataType != null) formParams.Add("data_type", ApiClient.ParameterToString(dataType)); // form parameter
if (externalId != null) formParams.Add("external_id", ApiClient.ParameterToString(externalId)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] { "strava_oauth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateUpload: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateUpload: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Upload) ApiClient.Deserialize(response.Content, typeof(Upload), response.Headers);
        }
    
        /// <summary>
        /// Get Upload Returns an upload for a given identifier. Requires activity:write scope.
        /// </summary>
        /// <param name="uploadId">The identifier of the upload.</param> 
        /// <returns>Upload</returns>            
        public Upload GetUploadById (long? uploadId)
        {
            
            // verify the required parameter 'uploadId' is set
            if (uploadId == null) throw new ApiException(400, "Missing required parameter 'uploadId' when calling GetUploadById");
            
    
            var path = "/uploads/{uploadId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "uploadId" + "}", ApiClient.ParameterToString(uploadId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUploadById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUploadById: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Upload) ApiClient.Deserialize(response.Content, typeof(Upload), response.Headers);
        }
    
    }
}
