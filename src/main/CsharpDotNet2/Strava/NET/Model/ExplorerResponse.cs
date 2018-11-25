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
  public class ExplorerResponse {
    /// <summary>
    /// The set of segments matching an explorer request
    /// </summary>
    /// <value>The set of segments matching an explorer request</value>
    [DataMember(Name="segments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "segments")]
    public List<ExplorerSegment> Segments { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ExplorerResponse {\n");
      sb.Append("  Segments: ").Append(Segments).Append("\n");
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
