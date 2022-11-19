using System;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace GroundStationAPIRest.Models;

public class Kilitlenme_bilgisi
{
    [property: JsonPropertyName("KilitlenmeBaslangicZamani")]
    public Saat4E? BaslangicZamani {get; set;}
    [property: JsonPropertyName("KilitlenmeBitisZamani")]
    public Saat4E? BitisZamani {get; set;}
    [property: JsonPropertyName("otonom_kilitlenme")]
    public int otonom_kilitlenme {get; set;}
    
    public override string ToString() => JsonSerializer.Serialize(this);
}