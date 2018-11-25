# Strava.NET.Model.DetailedSegment
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long?** | The unique identifier of this segment | [optional] 
**Name** | **string** | The name of this segment | [optional] 
**ActivityType** | **string** |  | [optional] 
**Distance** | **float?** | The segment&#39;s distance, in meters | [optional] 
**AverageGrade** | **float?** | The segment&#39;s average grade, in percents | [optional] 
**MaximumGrade** | **float?** | The segments&#39;s maximum grade, in percents | [optional] 
**ElevationHigh** | **float?** | The segments&#39;s highest elevation, in meters | [optional] 
**ElevationLow** | **float?** | The segments&#39;s lowest elevation, in meters | [optional] 
**StartLatlng** | [**LatLng**](LatLng.md) |  | [optional] 
**EndLatlng** | [**LatLng**](LatLng.md) |  | [optional] 
**ClimbCategory** | **int?** | The category of the climb | [optional] 
**City** | **string** | The segments&#39;s city. | [optional] 
**State** | **string** | The segments&#39;s state or geographical region. | [optional] 
**Country** | **string** | The segment&#39;s country. | [optional] 
**_Private** | **bool?** | Whether this segment is private. | [optional] 
**AthletePrEffort** | [**SummarySegmentEffort**](SummarySegmentEffort.md) |  | [optional] 
**CreatedAt** | **DateTime?** | The time at which the segment was created. | [optional] 
**UpdatedAt** | **DateTime?** | The time at which the segment was last updated. | [optional] 
**TotalElevationGain** | **float?** | The segment&#39;s total elevation gain. | [optional] 
**Map** | [**PolylineMap**](PolylineMap.md) |  | [optional] 
**EffortCount** | **int?** | The total number of efforts for this segment | [optional] 
**AthleteCount** | **int?** | The number of unique athletes who have an effort for this segment | [optional] 
**Hazardous** | **bool?** | Whether this segment is considered hazardous | [optional] 
**StarCount** | **int?** | The number of stars for this segment | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

