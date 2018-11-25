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
  public class Zones {
    /// <summary>
    /// Gets or Sets HeartRate
    /// </summary>
    [DataMember(Name="heart_rate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "heart_rate")]
    public HeartRateZoneRanges HeartRate { get; set; }

    /// <summary>
    /// Gets or Sets Power
    /// </summary>
    [DataMember(Name="power", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "power")]
    public PowerZoneRanges Power { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Zones {\n");
      sb.Append("  HeartRate: ").Append(HeartRate).Append("\n");
      sb.Append("  Power: ").Append(Power).Append("\n");
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
