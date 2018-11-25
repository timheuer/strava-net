# Strava.NET.Api.SegmentsApi

All URIs are relative to *https://www.strava.com/api/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ExploreSegments**](SegmentsApi.md#exploresegments) | **GET** /segments/explore | Explore segments
[**GetLeaderboardBySegmentId**](SegmentsApi.md#getleaderboardbysegmentid) | **GET** /segments/{id}/leaderboard | Get Segment Leaderboard
[**GetLoggedInAthleteStarredSegments**](SegmentsApi.md#getloggedinathletestarredsegments) | **GET** /segments/starred | List Starred Segments
[**GetSegmentById**](SegmentsApi.md#getsegmentbyid) | **GET** /segments/{id} | Get Segment
[**StarSegment**](SegmentsApi.md#starsegment) | **PUT** /segments/{id}/starred | Star Segment


<a name="exploresegments"></a>
# **ExploreSegments**
> ExplorerResponse ExploreSegments (List<float?> bounds, string activityType, int? minCat, int? maxCat)

Explore segments

Returns the top 10 segments matching a specified query.

### Example
```csharp
using System;
using System.Diagnostics;
using Strava.NET.Api;
using Strava.NET.Client;
using Strava.NET.Model;

namespace Example
{
    public class ExploreSegmentsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: strava_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SegmentsApi();
            var bounds = new List<float?>(); // List<float?> | The latitude and longitude for two points describing a rectangular boundary for the search: [southwest corner latitutde, southwest corner longitude, northeast corner latitude, northeast corner longitude]
            var activityType = activityType_example;  // string | Desired activity type. (optional) 
            var minCat = 56;  // int? | The minimum climbing category. (optional) 
            var maxCat = 56;  // int? | The maximum climbing category. (optional) 

            try
            {
                // Explore segments
                ExplorerResponse result = apiInstance.ExploreSegments(bounds, activityType, minCat, maxCat);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SegmentsApi.ExploreSegments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bounds** | [**List<float?>**](float?.md)| The latitude and longitude for two points describing a rectangular boundary for the search: [southwest corner latitutde, southwest corner longitude, northeast corner latitude, northeast corner longitude] | 
 **activityType** | **string**| Desired activity type. | [optional] 
 **minCat** | **int?**| The minimum climbing category. | [optional] 
 **maxCat** | **int?**| The maximum climbing category. | [optional] 

### Return type

[**ExplorerResponse**](ExplorerResponse.md)

### Authorization

[strava_oauth](../README.md#strava_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getleaderboardbysegmentid"></a>
# **GetLeaderboardBySegmentId**
> SegmentLeaderboard GetLeaderboardBySegmentId (long? id, string gender, string ageGroup, string weightClass, bool? following, long? clubId, string dateRange, int? contextEntries, int? page, int? perPage)

Get Segment Leaderboard

Returns the specified segment leaderboard.

### Example
```csharp
using System;
using System.Diagnostics;
using Strava.NET.Api;
using Strava.NET.Client;
using Strava.NET.Model;

namespace Example
{
    public class GetLeaderboardBySegmentIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: strava_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SegmentsApi();
            var id = 789;  // long? | The identifier of the segment leaderboard.
            var gender = gender_example;  // string | Filter by gender. (optional) 
            var ageGroup = ageGroup_example;  // string | Summit Feature. Filter by age group. (optional) 
            var weightClass = weightClass_example;  // string | Summit Feature. Filter by weight class. (optional) 
            var following = true;  // bool? | Filter by friends of the authenticated athlete. (optional) 
            var clubId = 789;  // long? | Filter by club. (optional) 
            var dateRange = dateRange_example;  // string | Filter by date range. (optional) 
            var contextEntries = 56;  // int? |  (optional) 
            var page = 56;  // int? | Page number. (optional) 
            var perPage = 56;  // int? | Number of items per page. Defaults to 30. (optional)  (default to 30)

            try
            {
                // Get Segment Leaderboard
                SegmentLeaderboard result = apiInstance.GetLeaderboardBySegmentId(id, gender, ageGroup, weightClass, following, clubId, dateRange, contextEntries, page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SegmentsApi.GetLeaderboardBySegmentId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The identifier of the segment leaderboard. | 
 **gender** | **string**| Filter by gender. | [optional] 
 **ageGroup** | **string**| Summit Feature. Filter by age group. | [optional] 
 **weightClass** | **string**| Summit Feature. Filter by weight class. | [optional] 
 **following** | **bool?**| Filter by friends of the authenticated athlete. | [optional] 
 **clubId** | **long?**| Filter by club. | [optional] 
 **dateRange** | **string**| Filter by date range. | [optional] 
 **contextEntries** | **int?**|  | [optional] 
 **page** | **int?**| Page number. | [optional] 
 **perPage** | **int?**| Number of items per page. Defaults to 30. | [optional] [default to 30]

### Return type

[**SegmentLeaderboard**](SegmentLeaderboard.md)

### Authorization

[strava_oauth](../README.md#strava_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getloggedinathletestarredsegments"></a>
# **GetLoggedInAthleteStarredSegments**
> List<SummarySegment> GetLoggedInAthleteStarredSegments (int? page, int? perPage)

List Starred Segments

List of the authenticated athlete's starred segments. Private segments are filtered out unless requested by a token with read_all scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Strava.NET.Api;
using Strava.NET.Client;
using Strava.NET.Model;

namespace Example
{
    public class GetLoggedInAthleteStarredSegmentsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: strava_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SegmentsApi();
            var page = 56;  // int? | Page number. (optional) 
            var perPage = 56;  // int? | Number of items per page. Defaults to 30. (optional)  (default to 30)

            try
            {
                // List Starred Segments
                List&lt;SummarySegment&gt; result = apiInstance.GetLoggedInAthleteStarredSegments(page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SegmentsApi.GetLoggedInAthleteStarredSegments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| Page number. | [optional] 
 **perPage** | **int?**| Number of items per page. Defaults to 30. | [optional] [default to 30]

### Return type

[**List<SummarySegment>**](SummarySegment.md)

### Authorization

[strava_oauth](../README.md#strava_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsegmentbyid"></a>
# **GetSegmentById**
> DetailedSegment GetSegmentById (long? id)

Get Segment

Returns the specified segment. read_all scope required in order to retrieve athlete-specific segment information, or to retrieve private segments.

### Example
```csharp
using System;
using System.Diagnostics;
using Strava.NET.Api;
using Strava.NET.Client;
using Strava.NET.Model;

namespace Example
{
    public class GetSegmentByIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: strava_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SegmentsApi();
            var id = 789;  // long? | The identifier of the segment.

            try
            {
                // Get Segment
                DetailedSegment result = apiInstance.GetSegmentById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SegmentsApi.GetSegmentById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The identifier of the segment. | 

### Return type

[**DetailedSegment**](DetailedSegment.md)

### Authorization

[strava_oauth](../README.md#strava_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="starsegment"></a>
# **StarSegment**
> DetailedSegment StarSegment (long? id, bool? starred)

Star Segment

Stars/Unstars the given segment for the authenticated athlete. Requires profile:write scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Strava.NET.Api;
using Strava.NET.Client;
using Strava.NET.Model;

namespace Example
{
    public class StarSegmentExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: strava_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SegmentsApi();
            var id = 789;  // long? | The identifier of the segment to star.
            var starred = true;  // bool? | If true, star the segment; if false, unstar the segment. (default to false)

            try
            {
                // Star Segment
                DetailedSegment result = apiInstance.StarSegment(id, starred);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SegmentsApi.StarSegment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The identifier of the segment to star. | 
 **starred** | **bool?**| If true, star the segment; if false, unstar the segment. | [default to false]

### Return type

[**DetailedSegment**](DetailedSegment.md)

### Authorization

[strava_oauth](../README.md#strava_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

