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
  public class Route {
    /// <summary>
    /// Gets or Sets Athlete
    /// </summary>
    [DataMember(Name="athlete", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "athlete")]
    public SummaryAthlete Athlete { get; set; }

    /// <summary>
    /// The description of the route
    /// </summary>
    /// <value>The description of the route</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The route's distance, in meters
    /// </summary>
    /// <value>The route's distance, in meters</value>
    [DataMember(Name="distance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "distance")]
    public float? Distance { get; set; }

    /// <summary>
    /// The route's elevation gain.
    /// </summary>
    /// <value>The route's elevation gain.</value>
    [DataMember(Name="elevation_gain", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elevation_gain")]
    public float? ElevationGain { get; set; }

    /// <summary>
    /// The unique identifier of this route
    /// </summary>
    /// <value>The unique identifier of this route</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets Map
    /// </summary>
    [DataMember(Name="map", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "map")]
    public PolylineMap Map { get; set; }

    /// <summary>
    /// The name of this route
    /// </summary>
    /// <value>The name of this route</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Whether this route is private
    /// </summary>
    /// <value>Whether this route is private</value>
    [DataMember(Name="private", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "private")]
    public bool? _Private { get; set; }

    /// <summary>
    /// Whether this route is starred by the logged-in athlete
    /// </summary>
    /// <value>Whether this route is starred by the logged-in athlete</value>
    [DataMember(Name="starred", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "starred")]
    public bool? Starred { get; set; }

    /// <summary>
    /// Gets or Sets Timestamp
    /// </summary>
    [DataMember(Name="timestamp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timestamp")]
    public int? Timestamp { get; set; }

    /// <summary>
    /// This route's type (1 for ride, 2 for runs)
    /// </summary>
    /// <value>This route's type (1 for ride, 2 for runs)</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public int? Type { get; set; }

    /// <summary>
    /// This route's sub-type (1 for road, 2 for mountain bike, 3 for cross, 4 for trail, 5 for mixed)
    /// </summary>
    /// <value>This route's sub-type (1 for road, 2 for mountain bike, 3 for cross, 4 for trail, 5 for mixed)</value>
    [DataMember(Name="sub_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sub_type")]
    public int? SubType { get; set; }

    /// <summary>
    /// The segments traversed by this route
    /// </summary>
    /// <value>The segments traversed by this route</value>
    [DataMember(Name="segments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "segments")]
    public List<SummarySegment> Segments { get; set; }

    /// <summary>
    /// The directions of this route
    /// </summary>
    /// <value>The directions of this route</value>
    [DataMember(Name="directions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "directions")]
    public List<RouteDirection> Directions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Route {\n");
      sb.Append("  Athlete: ").Append(Athlete).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Distance: ").Append(Distance).Append("\n");
      sb.Append("  ElevationGain: ").Append(ElevationGain).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Map: ").Append(Map).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  _Private: ").Append(_Private).Append("\n");
      sb.Append("  Starred: ").Append(Starred).Append("\n");
      sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  SubType: ").Append(SubType).Append("\n");
      sb.Append("  Segments: ").Append(Segments).Append("\n");
      sb.Append("  Directions: ").Append(Directions).Append("\n");
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
