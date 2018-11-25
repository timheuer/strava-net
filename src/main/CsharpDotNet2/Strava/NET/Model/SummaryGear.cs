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
  public class SummaryGear {
    /// <summary>
    /// The gear's unique identifier.
    /// </summary>
    /// <value>The gear's unique identifier.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Resource state, indicates level of detail. Possible values: 2 -> \"summary\", 3 -> \"detail\"
    /// </summary>
    /// <value>Resource state, indicates level of detail. Possible values: 2 -> \"summary\", 3 -> \"detail\"</value>
    [DataMember(Name="resource_state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resource_state")]
    public int? ResourceState { get; set; }

    /// <summary>
    /// Whether this gear's is the owner's default one.
    /// </summary>
    /// <value>Whether this gear's is the owner's default one.</value>
    [DataMember(Name="primary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "primary")]
    public bool? Primary { get; set; }

    /// <summary>
    /// The gear's name.
    /// </summary>
    /// <value>The gear's name.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The distance logged with this gear.
    /// </summary>
    /// <value>The distance logged with this gear.</value>
    [DataMember(Name="distance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "distance")]
    public float? Distance { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SummaryGear {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ResourceState: ").Append(ResourceState).Append("\n");
      sb.Append("  Primary: ").Append(Primary).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Distance: ").Append(Distance).Append("\n");
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
