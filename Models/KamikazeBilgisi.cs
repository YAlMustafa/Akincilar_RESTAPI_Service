using System;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace GroundStationAPIRest.Models;

public class Kamikaze_bilgisi
{
    [property: JsonPropertyName("KamikazeBaslangicZamani")]   
    public Saat4E? BaslangicZamani {get; set;}
    [property: JsonPropertyName("KamikazeBitisZamani")]
    public Saat4E? BitisZamani {get; set;}
    [property: JsonPropertyName("qrMetni")]
    public string?QR_Metni {get; set;}

    public override string ToString() => JsonSerializer.Serialize(this);
}