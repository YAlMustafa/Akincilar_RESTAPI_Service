using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GroundStationAPIRest.Models;

public class Saat4E               
{
    [property: JsonPropertyName("saat")]
    public int? Saat { get; set; }
    [property: JsonPropertyName("dakika")]
    public int? Dakika { get; set; }
    [property: JsonPropertyName("saniye")]
    public int? Saniye { get; set; }
    [property: JsonPropertyName("milisaniye")]
    public int? MiliSaniye { get; set; }

    public bool isThereLack(){
        return (Saat is null)||(Dakika is null)||(Saniye is null)||(MiliSaniye is null);
    }

    public override string ToString() => JsonSerializer.Serialize(this);
}
