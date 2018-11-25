using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Strava.NET.Model {

  /// <summary>
  /// A row in a segment leaderboard
  /// </summary>
  [DataContract]
  public class SegmentLeaderboardEntry {
    /// <summary>
    /// The public name of the athlete
    /// </summary>
    /// <value>The public name of the athlete</value>
    [DataMember(Name="athlete_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "athlete_name")]
    public string AthleteName { get; set; }

    /// <summary>
    /// The elapsed of the segment effort associated with this entry
    /// </summary>
    /// <value>The elapsed of the segment effort associated with this entry</value>
    [DataMember(Name="elapsed_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elapsed_time")]
    public int? ElapsedTime { get; set; }

    /// <summary>
    /// The moving of the segment effort associated with this entry
    /// </summary>
    /// <value>The moving of the segment effort associated with this entry</value>
    [DataMember(Name="moving_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "moving_time")]
    public int? MovingTime { get; set; }

    /// <summary>
    /// The time at which the effort was started.
    /// </summary>
    /// <value>The time at which the effort was started.</value>
    [DataMember(Name="start_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_date")]
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// The time at which the effort was started in the local timezone.
    /// </summary>
    /// <value>The time at which the effort was started in the local timezone.</value>
    [DataMember(Name="start_date_local", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_date_local")]
    public DateTime? StartDateLocal { get; set; }

    /// <summary>
    /// The rank of this entry in the leaderboard
    /// </summary>
    /// <value>The rank of this entry in the leaderboard</value>
    [DataMember(Name="rank", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rank")]
    public int? Rank { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SegmentLeaderboardEntry {\n");
      sb.Append("  AthleteName: ").Append(AthleteName).Append("\n");
      sb.Append("  ElapsedTime: ").Append(ElapsedTime).Append("\n");
      sb.Append("  MovingTime: ").Append(MovingTime).Append("\n");
      sb.Append("  StartDate: ").Append(StartDate).Append("\n");
      sb.Append("  StartDateLocal: ").Append(StartDateLocal).Append("\n");
      sb.Append("  Rank: ").Append(Rank).Append("\n");
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
