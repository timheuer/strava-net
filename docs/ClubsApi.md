# Strava.NET.Api.ClubsApi

All URIs are relative to *https://www.strava.com/api/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetClubActivitiesById**](ClubsApi.md#getclubactivitiesbyid) | **GET** /clubs/{id}/activities | List Club Activities
[**GetClubAdminsById**](ClubsApi.md#getclubadminsbyid) | **GET** /clubs/{id}/admins | List Club Administrators.
[**GetClubById**](ClubsApi.md#getclubbyid) | **GET** /clubs/{id} | Get Club
[**GetClubMembersById**](ClubsApi.md#getclubmembersbyid) | **GET** /clubs/{id}/members | List Club Members
[**GetLoggedInAthleteClubs**](ClubsApi.md#getloggedinathleteclubs) | **GET** /athlete/clubs | List Athlete Clubs


<a name="getclubactivitiesbyid"></a>
# **GetClubActivitiesById**
> List<SummaryActivity> GetClubActivitiesById (int? id, int? page, int? perPage)

List Club Activities

Retrieve recent activities from members of a specific club. The authenticated athlete must belong to the requested club in order to hit this endpoint. Pagination is supported. Athlete profile visibility is respected for all activities.

### Example
```csharp
using System;
using System.Diagnostics;
using Strava.NET.Api;
using Strava.NET.Client;
using Strava.NET.Model;

namespace Example
{
    public class GetClubActivitiesByIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: strava_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ClubsApi();
            var id = 56;  // int? | The identifier of the club.
            var page = 56;  // int? | Page number. (optional) 
            var perPage = 56;  // int? | Number of items per page. Defaults to 30. (optional)  (default to 30)

            try
            {
                // List Club Activities
                List&lt;SummaryActivity&gt; result = apiInstance.GetClubActivitiesById(id, page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClubsApi.GetClubActivitiesById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The identifier of the club. | 
 **page** | **int?**| Page number. | [optional] 
 **perPage** | **int?**| Number of items per page. Defaults to 30. | [optional] [default to 30]

### Return type

[**List<SummaryActivity>**](SummaryActivity.md)

### Authorization

[strava_oauth](../README.md#strava_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclubadminsbyid"></a>
# **GetClubAdminsById**
> List<SummaryAthlete> GetClubAdminsById (int? id, int? page, int? perPage)

List Club Administrators.

Returns a list of the administrators of a given club.

### Example
```csharp
using System;
using System.Diagnostics;
using Strava.NET.Api;
using Strava.NET.Client;
using Strava.NET.Model;

namespace Example
{
    public class GetClubAdminsByIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: strava_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ClubsApi();
            var id = 56;  // int? | The identifier of the club.
            var page = 56;  // int? | Page number. (optional) 
            var perPage = 56;  // int? | Number of items per page. Defaults to 30. (optional)  (default to 30)

            try
            {
                // List Club Administrators.
                List&lt;SummaryAthlete&gt; result = apiInstance.GetClubAdminsById(id, page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClubsApi.GetClubAdminsById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The identifier of the club. | 
 **page** | **int?**| Page number. | [optional] 
 **perPage** | **int?**| Number of items per page. Defaults to 30. | [optional] [default to 30]

### Return type

[**List<SummaryAthlete>**](SummaryAthlete.md)

### Authorization

[strava_oauth](../README.md#strava_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclubbyid"></a>
# **GetClubById**
> DetailedClub GetClubById (int? id)

Get Club

Returns a given club using its identifier.

### Example
```csharp
using System;
using System.Diagnostics;
using Strava.NET.Api;
using Strava.NET.Client;
using Strava.NET.Model;

namespace Example
{
    public class GetClubByIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: strava_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ClubsApi();
            var id = 56;  // int? | The identifier of the club.

            try
            {
                // Get Club
                DetailedClub result = apiInstance.GetClubById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClubsApi.GetClubById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The identifier of the club. | 

### Return type

[**DetailedClub**](DetailedClub.md)

### Authorization

[strava_oauth](../README.md#strava_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclubmembersbyid"></a>
# **GetClubMembersById**
> List<SummaryAthlete> GetClubMembersById (int? id, int? page, int? perPage)

List Club Members

Returns a list of the athletes who are members of a given club.

### Example
```csharp
using System;
using System.Diagnostics;
using Strava.NET.Api;
using Strava.NET.Client;
using Strava.NET.Model;

namespace Example
{
    public class GetClubMembersByIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: strava_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ClubsApi();
            var id = 56;  // int? | The identifier of the club.
            var page = 56;  // int? | Page number. (optional) 
            var perPage = 56;  // int? | Number of items per page. Defaults to 30. (optional)  (default to 30)

            try
            {
                // List Club Members
                List&lt;SummaryAthlete&gt; result = apiInstance.GetClubMembersById(id, page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClubsApi.GetClubMembersById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The identifier of the club. | 
 **page** | **int?**| Page number. | [optional] 
 **perPage** | **int?**| Number of items per page. Defaults to 30. | [optional] [default to 30]

### Return type

[**List<SummaryAthlete>**](SummaryAthlete.md)

### Authorization

[strava_oauth](../README.md#strava_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getloggedinathleteclubs"></a>
# **GetLoggedInAthleteClubs**
> List<SummaryClub> GetLoggedInAthleteClubs (int? page, int? perPage)

List Athlete Clubs

Returns a list of the clubs whose membership includes the authenticated athlete.

### Example
```csharp
using System;
using System.Diagnostics;
using Strava.NET.Api;
using Strava.NET.Client;
using Strava.NET.Model;

namespace Example
{
    public class GetLoggedInAthleteClubsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: strava_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ClubsApi();
            var page = 56;  // int? | Page number. (optional) 
            var perPage = 56;  // int? | Number of items per page. Defaults to 30. (optional)  (default to 30)

            try
            {
                // List Athlete Clubs
                List&lt;SummaryClub&gt; result = apiInstance.GetLoggedInAthleteClubs(page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClubsApi.GetLoggedInAthleteClubs: " + e.Message );
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

[**List<SummaryClub>**](SummaryClub.md)

### Authorization

[strava_oauth](../README.md#strava_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

