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
  public class SummarySegmentEffort {
    /// <summary>
    /// The unique identifier of this effort
    /// </summary>
    /// <value>The unique identifier of this effort</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// The effort's elapsed time
    /// </summary>
    /// <value>The effort's elapsed time</value>
    [DataMember(Name="elapsed_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elapsed_time")]
    public int? ElapsedTime { get; set; }

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
    /// The effort's distance in meters
    /// </summary>
    /// <value>The effort's distance in meters</value>
    [DataMember(Name="distance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "distance")]
    public float? Distance { get; set; }

    /// <summary>
    /// Whether this effort is the current best on the leaderboard
    /// </summary>
    /// <value>Whether this effort is the current best on the leaderboard</value>
    [DataMember(Name="is_kom", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_kom")]
    public bool? IsKom { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SummarySegmentEffort {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ElapsedTime: ").Append(ElapsedTime).Append("\n");
      sb.Append("  StartDate: ").Append(StartDate).Append("\n");
      sb.Append("  StartDateLocal: ").Append(StartDateLocal).Append("\n");
      sb.Append("  Distance: ").Append(Distance).Append("\n");
      sb.Append("  IsKom: ").Append(IsKom).Append("\n");
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
