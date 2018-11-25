using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Strava.NET.Model {

  /// <summary>
  /// A roll-up of metrics pertaining to a set of activities. Values are in seconds and meters.
  /// </summary>
  [DataContract]
  public class ActivityTotal {
    /// <summary>
    /// The number of activities considered in this total.
    /// </summary>
    /// <value>The number of activities considered in this total.</value>
    [DataMember(Name="count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "count")]
    public int? Count { get; set; }

    /// <summary>
    /// The total distance covered by the considered activities.
    /// </summary>
    /// <value>The total distance covered by the considered activities.</value>
    [DataMember(Name="distance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "distance")]
    public float? Distance { get; set; }

    /// <summary>
    /// The total moving time of the considered activities.
    /// </summary>
    /// <value>The total moving time of the considered activities.</value>
    [DataMember(Name="moving_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "moving_time")]
    public int? MovingTime { get; set; }

    /// <summary>
    /// The total elapsed time of the considered activities.
    /// </summary>
    /// <value>The total elapsed time of the considered activities.</value>
    [DataMember(Name="elapsed_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elapsed_time")]
    public int? ElapsedTime { get; set; }

    /// <summary>
    /// The total elevation gain of the considered activities.
    /// </summary>
    /// <value>The total elevation gain of the considered activities.</value>
    [DataMember(Name="elevation_gain", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elevation_gain")]
    public float? ElevationGain { get; set; }

    /// <summary>
    /// The total number of achievements of the considered activities.
    /// </summary>
    /// <value>The total number of achievements of the considered activities.</value>
    [DataMember(Name="achievement_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "achievement_count")]
    public int? AchievementCount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ActivityTotal {\n");
      sb.Append("  Count: ").Append(Count).Append("\n");
      sb.Append("  Distance: ").Append(Distance).Append("\n");
      sb.Append("  MovingTime: ").Append(MovingTime).Append("\n");
      sb.Append("  ElapsedTime: ").Append(ElapsedTime).Append("\n");
      sb.Append("  ElevationGain: ").Append(ElevationGain).Append("\n");
      sb.Append("  AchievementCount: ").Append(AchievementCount).Append("\n");
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
