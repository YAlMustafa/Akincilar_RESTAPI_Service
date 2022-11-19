using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GroundStationAPIRest.Models;

public class Telemetri
{
    [property: JsonPropertyName("takim_numarasi")]
    public int? Takim_Numarasi { get; set; }

    [property: JsonPropertyName("IHA_enlem")]
    public double? IHA_Enlem { get; set; }
    [property: JsonPropertyName("IHA_boylam")]
    public double? IHA_Boylam { get; set; }
    [property: JsonPropertyName("IHA_irtifa")]
    public double? IHA_Irtifa { get; set; }

    [property: JsonPropertyName("IHA_dikilme")]
    public double? IHA_Dikilme { get; set; }
    [property: JsonPropertyName("IHA_yonelme")]
    public double? IHA_Yonelme { get; set; }
    [property: JsonPropertyName("IHA_yatis")]
    public double? IHA_Yatis { get; set; }

    [property: JsonPropertyName("IHA_hiz")]
    public double? IHA_Hiz { get; set; }
    [property: JsonPropertyName("IHA_batarya")]
    public float? IHA_Batarya { get; set; }
    [property: JsonPropertyName("IHA_otonom")]
    public int? IHA_Otonom { get; set; }
    [property: JsonPropertyName("IHA_kilitlenme")]
    public int? IHA_Kilitlenme { get; set; }

    [property: JsonPropertyName("Hedef_merkez_X")]
    public double? Hedef_Merkez_X { get; set; }
    [property: JsonPropertyName("Hedef_merkez_Y")]
    public double? Hedef_Merkez_Y { get; set; }
    [property: JsonPropertyName("Hedef_genislik")]
    public double? Hedef_Genislik { get; set; }
    [property: JsonPropertyName("Hedef_yukseklik")]
    public double? Hedef_Yukseklik { get; set; }

    [property: JsonPropertyName("GPSSaati")]
    public Saat4E? GPSSaati { get; set; }


    public override string ToString() => JsonSerializer.Serialize(this);
}