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
  public class BaseStream {
    /// <summary>
    /// The number of data points in this stream
    /// </summary>
    /// <value>The number of data points in this stream</value>
    [DataMember(Name="original_size", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "original_size")]
    public int? OriginalSize { get; set; }

    /// <summary>
    /// The level of detail (sampling) in which this stream was returned
    /// </summary>
    /// <value>The level of detail (sampling) in which this stream was returned</value>
    [DataMember(Name="resolution", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resolution")]
    public string Resolution { get; set; }

    /// <summary>
    /// The base series used in the case the stream was downsampled
    /// </summary>
    /// <value>The base series used in the case the stream was downsampled</value>
    [DataMember(Name="series_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "series_type")]
    public string SeriesType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BaseStream {\n");
      sb.Append("  OriginalSize: ").Append(OriginalSize).Append("\n");
      sb.Append("  Resolution: ").Append(Resolution).Append("\n");
      sb.Append("  SeriesType: ").Append(SeriesType).Append("\n");
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
