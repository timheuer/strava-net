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
  public class DetailedSegment {
    /// <summary>
    /// The unique identifier of this segment
    /// </summary>
    /// <value>The unique identifier of this segment</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// The name of this segment
    /// </summary>
    /// <value>The name of this segment</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets ActivityType
    /// </summary>
    [DataMember(Name="activity_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activity_type")]
    public string ActivityType { get; set; }

    /// <summary>
    /// The segment's distance, in meters
    /// </summary>
    /// <value>The segment's distance, in meters</value>
    [DataMember(Name="distance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "distance")]
    public float? Distance { get; set; }

    /// <summary>
    /// The segment's average grade, in percents
    /// </summary>
    /// <value>The segment's average grade, in percents</value>
    [DataMember(Name="average_grade", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "average_grade")]
    public float? AverageGrade { get; set; }

    /// <summary>
    /// The segments's maximum grade, in percents
    /// </summary>
    /// <value>The segments's maximum grade, in percents</value>
    [DataMember(Name="maximum_grade", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maximum_grade")]
    public float? MaximumGrade { get; set; }

    /// <summary>
    /// The segments's highest elevation, in meters
    /// </summary>
    /// <value>The segments's highest elevation, in meters</value>
    [DataMember(Name="elevation_high", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elevation_high")]
    public float? ElevationHigh { get; set; }

    /// <summary>
    /// The segments's lowest elevation, in meters
    /// </summary>
    /// <value>The segments's lowest elevation, in meters</value>
    [DataMember(Name="elevation_low", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elevation_low")]
    public float? ElevationLow { get; set; }

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
    /// The category of the climb
    /// </summary>
    /// <value>The category of the climb</value>
    [DataMember(Name="climb_category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "climb_category")]
    public int? ClimbCategory { get; set; }

    /// <summary>
    /// The segments's city.
    /// </summary>
    /// <value>The segments's city.</value>
    [DataMember(Name="city", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "city")]
    public string City { get; set; }

    /// <summary>
    /// The segments's state or geographical region.
    /// </summary>
    /// <value>The segments's state or geographical region.</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// The segment's country.
    /// </summary>
    /// <value>The segment's country.</value>
    [DataMember(Name="country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }

    /// <summary>
    /// Whether this segment is private.
    /// </summary>
    /// <value>Whether this segment is private.</value>
    [DataMember(Name="private", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "private")]
    public bool? _Private { get; set; }

    /// <summary>
    /// Gets or Sets AthletePrEffort
    /// </summary>
    [DataMember(Name="athlete_pr_effort", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "athlete_pr_effort")]
    public SummarySegmentEffort AthletePrEffort { get; set; }

    /// <summary>
    /// The time at which the segment was created.
    /// </summary>
    /// <value>The time at which the segment was created.</value>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// The time at which the segment was last updated.
    /// </summary>
    /// <value>The time at which the segment was last updated.</value>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_at")]
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// The segment's total elevation gain.
    /// </summary>
    /// <value>The segment's total elevation gain.</value>
    [DataMember(Name="total_elevation_gain", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_elevation_gain")]
    public float? TotalElevationGain { get; set; }

    /// <summary>
    /// Gets or Sets Map
    /// </summary>
    [DataMember(Name="map", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "map")]
    public PolylineMap Map { get; set; }

    /// <summary>
    /// The total number of efforts for this segment
    /// </summary>
    /// <value>The total number of efforts for this segment</value>
    [DataMember(Name="effort_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "effort_count")]
    public int? EffortCount { get; set; }

    /// <summary>
    /// The number of unique athletes who have an effort for this segment
    /// </summary>
    /// <value>The number of unique athletes who have an effort for this segment</value>
    [DataMember(Name="athlete_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "athlete_count")]
    public int? AthleteCount { get; set; }

    /// <summary>
    /// Whether this segment is considered hazardous
    /// </summary>
    /// <value>Whether this segment is considered hazardous</value>
    [DataMember(Name="hazardous", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hazardous")]
    public bool? Hazardous { get; set; }

    /// <summary>
    /// The number of stars for this segment
    /// </summary>
    /// <value>The number of stars for this segment</value>
    [DataMember(Name="star_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "star_count")]
    public int? StarCount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DetailedSegment {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ActivityType: ").Append(ActivityType).Append("\n");
      sb.Append("  Distance: ").Append(Distance).Append("\n");
      sb.Append("  AverageGrade: ").Append(AverageGrade).Append("\n");
      sb.Append("  MaximumGrade: ").Append(MaximumGrade).Append("\n");
      sb.Append("  ElevationHigh: ").Append(ElevationHigh).Append("\n");
      sb.Append("  ElevationLow: ").Append(ElevationLow).Append("\n");
      sb.Append("  StartLatlng: ").Append(StartLatlng).Append("\n");
      sb.Append("  EndLatlng: ").Append(EndLatlng).Append("\n");
      sb.Append("  ClimbCategory: ").Append(ClimbCategory).Append("\n");
      sb.Append("  City: ").Append(City).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  _Private: ").Append(_Private).Append("\n");
      sb.Append("  AthletePrEffort: ").Append(AthletePrEffort).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  TotalElevationGain: ").Append(TotalElevationGain).Append("\n");
      sb.Append("  Map: ").Append(Map).Append("\n");
      sb.Append("  EffortCount: ").Append(EffortCount).Append("\n");
      sb.Append("  AthleteCount: ").Append(AthleteCount).Append("\n");
      sb.Append("  Hazardous: ").Append(Hazardous).Append("\n");
      sb.Append("  StarCount: ").Append(StarCount).Append("\n");
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
