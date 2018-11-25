# Strava.NET.Api.UploadsApi

All URIs are relative to *https://www.strava.com/api/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateUpload**](UploadsApi.md#createupload) | **POST** /uploads | Upload Activity
[**GetUploadById**](UploadsApi.md#getuploadbyid) | **GET** /uploads/{uploadId} | Get Upload


<a name="createupload"></a>
# **CreateUpload**
> Upload CreateUpload (System.IO.Stream file, string name, string description, string trainer, string commute, string dataType, string externalId)

Upload Activity

Uploads a new data file to create an activity from. Requires activity:write scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Strava.NET.Api;
using Strava.NET.Client;
using Strava.NET.Model;

namespace Example
{
    public class CreateUploadExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: strava_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UploadsApi();
            var file = new System.IO.Stream(); // System.IO.Stream | The uploaded file. (optional) 
            var name = name_example;  // string | The desired name of the resulting activity. (optional) 
            var description = description_example;  // string | The desired description of the resulting activity. (optional) 
            var trainer = trainer_example;  // string | Whether the resulting activity should be marked as having been performed on a trainer. (optional) 
            var commute = commute_example;  // string | Whether the resulting activity should be tagged as a commute. (optional) 
            var dataType = dataType_example;  // string | The format of the uploaded file. (optional) 
            var externalId = externalId_example;  // string | The desired external identifier of the resulting activity. (optional) 

            try
            {
                // Upload Activity
                Upload result = apiInstance.CreateUpload(file, name, description, trainer, commute, dataType, externalId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UploadsApi.CreateUpload: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| The uploaded file. | [optional] 
 **name** | **string**| The desired name of the resulting activity. | [optional] 
 **description** | **string**| The desired description of the resulting activity. | [optional] 
 **trainer** | **string**| Whether the resulting activity should be marked as having been performed on a trainer. | [optional] 
 **commute** | **string**| Whether the resulting activity should be tagged as a commute. | [optional] 
 **dataType** | **string**| The format of the uploaded file. | [optional] 
 **externalId** | **string**| The desired external identifier of the resulting activity. | [optional] 

### Return type

[**Upload**](Upload.md)

### Authorization

[strava_oauth](../README.md#strava_oauth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuploadbyid"></a>
# **GetUploadById**
> Upload GetUploadById (long? uploadId)

Get Upload

Returns an upload for a given identifier. Requires activity:write scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Strava.NET.Api;
using Strava.NET.Client;
using Strava.NET.Model;

namespace Example
{
    public class GetUploadByIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: strava_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UploadsApi();
            var uploadId = 789;  // long? | The identifier of the upload.

            try
            {
                // Get Upload
                Upload result = apiInstance.GetUploadById(uploadId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UploadsApi.GetUploadById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uploadId** | **long?**| The identifier of the upload. | 

### Return type

[**Upload**](Upload.md)

### Authorization

[strava_oauth](../README.md#strava_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

