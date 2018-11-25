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
  public class Split {
    /// <summary>
    /// The average speed of this split, in meters per second
    /// </summary>
    /// <value>The average speed of this split, in meters per second</value>
    [DataMember(Name="average_speed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "average_speed")]
    public float? AverageSpeed { get; set; }

    /// <summary>
    /// The distance of this split, in meters
    /// </summary>
    /// <value>The distance of this split, in meters</value>
    [DataMember(Name="distance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "distance")]
    public float? Distance { get; set; }

    /// <summary>
    /// The elapsed time of this split, in seconds
    /// </summary>
    /// <value>The elapsed time of this split, in seconds</value>
    [DataMember(Name="elapsed_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elapsed_time")]
    public int? ElapsedTime { get; set; }

    /// <summary>
    /// The elevation difference of this split, in meters
    /// </summary>
    /// <value>The elevation difference of this split, in meters</value>
    [DataMember(Name="elevation_difference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elevation_difference")]
    public float? ElevationDifference { get; set; }

    /// <summary>
    /// The pacing zone of this split
    /// </summary>
    /// <value>The pacing zone of this split</value>
    [DataMember(Name="pace_zone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pace_zone")]
    public int? PaceZone { get; set; }

    /// <summary>
    /// The moving time of this split, in seconds
    /// </summary>
    /// <value>The moving time of this split, in seconds</value>
    [DataMember(Name="moving_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "moving_time")]
    public int? MovingTime { get; set; }

    /// <summary>
    /// N/A
    /// </summary>
    /// <value>N/A</value>
    [DataMember(Name="split", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "split")]
    public int? _Split { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Split {\n");
      sb.Append("  AverageSpeed: ").Append(AverageSpeed).Append("\n");
      sb.Append("  Distance: ").Append(Distance).Append("\n");
      sb.Append("  ElapsedTime: ").Append(ElapsedTime).Append("\n");
      sb.Append("  ElevationDifference: ").Append(ElevationDifference).Append("\n");
      sb.Append("  PaceZone: ").Append(PaceZone).Append("\n");
      sb.Append("  MovingTime: ").Append(MovingTime).Append("\n");
      sb.Append("  _Split: ").Append(_Split).Append("\n");
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
