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
  public class ActivityZone {
    /// <summary>
    /// Gets or Sets Score
    /// </summary>
    [DataMember(Name="score", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "score")]
    public int? Score { get; set; }

    /// <summary>
    /// Gets or Sets DistributionBuckets
    /// </summary>
    [DataMember(Name="distribution_buckets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "distribution_buckets")]
    public TimedZoneDistribution DistributionBuckets { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets SensorBased
    /// </summary>
    [DataMember(Name="sensor_based", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sensor_based")]
    public bool? SensorBased { get; set; }

    /// <summary>
    /// Gets or Sets Points
    /// </summary>
    [DataMember(Name="points", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "points")]
    public int? Points { get; set; }

    /// <summary>
    /// Gets or Sets CustomZones
    /// </summary>
    [DataMember(Name="custom_zones", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "custom_zones")]
    public bool? CustomZones { get; set; }

    /// <summary>
    /// Gets or Sets Max
    /// </summary>
    [DataMember(Name="max", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "max")]
    public int? Max { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ActivityZone {\n");
      sb.Append("  Score: ").Append(Score).Append("\n");
      sb.Append("  DistributionBuckets: ").Append(DistributionBuckets).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  SensorBased: ").Append(SensorBased).Append("\n");
      sb.Append("  Points: ").Append(Points).Append("\n");
      sb.Append("  CustomZones: ").Append(CustomZones).Append("\n");
      sb.Append("  Max: ").Append(Max).Append("\n");
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
