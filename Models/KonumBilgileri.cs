using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GroundStationAPIRest.Models;

public class KonumBilgileri
{
    [property: JsonPropertyName("takim_numarasi")]  
    public int? Takim_Numarasi { get; set; }

    [property: JsonPropertyName("iha_enlem")]  
    public double? IHA_Enlem { get; set; }
    [property: JsonPropertyName("iha_boylam")]  
    public double? IHA_Boylam { get; set; }
    [property: JsonPropertyName("iha_irtifa")]  
    public double? IHA_Irtifa { get; set; }

    [property: JsonPropertyName("iha_dikilme")]  
    public double? IHA_Dikilme { get; set; }
    [property: JsonPropertyName("iha_yonelme")]  
    public double? IHA_Yonelme { get; set; }
    [property: JsonPropertyName("iha_yatis")]  
    public double? IHA_Yatis { get; set; }

    [property: JsonPropertyName("zaman_farki")]  
    public int? Zaman_Farki { get; set; }

    public bool isThereLack(){
        return (Takim_Numarasi is null)||(IHA_Enlem is null)||(IHA_Boylam is null)||(IHA_Irtifa is null)
                ||(IHA_Dikilme is null)||(IHA_Yonelme is null)||(IHA_Yatis is null)||(Zaman_Farki is null);
    }

    public override string ToString() => JsonSerializer.Serialize(this);
}