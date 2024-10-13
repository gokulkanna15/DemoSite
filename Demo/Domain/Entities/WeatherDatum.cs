using System;
using System.Collections.Generic;

namespace Demo.Domain.Entities;

public partial class WeatherDatum
{
    public string? Address { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public DateTime? DateTime { get; set; }

    public double? Maxt { get; set; }

    public double? Mint { get; set; }

    public double? Temperature { get; set; }

    public double? Precip { get; set; }

    public double? Wspd { get; set; }

    public double? Wdir { get; set; }

    public double? Wgust { get; set; }

    public double? Pressure { get; set; }
}
