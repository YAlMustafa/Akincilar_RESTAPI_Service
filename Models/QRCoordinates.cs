using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GroundStationAPIRest.Models;

public class QRKoordinati
{
    [property: JsonPropertyName("qrEnlem")]  
    public double? QREnlem { get; set; }   //It is as X
    [property: JsonPropertyName("qrBoylam")]  
    public double? QRBoylam { get; set; }    //It is as Y

    public bool isThereLack(){
            return (QREnlem is null)||(QRBoylam is null);
    }

    public override string ToString() => JsonSerializer.Serialize(this);    
}