# Strava.NET.Model.Route
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Athlete** | [**SummaryAthlete**](SummaryAthlete.md) |  | [optional] 
**Description** | **string** | The description of the route | [optional] 
**Distance** | **float?** | The route&#39;s distance, in meters | [optional] 
**ElevationGain** | **float?** | The route&#39;s elevation gain. | [optional] 
**Id** | **int?** | The unique identifier of this route | [optional] 
**Map** | [**PolylineMap**](PolylineMap.md) |  | [optional] 
**Name** | **string** | The name of this route | [optional] 
**_Private** | **bool?** | Whether this route is private | [optional] 
**Starred** | **bool?** | Whether this route is starred by the logged-in athlete | [optional] 
**Timestamp** | **int?** |  | [optional] 
**Type** | **int?** | This route&#39;s type (1 for ride, 2 for runs) | [optional] 
**SubType** | **int?** | This route&#39;s sub-type (1 for road, 2 for mountain bike, 3 for cross, 4 for trail, 5 for mixed) | [optional] 
**Segments** | [**List&lt;SummarySegment&gt;**](SummarySegment.md) | The segments traversed by this route | [optional] 
**Directions** | [**List&lt;RouteDirection&gt;**](RouteDirection.md) | The directions of this route | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

