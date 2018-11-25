using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Strava.NET.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class SummaryActivity {
    /// <summary>
    /// The unique identifier of the activity
    /// </summary>
    /// <value>The unique identifier of the activity</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// The identifier provided at upload time
    /// </summary>
    /// <value>The identifier provided at upload time</value>
    [DataMember(Name="external_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "external_id")]
    public string ExternalId { get; set; }

    /// <summary>
    /// The identifier of the upload that resulted in this activity
    /// </summary>
    /// <value>The identifier of the upload that resulted in this activity</value>
    [DataMember(Name="upload_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "upload_id")]
    public long? UploadId { get; set; }

    /// <summary>
    /// Gets or Sets Athlete
    /// </summary>
    [DataMember(Name="athlete", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "athlete")]
    public MetaAthlete Athlete { get; set; }

    /// <summary>
    /// The name of the activity
    /// </summary>
    /// <value>The name of the activity</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The activity's distance, in meters
    /// </summary>
    /// <value>The activity's distance, in meters</value>
    [DataMember(Name="distance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "distance")]
    public float? Distance { get; set; }

    /// <summary>
    /// The activity's moving time, in seconds
    /// </summary>
    /// <value>The activity's moving time, in seconds</value>
    [DataMember(Name="moving_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "moving_time")]
    public int? MovingTime { get; set; }

    /// <summary>
    /// The activity's elapsed time, in seconds
    /// </summary>
    /// <value>The activity's elapsed time, in seconds</value>
    [DataMember(Name="elapsed_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elapsed_time")]
    public int? ElapsedTime { get; set; }

    /// <summary>
    /// The activity's total elevation gain.
    /// </summary>
    /// <value>The activity's total elevation gain.</value>
    [DataMember(Name="total_elevation_gain", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_elevation_gain")]
    public float? TotalElevationGain { get; set; }

    /// <summary>
    /// The activity's highest elevation, in meters
    /// </summary>
    /// <value>The activity's highest elevation, in meters</value>
    [DataMember(Name="elev_high", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elev_high")]
    public float? ElevHigh { get; set; }

    /// <summary>
    /// The activity's lowest elevation, in meters
    /// </summary>
    /// <value>The activity's lowest elevation, in meters</value>
    [DataMember(Name="elev_low", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elev_low")]
    public float? ElevLow { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public ActivityType Type { get; set; }

    /// <summary>
    /// The time at which the activity was started.
    /// </summary>
    /// <value>The time at which the activity was started.</value>
    [DataMember(Name="start_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_date")]
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// The time at which the activity was started in the local timezone.
    /// </summary>
    /// <value>The time at which the activity was started in the local timezone.</value>
    [DataMember(Name="start_date_local", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_date_local")]
    public DateTime? StartDateLocal { get; set; }

    /// <summary>
    /// The timezone of the activity
    /// </summary>
    /// <value>The timezone of the activity</value>
    [DataMember(Name="timezone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timezone")]
    public string Timezone { get; set; }

    /// <summary>
    /// Gets or Sets StartLatlng
    /// </summary>
    [DataMember(Name="start_latlng", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_latlng")]
    public LatLng StartLatlng { get; set; }

    /// <summary>
    /// Gets or Sets EndLatlng
    /// </summary>
    [DataMember(Name="end_latlng", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "end_latlng")]
    public LatLng EndLatlng { get; set; }

    /// <summary>
    /// The number of achievements gained during this activity
    /// </summary>
    /// <value>The number of achievements gained during this activity</value>
    [DataMember(Name="achievement_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "achievement_count")]
    public int? AchievementCount { get; set; }

    /// <summary>
    /// The number of kudos given for this activity
    /// </summary>
    /// <value>The number of kudos given for this activity</value>
    [DataMember(Name="kudos_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kudos_count")]
    public int? KudosCount { get; set; }

    /// <summary>
    /// The number of comments for this activity
    /// </summary>
    /// <value>The number of comments for this activity</value>
    [DataMember(Name="comment_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comment_count")]
    public int? CommentCount { get; set; }

    /// <summary>
    /// The number of athletes for taking part in a group activity
    /// </summary>
    /// <value>The number of athletes for taking part in a group activity</value>
    [DataMember(Name="athlete_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "athlete_count")]
    public int? AthleteCount { get; set; }

    /// <summary>
    /// The number of Instagram photos for this activity
    /// </summary>
    /// <value>The number of Instagram photos for this activity</value>
    [DataMember(Name="photo_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "photo_count")]
    public int? PhotoCount { get; set; }

    /// <summary>
    /// The number of Instagram and Strava photos for this activity
    /// </summary>
    /// <value>The number of Instagram and Strava photos for this activity</value>
    [DataMember(Name="total_photo_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_photo_count")]
    public int? TotalPhotoCount { get; set; }

    /// <summary>
    /// Gets or Sets Map
    /// </summary>
    [DataMember(Name="map", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "map")]
    public PolylineMap Map { get; set; }

    /// <summary>
    /// Whether this activity was recorded on a training machine
    /// </summary>
    /// <value>Whether this activity was recorded on a training machine</value>
    [DataMember(Name="trainer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trainer")]
    public bool? Trainer { get; set; }

    /// <summary>
    /// Whether this activity is a commute
    /// </summary>
    /// <value>Whether this activity is a commute</value>
    [DataMember(Name="commute", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commute")]
    public bool? Commute { get; set; }

    /// <summary>
    /// Whether this activity was created manually
    /// </summary>
    /// <value>Whether this activity was created manually</value>
    [DataMember(Name="manual", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "manual")]
    public bool? Manual { get; set; }

    /// <summary>
    /// Whether this activity is private
    /// </summary>
    /// <value>Whether this activity is private</value>
    [DataMember(Name="private", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "private")]
    public bool? _Private { get; set; }

    /// <summary>
    /// Whether this activity is flagged
    /// </summary>
    /// <value>Whether this activity is flagged</value>
    [DataMember(Name="flagged", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "flagged")]
    public bool? Flagged { get; set; }

    /// <summary>
    /// The activity's workout type
    /// </summary>
    /// <value>The activity's workout type</value>
    [DataMember(Name="workout_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "workout_type")]
    public int? WorkoutType { get; set; }

    /// <summary>
    /// The activity's average speed, in meters per second
    /// </summary>
    /// <value>The activity's average speed, in meters per second</value>
    [DataMember(Name="average_speed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "average_speed")]
    public float? AverageSpeed { get; set; }

    /// <summary>
    /// The activity's max speed, in meters per second
    /// </summary>
    /// <value>The activity's max speed, in meters per second</value>
    [DataMember(Name="max_speed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "max_speed")]
    public float? MaxSpeed { get; set; }

    /// <summary>
    /// Whether the logged-in athlete has kudoed this activity
    /// </summary>
    /// <value>Whether the logged-in athlete has kudoed this activity</value>
    [DataMember(Name="has_kudoed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "has_kudoed")]
    public bool? HasKudoed { get; set; }

    /// <summary>
    /// The id of the gear for the activity
    /// </summary>
    /// <value>The id of the gear for the activity</value>
    [DataMember(Name="gear_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gear_id")]
    public string GearId { get; set; }

    /// <summary>
    /// The total work done in kilojoules during this activity. Rides only
    /// </summary>
    /// <value>The total work done in kilojoules during this activity. Rides only</value>
    [DataMember(Name="kilojoules", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kilojoules")]
    public float? Kilojoules { get; set; }

    /// <summary>
    /// Average power output in watts during this activity. Rides only
    /// </summary>
    /// <value>Average power output in watts during this activity. Rides only</value>
    [DataMember(Name="average_watts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "average_watts")]
    public float? AverageWatts { get; set; }

    /// <summary>
    /// Whether the watts are from a power meter, false if estimated
    /// </summary>
    /// <value>Whether the watts are from a power meter, false if estimated</value>
    [DataMember(Name="device_watts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "device_watts")]
    public bool? DeviceWatts { get; set; }

    /// <summary>
    /// Rides with power meter data only
    /// </summary>
    /// <value>Rides with power meter data only</value>
    [DataMember(Name="max_watts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "max_watts")]
    public int? MaxWatts { get; set; }

    /// <summary>
    /// Similar to Normalized Power. Rides with power meter data only
    /// </summary>
    /// <value>Similar to Normalized Power. Rides with power meter data only</value>
    [DataMember(Name="weighted_average_watts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "weighted_average_watts")]
    public int? WeightedAverageWatts { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SummaryActivity {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
      sb.Append("  UploadId: ").Append(UploadId).Append("\n");
      sb.Append("  Athlete: ").Append(Athlete).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Distance: ").Append(Distance).Append("\n");
      sb.Append("  MovingTime: ").Append(MovingTime).Append("\n");
      sb.Append("  ElapsedTime: ").Append(ElapsedTime).Append("\n");
      sb.Append("  TotalElevationGain: ").Append(TotalElevationGain).Append("\n");
      sb.Append("  ElevHigh: ").Append(ElevHigh).Append("\n");
      sb.Append("  ElevLow: ").Append(ElevLow).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  StartDate: ").Append(StartDate).Append("\n");
      sb.Append("  StartDateLocal: ").Append(StartDateLocal).Append("\n");
      sb.Append("  Timezone: ").Append(Timezone).Append("\n");
      sb.Append("  StartLatlng: ").Append(StartLatlng).Append("\n");
      sb.Append("  EndLatlng: ").Append(EndLatlng).Append("\n");
      sb.Append("  AchievementCount: ").Append(AchievementCount).Append("\n");
      sb.Append("  KudosCount: ").Append(KudosCount).Append("\n");
      sb.Append("  CommentCount: ").Append(CommentCount).Append("\n");
      sb.Append("  AthleteCount: ").Append(AthleteCount).Append("\n");
      sb.Append("  PhotoCount: ").Append(PhotoCount).Append("\n");
      sb.Append("  TotalPhotoCount: ").Append(TotalPhotoCount).Append("\n");
      sb.Append("  Map: ").Append(Map).Append("\n");
      sb.Append("  Trainer: ").Append(Trainer).Append("\n");
      sb.Append("  Commute: ").Append(Commute).Append("\n");
      sb.Append("  Manual: ").Append(Manual).Append("\n");
      sb.Append("  _Private: ").Append(_Private).Append("\n");
      sb.Append("  Flagged: ").Append(Flagged).Append("\n");
      sb.Append("  WorkoutType: ").Append(WorkoutType).Append("\n");
      sb.Append("  AverageSpeed: ").Append(AverageSpeed).Append("\n");
      sb.Append("  MaxSpeed: ").Append(MaxSpeed).Append("\n");
      sb.Append("  HasKudoed: ").Append(HasKudoed).Append("\n");
      sb.Append("  GearId: ").Append(GearId).Append("\n");
      sb.Append("  Kilojoules: ").Append(Kilojoules).Append("\n");
      sb.Append("  AverageWatts: ").Append(AverageWatts).Append("\n");
      sb.Append("  DeviceWatts: ").Append(DeviceWatts).Append("\n");
      sb.Append("  MaxWatts: ").Append(MaxWatts).Append("\n");
      sb.Append("  WeightedAverageWatts: ").Append(WeightedAverageWatts).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
