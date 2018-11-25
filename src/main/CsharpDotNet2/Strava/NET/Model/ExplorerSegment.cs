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
  public class ExplorerSegment {
    /// <summary>
    /// The unique identifier of this segment
    /// </summary>
    /// <value>The unique identifier of this segment</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// The name of this segment
    /// </summary>
    /// <value>The name of this segment</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The category of the climb
    /// </summary>
    /// <value>The category of the climb</value>
    [DataMember(Name="climb_category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "climb_category")]
    public int? ClimbCategory { get; set; }

    /// <summary>
    /// The description for the category of the climb
    /// </summary>
    /// <value>The description for the category of the climb</value>
    [DataMember(Name="climb_category_desc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "climb_category_desc")]
    public string ClimbCategoryDesc { get; set; }

    /// <summary>
    /// The segment's average grade, in percents
    /// </summary>
    /// <value>The segment's average grade, in percents</value>
    [DataMember(Name="avg_grade", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "avg_grade")]
    public float? AvgGrade { get; set; }

    /// <summary>
    /// Gets or Sets StartLatlng
    /// </summary>
    [DataMember(Name="start_latlng", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_latlng")]
    public LatLng StartLatlng { get; set; }

    /// <summary>
    /// Gets or Sets EndLatlng
    /// </summary>
    [DataMember(Name="end_latlng", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "end_latlng")]
    public LatLng EndLatlng { get; set; }

    /// <summary>
    /// The segments's evelation difference, in meters
    /// </summary>
    /// <value>The segments's evelation difference, in meters</value>
    [DataMember(Name="elev_difference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elev_difference")]
    public float? ElevDifference { get; set; }

    /// <summary>
    /// The segment's distance, in meters
    /// </summary>
    /// <value>The segment's distance, in meters</value>
    [DataMember(Name="distance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "distance")]
    public float? Distance { get; set; }

    /// <summary>
    /// The polyline of the segment
    /// </summary>
    /// <value>The polyline of the segment</value>
    [DataMember(Name="points", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "points")]
    public string Points { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ExplorerSegment {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ClimbCategory: ").Append(ClimbCategory).Append("\n");
      sb.Append("  ClimbCategoryDesc: ").Append(ClimbCategoryDesc).Append("\n");
      sb.Append("  AvgGrade: ").Append(AvgGrade).Append("\n");
      sb.Append("  StartLatlng: ").Append(StartLatlng).Append("\n");
      sb.Append("  EndLatlng: ").Append(EndLatlng).Append("\n");
      sb.Append("  ElevDifference: ").Append(ElevDifference).Append("\n");
      sb.Append("  Distance: ").Append(Distance).Append("\n");
      sb.Append("  Points: ").Append(Points).Append("\n");
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
