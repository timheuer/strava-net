# Strava.NET.Api.GearsApi

All URIs are relative to *https://www.strava.com/api/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetGearById**](GearsApi.md#getgearbyid) | **GET** /gear/{id} | Get Equipment


<a name="getgearbyid"></a>
# **GetGearById**
> DetailedGear GetGearById (int? id)

Get Equipment

Returns an equipment using its identifier.

### Example
```csharp
using System;
using System.Diagnostics;
using Strava.NET.Api;
using Strava.NET.Client;
using Strava.NET.Model;

namespace Example
{
    public class GetGearByIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: strava_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GearsApi();
            var id = 56;  // int? | The identifier of the gear.

            try
            {
                // Get Equipment
                DetailedGear result = apiInstance.GetGearById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GearsApi.GetGearById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The identifier of the gear. | 

### Return type

[**DetailedGear**](DetailedGear.md)

### Authorization

[strava_oauth](../README.md#strava_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

