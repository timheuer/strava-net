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
  public class Lap {
    /// <summary>
    /// The unique identifier of this lap
    /// </summary>
    /// <value>The unique identifier of this lap</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Gets or Sets Activity
    /// </summary>
    [DataMember(Name="activity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activity")]
    public MetaActivity Activity { get; set; }

    /// <summary>
    /// Gets or Sets Athlete
    /// </summary>
    [DataMember(Name="athlete", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "athlete")]
    public MetaAthlete Athlete { get; set; }

    /// <summary>
    /// The lap's average cadence
    /// </summary>
    /// <value>The lap's average cadence</value>
    [DataMember(Name="average_cadence", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "average_cadence")]
    public float? AverageCadence { get; set; }

    /// <summary>
    /// The lap's average speed
    /// </summary>
    /// <value>The lap's average speed</value>
    [DataMember(Name="average_speed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "average_speed")]
    public float? AverageSpeed { get; set; }

    /// <summary>
    /// The lap's distance, in meters
    /// </summary>
    /// <value>The lap's distance, in meters</value>
    [DataMember(Name="distance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "distance")]
    public float? Distance { get; set; }

    /// <summary>
    /// The lap's elapsed time, in seconds
    /// </summary>
    /// <value>The lap's elapsed time, in seconds</value>
    [DataMember(Name="elapsed_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elapsed_time")]
    public int? ElapsedTime { get; set; }

    /// <summary>
    /// The start index of this effort in its activity's stream
    /// </summary>
    /// <value>The start index of this effort in its activity's stream</value>
    [DataMember(Name="start_index", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_index")]
    public int? StartIndex { get; set; }

    /// <summary>
    /// The end index of this effort in its activity's stream
    /// </summary>
    /// <value>The end index of this effort in its activity's stream</value>
    [DataMember(Name="end_index", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "end_index")]
    public int? EndIndex { get; set; }

    /// <summary>
    /// The index of this lap in the activity it belongs to
    /// </summary>
    /// <value>The index of this lap in the activity it belongs to</value>
    [DataMember(Name="lap_index", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lap_index")]
    public int? LapIndex { get; set; }

    /// <summary>
    /// The maximum speed of this lat, in meters per second
    /// </summary>
    /// <value>The maximum speed of this lat, in meters per second</value>
    [DataMember(Name="max_speed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "max_speed")]
    public float? MaxSpeed { get; set; }

    /// <summary>
    /// The lap's moving time, in seconds
    /// </summary>
    /// <value>The lap's moving time, in seconds</value>
    [DataMember(Name="moving_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "moving_time")]
    public int? MovingTime { get; set; }

    /// <summary>
    /// The name of the lap
    /// </summary>
    /// <value>The name of the lap</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The athlete's pace zone during this lap
    /// </summary>
    /// <value>The athlete's pace zone during this lap</value>
    [DataMember(Name="pace_zone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pace_zone")]
    public int? PaceZone { get; set; }

    /// <summary>
    /// Gets or Sets Split
    /// </summary>
    [DataMember(Name="split", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "split")]
    public int? Split { get; set; }

    /// <summary>
    /// The time at which the lap was started.
    /// </summary>
    /// <value>The time at which the lap was started.</value>
    [DataMember(Name="start_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_date")]
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// The time at which the lap was started in the local timezone.
    /// </summary>
    /// <value>The time at which the lap was started in the local timezone.</value>
    [DataMember(Name="start_date_local", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_date_local")]
    public DateTime? StartDateLocal { get; set; }

    /// <summary>
    /// The elevation gain of this lap, in meters
    /// </summary>
    /// <value>The elevation gain of this lap, in meters</value>
    [DataMember(Name="total_elevation_gain", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_elevation_gain")]
    public float? TotalElevationGain { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Lap {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Activity: ").Append(Activity).Append("\n");
      sb.Append("  Athlete: ").Append(Athlete).Append("\n");
      sb.Append("  AverageCadence: ").Append(AverageCadence).Append("\n");
      sb.Append("  AverageSpeed: ").Append(AverageSpeed).Append("\n");
      sb.Append("  Distance: ").Append(Distance).Append("\n");
      sb.Append("  ElapsedTime: ").Append(ElapsedTime).Append("\n");
      sb.Append("  StartIndex: ").Append(StartIndex).Append("\n");
      sb.Append("  EndIndex: ").Append(EndIndex).Append("\n");
      sb.Append("  LapIndex: ").Append(LapIndex).Append("\n");
      sb.Append("  MaxSpeed: ").Append(MaxSpeed).Append("\n");
      sb.Append("  MovingTime: ").Append(MovingTime).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  PaceZone: ").Append(PaceZone).Append("\n");
      sb.Append("  Split: ").Append(Split).Append("\n");
      sb.Append("  StartDate: ").Append(StartDate).Append("\n");
      sb.Append("  StartDateLocal: ").Append(StartDateLocal).Append("\n");
      sb.Append("  TotalElevationGain: ").Append(TotalElevationGain).Append("\n");
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
