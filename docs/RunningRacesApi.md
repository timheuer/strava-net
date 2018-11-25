# Strava.NET.Api.RunningRacesApi

All URIs are relative to *https://www.strava.com/api/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetRunningRaceById**](RunningRacesApi.md#getrunningracebyid) | **GET** /running_races/{id} | Get Running Race
[**GetRunningRaces**](RunningRacesApi.md#getrunningraces) | **GET** /running_races | List Running Races


<a name="getrunningracebyid"></a>
# **GetRunningRaceById**
> RunningRace GetRunningRaceById (int? id)

Get Running Race

Returns a running race for a given identifier.

### Example
```csharp
using System;
using System.Diagnostics;
using Strava.NET.Api;
using Strava.NET.Client;
using Strava.NET.Model;

namespace Example
{
    public class GetRunningRaceByIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: strava_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RunningRacesApi();
            var id = 56;  // int? | The identifier of the running race.

            try
            {
                // Get Running Race
                RunningRace result = apiInstance.GetRunningRaceById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RunningRacesApi.GetRunningRaceById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The identifier of the running race. | 

### Return type

[**RunningRace**](RunningRace.md)

### Authorization

[strava_oauth](../README.md#strava_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrunningraces"></a>
# **GetRunningRaces**
> List<RunningRace> GetRunningRaces (int? year)

List Running Races

Returns a list running races based on a set of search criteria.

### Example
```csharp
using System;
using System.Diagnostics;
using Strava.NET.Api;
using Strava.NET.Client;
using Strava.NET.Model;

namespace Example
{
    public class GetRunningRacesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: strava_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RunningRacesApi();
            var year = 56;  // int? | Filters the list by a given year. (optional) 

            try
            {
                // List Running Races
                List&lt;RunningRace&gt; result = apiInstance.GetRunningRaces(year);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RunningRacesApi.GetRunningRaces: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | **int?**| Filters the list by a given year. | [optional] 

### Return type

[**List<RunningRace>**](RunningRace.md)

### Authorization

[strava_oauth](../README.md#strava_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

