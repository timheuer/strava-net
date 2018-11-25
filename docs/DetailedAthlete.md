# Strava.NET.Model.DetailedAthlete
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | The unique identifier of the athlete | [optional] 
**ResourceState** | **int?** | Resource state, indicates level of detail. Possible values: 1 -&gt; \&quot;meta\&quot;, 2 -&gt; \&quot;summary\&quot;, 3 -&gt; \&quot;detail\&quot; | [optional] 
**Firstname** | **string** | The athlete&#39;s first name. | [optional] 
**Lastname** | **string** | The athlete&#39;s last name. | [optional] 
**ProfileMedium** | **string** | URL to a 62x62 pixel profile picture. | [optional] 
**Profile** | **string** | URL to a 124x124 pixel profile picture. | [optional] 
**City** | **string** | The athlete&#39;s city. | [optional] 
**State** | **string** | The athlete&#39;s state or geographical region. | [optional] 
**Country** | **string** | The athlete&#39;s country. | [optional] 
**Sex** | **string** | The athlete&#39;s sex. | [optional] 
**Friend** | **string** | Whether the currently logged-in athlete follows this athlete. | [optional] 
**Follower** | **string** | Whether this athlete follows the currently logged-in athlete. | [optional] 
**Premium** | **bool?** | Deprecated.  Use summit field instead. Whether the athlete has any Summit subscription. | [optional] 
**Summit** | **bool?** | Whether the athlete has any Summit subscription. | [optional] 
**CreatedAt** | **DateTime?** | The time at which the athlete was created. | [optional] 
**UpdatedAt** | **DateTime?** | The time at which the athlete was last updated. | [optional] 
**FollowerCount** | **int?** | The athlete&#39;s follower count. | [optional] 
**FriendCount** | **int?** | The athlete&#39;s friend count. | [optional] 
**MutualFriendCount** | **int?** | The number or athletes mutually followed by this athlete and the currently logged-in athlete. | [optional] 
**MeasurementPreference** | **string** | The athlete&#39;s preferred unit system. | [optional] 
**Ftp** | **int?** | The athlete&#39;s FTP (Functional Threshold Power). | [optional] 
**Weight** | **float?** | The athlete&#39;s weight. | [optional] 
**Clubs** | [**List&lt;SummaryClub&gt;**](SummaryClub.md) | The athlete&#39;s clubs. | [optional] 
**Bikes** | [**List&lt;SummaryGear&gt;**](SummaryGear.md) | The athlete&#39;s bikes. | [optional] 
**Shoes** | [**List&lt;SummaryGear&gt;**](SummaryGear.md) | The athlete&#39;s shoes. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

