using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Strava.NET.Model {

  /// <summary>
  /// A set of rolled-up statistics and totals for an athlete
  /// </summary>
  [DataContract]
  public class ActivityStats {
    /// <summary>
    /// The longest distance ridden by the athlete.
    /// </summary>
    /// <value>The longest distance ridden by the athlete.</value>
    [DataMember(Name="biggest_ride_distance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "biggest_ride_distance")]
    public double? BiggestRideDistance { get; set; }

    /// <summary>
    /// The highest climb ridden by the athlete.
    /// </summary>
    /// <value>The highest climb ridden by the athlete.</value>
    [DataMember(Name="biggest_climb_elevation_gain", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "biggest_climb_elevation_gain")]
    public double? BiggestClimbElevationGain { get; set; }

    /// <summary>
    /// The recent (last 4 weeks) ride stats for the athlete.
    /// </summary>
    /// <value>The recent (last 4 weeks) ride stats for the athlete.</value>
    [DataMember(Name="recent_ride_totals", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recent_ride_totals")]
    public ActivityTotal RecentRideTotals { get; set; }

    /// <summary>
    /// The recent (last 4 weeks) run stats for the athlete.
    /// </summary>
    /// <value>The recent (last 4 weeks) run stats for the athlete.</value>
    [DataMember(Name="recent_run_totals", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recent_run_totals")]
    public ActivityTotal RecentRunTotals { get; set; }

    /// <summary>
    /// The recent (last 4 weeks) swim stats for the athlete.
    /// </summary>
    /// <value>The recent (last 4 weeks) swim stats for the athlete.</value>
    [DataMember(Name="recent_swim_totals", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recent_swim_totals")]
    public ActivityTotal RecentSwimTotals { get; set; }

    /// <summary>
    /// The year to date ride stats for the athlete.
    /// </summary>
    /// <value>The year to date ride stats for the athlete.</value>
    [DataMember(Name="ytd_ride_totals", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ytd_ride_totals")]
    public ActivityTotal YtdRideTotals { get; set; }

    /// <summary>
    /// The year to date run stats for the athlete.
    /// </summary>
    /// <value>The year to date run stats for the athlete.</value>
    [DataMember(Name="ytd_run_totals", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ytd_run_totals")]
    public ActivityTotal YtdRunTotals { get; set; }

    /// <summary>
    /// The year to date swim stats for the athlete.
    /// </summary>
    /// <value>The year to date swim stats for the athlete.</value>
    [DataMember(Name="ytd_swim_totals", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ytd_swim_totals")]
    public ActivityTotal YtdSwimTotals { get; set; }

    /// <summary>
    /// The all time ride stats for the athlete.
    /// </summary>
    /// <value>The all time ride stats for the athlete.</value>
    [DataMember(Name="all_ride_totals", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "all_ride_totals")]
    public ActivityTotal AllRideTotals { get; set; }

    /// <summary>
    /// The all time run stats for the athlete.
    /// </summary>
    /// <value>The all time run stats for the athlete.</value>
    [DataMember(Name="all_run_totals", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "all_run_totals")]
    public ActivityTotal AllRunTotals { get; set; }

    /// <summary>
    /// The all time swim stats for the athlete.
    /// </summary>
    /// <value>The all time swim stats for the athlete.</value>
    [DataMember(Name="all_swim_totals", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "all_swim_totals")]
    public ActivityTotal AllSwimTotals { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ActivityStats {\n");
      sb.Append("  BiggestRideDistance: ").Append(BiggestRideDistance).Append("\n");
      sb.Append("  BiggestClimbElevationGain: ").Append(BiggestClimbElevationGain).Append("\n");
      sb.Append("  RecentRideTotals: ").Append(RecentRideTotals).Append("\n");
      sb.Append("  RecentRunTotals: ").Append(RecentRunTotals).Append("\n");
      sb.Append("  RecentSwimTotals: ").Append(RecentSwimTotals).Append("\n");
      sb.Append("  YtdRideTotals: ").Append(YtdRideTotals).Append("\n");
      sb.Append("  YtdRunTotals: ").Append(YtdRunTotals).Append("\n");
      sb.Append("  YtdSwimTotals: ").Append(YtdSwimTotals).Append("\n");
      sb.Append("  AllRideTotals: ").Append(AllRideTotals).Append("\n");
      sb.Append("  AllRunTotals: ").Append(AllRunTotals).Append("\n");
      sb.Append("  AllSwimTotals: ").Append(AllSwimTotals).Append("\n");
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
