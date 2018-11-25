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
  public class Comment {
    /// <summary>
    /// The unique identifier of this comment
    /// </summary>
    /// <value>The unique identifier of this comment</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// The identifier of the activity this comment is related to
    /// </summary>
    /// <value>The identifier of the activity this comment is related to</value>
    [DataMember(Name="activity_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activity_id")]
    public long? ActivityId { get; set; }

    /// <summary>
    /// The content of the comment
    /// </summary>
    /// <value>The content of the comment</value>
    [DataMember(Name="text", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "text")]
    public string Text { get; set; }

    /// <summary>
    /// Gets or Sets Athlete
    /// </summary>
    [DataMember(Name="athlete", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "athlete")]
    public SummaryAthlete Athlete { get; set; }

    /// <summary>
    /// The time at which this comment was created.
    /// </summary>
    /// <value>The time at which this comment was created.</value>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public DateTime? CreatedAt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Comment {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ActivityId: ").Append(ActivityId).Append("\n");
      sb.Append("  Text: ").Append(Text).Append("\n");
      sb.Append("  Athlete: ").Append(Athlete).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
