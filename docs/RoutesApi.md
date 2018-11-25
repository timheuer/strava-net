# Strava.NET.Api.RoutesApi

All URIs are relative to *https://www.strava.com/api/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetRouteAsGPX**](RoutesApi.md#getrouteasgpx) | **GET** /routes/{id}/export_gpx | Export Route GPX
[**GetRouteAsTCX**](RoutesApi.md#getrouteastcx) | **GET** /routes/{id}/export_tcx | Export Route TCX
[**GetRouteById**](RoutesApi.md#getroutebyid) | **GET** /routes/{id} | Get Route
[**GetRoutesByAthleteId**](RoutesApi.md#getroutesbyathleteid) | **GET** /athletes/{id}/routes | List Athlete Routes


<a name="getrouteasgpx"></a>
# **GetRouteAsGPX**
> void GetRouteAsGPX (int? id)

Export Route GPX

Returns a GPX file of the route. Requires read_all scope for private routes.

### Example
```csharp
using System;
using System.Diagnostics;
using Strava.NET.Api;
using Strava.NET.Client;
using Strava.NET.Model;

namespace Example
{
    public class GetRouteAsGPXExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: strava_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoutesApi();
            var id = 56;  // int? | The identifier of the route.

            try
            {
                // Export Route GPX
                apiInstance.GetRouteAsGPX(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutesApi.GetRouteAsGPX: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The identifier of the route. | 

### Return type

void (empty response body)

### Authorization

[strava_oauth](../README.md#strava_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrouteastcx"></a>
# **GetRouteAsTCX**
> void GetRouteAsTCX (int? id)

Export Route TCX

Returns a TCX file of the route. Requires read_all scope for private routes.

### Example
```csharp
using System;
using System.Diagnostics;
using Strava.NET.Api;
using Strava.NET.Client;
using Strava.NET.Model;

namespace Example
{
    public class GetRouteAsTCXExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: strava_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoutesApi();
            var id = 56;  // int? | The identifier of the route.

            try
            {
                // Export Route TCX
                apiInstance.GetRouteAsTCX(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutesApi.GetRouteAsTCX: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The identifier of the route. | 

### Return type

void (empty response body)

### Authorization

[strava_oauth](../README.md#strava_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getroutebyid"></a>
# **GetRouteById**
> Route GetRouteById (int? id)

Get Route

Returns a route using its identifier. Requires read_all scope for private routes.

### Example
```csharp
using System;
using System.Diagnostics;
using Strava.NET.Api;
using Strava.NET.Client;
using Strava.NET.Model;

namespace Example
{
    public class GetRouteByIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: strava_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoutesApi();
            var id = 56;  // int? | The identifier of the route.

            try
            {
                // Get Route
                Route result = apiInstance.GetRouteById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutesApi.GetRouteById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The identifier of the route. | 

### Return type

[**Route**](Route.md)

### Authorization

[strava_oauth](../README.md#strava_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getroutesbyathleteid"></a>
# **GetRoutesByAthleteId**
> List<Route> GetRoutesByAthleteId (int? id, int? page, int? perPage)

List Athlete Routes

Returns a list of the routes created by the authenticated athlete using their athlete ID. Private routes are filtered out unless requested by a token with read_all scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Strava.NET.Api;
using Strava.NET.Client;
using Strava.NET.Model;

namespace Example
{
    public class GetRoutesByAthleteIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: strava_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoutesApi();
            var id = 56;  // int? | The identifier of the athlete.
            var page = 56;  // int? | Page number. (optional) 
            var perPage = 56;  // int? | Number of items per page. Defaults to 30. (optional)  (default to 30)

            try
            {
                // List Athlete Routes
                List&lt;Route&gt; result = apiInstance.GetRoutesByAthleteId(id, page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutesApi.GetRoutesByAthleteId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The identifier of the athlete. | 
 **page** | **int?**| Page number. | [optional] 
 **perPage** | **int?**| Number of items per page. Defaults to 30. | [optional] [default to 30]

### Return type

[**List<Route>**](Route.md)

### Authorization

[strava_oauth](../README.md#strava_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

