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
  public class PhotosSummaryPrimary {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Gets or Sets Source
    /// </summary>
    [DataMember(Name="source", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source")]
    public int? Source { get; set; }

    /// <summary>
    /// Gets or Sets UniqueId
    /// </summary>
    [DataMember(Name="unique_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unique_id")]
    public string UniqueId { get; set; }

    /// <summary>
    /// Gets or Sets Urls
    /// </summary>
    [DataMember(Name="urls", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "urls")]
    public Dictionary<string, string> Urls { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PhotosSummaryPrimary {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Source: ").Append(Source).Append("\n");
      sb.Append("  UniqueId: ").Append(UniqueId).Append("\n");
      sb.Append("  Urls: ").Append(Urls).Append("\n");
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
